using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.Models;
using vms.service.dbo;
using vms.utility;
using Inventory.Utility;
using vms.utility.StaticData;
using X.PagedList;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Text.RegularExpressions;

namespace Inventory.Controllers
{
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _service;
        private readonly ISaleDetailService _detailService;
        private readonly IVendorService _vendorService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ISalePaymentService _paymentService;
        private readonly IStockService _stockService;
        private readonly ISaleContentService _contentService;
        private readonly IEmployeService _employeService;
        private readonly ICustomerService _customerService;
        public SaleController(
            ICustomerService customerService,
            IEmployeService employeService,
            ControllerBaseParamModel controllerBaseParamModel,
            IHostingEnvironment hostingEnvironment,
            ISaleService service,
            IVendorService vendorService,
            ISaleDetailService detailService,
            ISalePaymentService paymentService,
            IStockService stockService,
            ISaleContentService contentService

            ) : base(controllerBaseParamModel)
        {
            _customerService = customerService;
            _employeService = employeService;
            _vendorService = vendorService;
            _hostingEnvironment = hostingEnvironment;
            _service = service;
            _detailService = detailService;
            _paymentService = paymentService;
            _stockService = stockService;
            _contentService = contentService;
        }

        public async System.Threading.Tasks.Task<IActionResult> Index(int? page, string search = null)
        {
            var getPurchase = await _service.Query().Where(c => c.BranchId == _session.BranchId)
               
                .Include(c => c.Branch)
                .OrderByDescending(c => c.SalesId).SelectAsync(CancellationToken.None);
            if (search != null)
            {
                search = search.ToLower().Trim();
                getPurchase = getPurchase.Where(c => c.SaleInvoiceNo.ToLower().Contains(search)
                );
                ViewData[ViewStaticData.SEARCH_TEXT] = search;
            }
            else
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = string.Empty;
            }
            var pageNumber = page ?? 1;
            var listOfPurchase = getPurchase.ToPagedList(pageNumber, 10);

            return View(listOfPurchase);
            
        }
        public async System.Threading.Tasks.Task<IActionResult> Create()
        {
            //var createdBy = _session.UserId;
            var branchId = _session.BranchId;
            ViewData[ControllerStaticData.VENDOR_ID] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(await _vendorService.Query().SelectAsync(), ControllerStaticData.VENDOR_ID, ViewStaticData.NAME);
            ViewData["Emp"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(await _employeService.Query().SelectAsync(), "EmployeId", ViewStaticData.NAME);

            return View();
        }
        public async Task<FileSaveFeedbackDto> FileSaveAsync(IFormFile File)
        {
            FileSaveFeedbackDto fdto = new FileSaveFeedbackDto();
            var FileExtenstion = Path.GetExtension(File.FileName);

            string FileName = Guid.NewGuid().ToString();

            FileName += FileExtenstion;
            var FolderName = ControllerStaticData.APPLICATION_DOCUMENT + "Product";
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, FolderName);

            fdto.MimeType = FileExtenstion;
            bool exists = Directory.Exists(uploads);
            if (!exists)
            {
                Directory.CreateDirectory(uploads);
            }
            if (File.Length > 0)
            {
                var filePath = Path.Combine(uploads, File.FileName);
                fdto.FileUrl = filePath;
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await File.CopyToAsync(fileStream);
                }
            }
            return fdto;
        }
        [HttpPost]
        public async System.Threading.Tasks.Task<JsonResult> Create(vmSale vm)
        {
            var createdBy = _session.UserId;
            var branchId = _session.BranchId;
            bool status = false;
            if (vm.SalesDetailList.Count < 0)
            {
                return Json(status);
            }

            try
            {
                //For Purchase insert 
                Sale sale = new Sale();
                //Get Payable Amount 
                decimal payableAmount = 0;
                decimal paidAmount = 0;
                decimal totalDiscountPerItem = 0;
                decimal NoOfIteams = 0;
                decimal totalVat = 0;
                foreach (var detail in vm.SalesDetailList)
                {
                    NoOfIteams += detail.Qty.Value;
                    payableAmount += detail.UnitPrice.Value * detail.Qty.Value;
                    totalDiscountPerItem += detail.DiscountPerItem.Value;
                    totalVat += detail.Vatpercent.Value;
                }

                if (vm.SalesPaymentReceiveJson == null)
                {
                    paidAmount = 0;
                }
                else
                {
                    foreach (var detail in vm.SalesPaymentReceiveJson)
                    {
                        paidAmount += detail.PaidAmount.Value;
                    }
                }

                var customer = _customerService.Queryable().AsQueryable().SingleOrDefault(c => c.Mobile.Equals(vm.CustomerMobile));
                //Generate Invoice and Voucher No
                var voucher = DateTime.Now.ToLocalTime().ToString();
                //  purchase.IsActive = true;
                Regex reg = new Regex("[*'\",_-&^@]");
                sale.SaleInvoiceNo = "SIV#" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                sale.SaleInvoiceNo = reg.Replace(sale.SaleInvoiceNo, "0");
                sale.VoucherNo = null;
                sale.NoOfIteams = NoOfIteams;
                if (customer!=null)
                {
                    sale.CustomerId = customer.CustomerId;
                }
                else
                {
                    sale.CustomerId = null;
                }

                sale.TotalVat = payableAmount * (totalVat / 100);
                sale.BranchId = _session.BranchId;
                sale.TotalPriceWithoutVat = payableAmount;
                sale.PaymentReceiveAmount = paidAmount;
                sale.DiscountOnTotalPrice = vm.DiscountOnTotalPrice;
                sale.TotalDiscountOnIndividualProduct = totalDiscountPerItem;
                sale.SoldBy = vm.SoldBy;
                sale.IsActive = true;
                sale.CreatedBy = createdBy;
                sale.CreatedTime = DateTime.Now;
                _service.Insert(sale);
                if (vm.SalesDetailList.Count > 0)
                {
                    foreach (var item in vm.SalesDetailList)
                    {
                        Stock stock = new Stock();
                        SalesDetail detail = new SalesDetail();
                        detail.SaleId = sale.SalesId;
                        detail.ProductId = item.ProductId;
                        var stockId = _stockService.Queryable().AsQueryable().SingleOrDefault(c =>
                            c.ProductId == item.ProductId && c.BranchId == _session.BranchId && c.CurrentStock > 0);
                        detail.StockId = stockId.StockId;
                        detail.Qty = item.Qty;
                        detail.UnitPrice = item.UnitPrice;
                        detail.DiscountPerItem = item.DiscountPerItem;
                        detail.Vatpercent = item.Vatpercent;
                        detail.CreatedBy = _session.UserId;
                        detail.CreatedTime=DateTime.Now;
                        _detailService.Insert(detail);
                      
                    }

                    // await UnitOfWork.SaveChangesAsync();
                }
                //PurchasePayment payment
                if (vm.SalesPaymentReceiveJson != null)
                {

                    foreach (var item in vm.SalesPaymentReceiveJson)
                    {
                        SalePayment payment = new SalePayment();
                        payment.SaleId = sale.SalesId;
                        payment.PaymentMethodId = item.PaymentMethodId;
                        payment.PaidAmount = item.PaidAmount;
                        payment.CreatedBy = _session.UserId;
                        payment.CreatedTime = DateTime.Now;
                        payment.PaymentDate = item.PaymentDate;
                        _paymentService.Insert(payment);
                    }

                    // await UnitOfWork.SaveChangesAsync();
                }
                await UnitOfWork.SaveChangesAsync();
                if (vm.ContentInfoJson != null)
                {
                    // Content content;
                    foreach (var contentInfo in vm.ContentInfoJson)
                    {
                        if (contentInfo.UploadFile != null && contentInfo.UploadFile.Length > 0)
                        {
                            var File = contentInfo.UploadFile;
                            var FileSaveFeedbackDto = await FileSaveAsync(File);
                            SaleContent content = new SaleContent();
                            content.IsActive = true;
                            content.Name = "Images";
                            // content.ContentTypeId = 1;
                            content.SaleId = sale.SalesId;
                            content.Remark = "Test";
                            content.CreatedBy = _session.UserId;
                            content.CreatedTime = DateTime.Now;
                            content.Url = FileSaveFeedbackDto.FileUrl;
                            _contentService.Insert(content);
                        }


                    }
                    await UnitOfWork.SaveChangesAsync();
                }
                return Json(true);

            }
            catch (Exception e)
            {
                return Json(status);
            }
           
        }

    }
}