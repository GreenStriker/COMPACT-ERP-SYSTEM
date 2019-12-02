using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Inventory.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vms.entity.models;
using vms.entity.viewModels;
using vms.Models;
using vms.service.dbo;
using vms.utility.StaticData;
using X.PagedList;

namespace Inventory.Controllers
{
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _service;
        private readonly IPurchaseDetailService _detailService;
        private readonly IVendorService _vendorService;
        private readonly IHostingEnvironment _hostingEnvironment;
        public PurchaseController(

            ControllerBaseParamModel controllerBaseParamModel,
            IHostingEnvironment hostingEnvironment,
            IPurchaseService service,
            IVendorService vendorService,
            IPurchaseDetailService detailService
        ) : base(controllerBaseParamModel)
        {
            _vendorService = vendorService;
            _hostingEnvironment = hostingEnvironment;
            _service = service;
            _detailService = detailService;
        }

        public async System.Threading.Tasks.Task<IActionResult> Index(int? page, string search = null)
        {
            var getPurchase = await _service.Query().Where(c => c.BranchId == _session.BranchId).Include(c => c.Vendor).OrderByDescending(c => c.PurchaseId).SelectAsync(CancellationToken.None);
            if (search != null)
            {
                search = search.ToLower().Trim();
                getPurchase = getPurchase.Where(c => c.PurchaseInvoice.ToLower().Contains(search)
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
        public async System.Threading.Tasks.Task<JsonResult> Create(vmPurchase vm)
        {
            var createdBy = _session.UserId;
            var branchId = _session.BranchId;
            bool status = false;
            if (vm.PurchaseOrderDetailList.Count<0)
            {
                return Json(status);
            }
            //For Purchase insert 
            Purchase purchase = new Purchase();
            //Get Payable Amount 
            decimal payableAmount = 0;
            decimal paidAmount = 0;
            foreach (var detail in vm.PurchaseOrderDetailList)
            {
                payableAmount += detail.Amount.Value * detail.Qty.Value;
            }
            foreach (var detail in vm.PurchasePaymenJson)
            {
                paidAmount += detail.PaidAmount.Value;
            }
            //Generate Invoice and Voucher No
            var voucher = DateTime.Now.ToLocalTime().ToString();
            //  purchase.IsActive = true;
            purchase.PurchaseInvoice = vm.PurchaseInvoice;
            purchase.VoucherNo = "V" + voucher;
            purchase.VendorId = vm.VendorId;
            purchase.BranchId = _session.BranchId;
            purchase.PayableAmount = payableAmount;
            purchase.DiscountOnTotal = vm.DiscountOnTotal;
            purchase.PaidAmount = paidAmount;
            purchase.EfectiveFrom = DateTime.Now;
            purchase.EfectiveTo = null;
            purchase.IsActive = true;
            purchase.CreatedBy = createdBy;
            purchase.CreatedTime = DateTime.Now;
            _service.Insert(purchase);
            await UnitOfWork.SaveChangesAsync();
            if (vm.PurchaseOrderDetailList.Count > 0)
            {
                
                foreach (var item in vm.PurchaseOrderDetailList)
                {
                    PurchaseDetail detail = new PurchaseDetail();
                    detail.PurchaseId = purchase.PurchaseId;
                    detail.ProductId = item.ProductId;
                    detail.Qty = item.Qty;
                    detail.Amount = item.Amount;
                    detail.DiscountPerItem = item.DiscountPerItem;
                    _detailService.Insert(detail);
                }

                await UnitOfWork.SaveChangesAsync();
            }
            //PurchasePayment paymne

            if (vm.ContentInfoJson != null)
            {
                // Content content;
                foreach (var contentInfo in vm.ContentInfoJson)
                {
                    if (contentInfo.UploadFile != null && contentInfo.UploadFile.Length > 0)
                    {
                        var File = contentInfo.UploadFile;
                        var FileSaveFeedbackDto = await FileSaveAsync(File);
                        Content content = new Content();
                        content.IsActive = true;
                        content.Name = "Images";
                        // content.ContentTypeId = 1;
                        //content.ProductId = contentInfo.;
                        content.Remark = "Test";
                        content.CreatedBy = _session.UserId;
                        content.CreatedTime = DateTime.Now;
                        content.Url = FileSaveFeedbackDto.FileUrl;
                        vm.ContentInfoJsonTest.Add(content);
                    }

                }
            }

         

            return Json(status);
        }
    }
}