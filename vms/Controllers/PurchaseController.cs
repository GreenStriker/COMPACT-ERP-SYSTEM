using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Inventory.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using vms.entity.models;
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
            var getPurchase = await _service.Query().Where(c => c.BranchId == _session.BranchId).Include(c=>c.Vendor).OrderByDescending(c => c.PurchaseId).SelectAsync(CancellationToken.None);
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
        [HttpPost]
        public async System.Threading.Tasks.Task<JsonResult> Create(Purchase vm)
        {
            var createdBy = _session.UserId;
            var organizationId = _session.BranchId;
            bool status = false;

            //if (vm.ContentInfoJson != null)
            //{
            //    Content content;
            //    foreach (var contentInfo in vm.ContentInfoJson)
            //    {
            //        content = new Content();
            //        vm.ContentInfoJsonTest = new List<Content>();
            //        var File = contentInfo.UploadFile;
            //        var FileSaveFeedbackDto = await FileSaveAsync(File);
            //        content.FileUrl = FileSaveFeedbackDto.FileUrl;
            //        content.MimeType = FileSaveFeedbackDto.MimeType;
            //        content.DocumentTypeId = contentInfo.DocumentTypeId;
            //        vm.ContentInfoJsonTest.Add(content);
            //    }
            //}

            //if (vm.PurchaseOrderDetailList.Count > 0)
            //{
            //    VmPurchase vmPurchase = new VmPurchase();
            //    vmPurchase.PurchaseOrderDetailList = vm.PurchaseOrderDetailList;
            //    vmPurchase.ContentInfoJson = vm.ContentInfoJsonTest;
            //    vmPurchase.PurchasePaymenJson = vm.PurchasePaymenJson;
            //    vmPurchase.OrganizationId = organizationId;
            //    vmPurchase.VendorId = vm.VendorId;
            //    vmPurchase.VatChallanNo = vm.VatChallanNo;
            //    vmPurchase.VatChallanIssueDate = vm.VatChallanIssueDate;
            //    vmPurchase.VendorInvoiceNo = vm.VendorInvoiceNo;
            //    vmPurchase.InvoiceNo = vm.InvoiceNo;
            //    vmPurchase.PurchaseTypeId = vm.PurchaseTypeId;
            //    vmPurchase.PurchaseReasonId = vm.PurchaseReasonId;
            //    vmPurchase.DiscountOnTotalPrice = vm.DiscountOnTotalPrice;
            //    vmPurchase.IsVatDeductedInSource = vm.IsVatDeductedInSource;
            //    vmPurchase.PaidAmount = vm.PaidAmount;
            //    vmPurchase.ExpectedDeliveryDate = vm.ExpectedDeliveryDate;
            //    vmPurchase.DeliveryDate = DateTime.Now;
            //    vmPurchase.LcNo = vm.LcNo;
            //    vmPurchase.LcDate = vm.LcDate;
            //    vmPurchase.BillOfEntry = vm.BillOfEntry;
            //    vmPurchase.BillOfEntryDate = vm.BillOfEntryDate;
            //    vmPurchase.DueDate = vm.DueDate;
            //    vmPurchase.TermsOfLc = vm.TermsOfLc;
            //    vmPurchase.PoNumber = vm.PoNumber;
            //    vmPurchase.MushakGenerationId = vm.MushakGenerationId;
            //    vmPurchase.IsComplete = true;
            //    vmPurchase.CreatedBy = createdBy;
            //    vmPurchase.CreatedTime = DateTime.Now;
            //    vmPurchase.VDSAmount = vm.VDSAmount;

            //    status = await _purchaseOrderService.InsertData(vmPurchase);
            //}

            return Json(status);
        }
    }
}