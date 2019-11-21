using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Inventory.Models;
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
    public class ProductsController : ControllerBase
    {
        private readonly IVatService _vatService;
        private readonly IProductService _prodService;
        private readonly IProductLogService _logService;
        private readonly IMesureUnitService _unitService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IContentService _contentService;
        public ProductsController(
            IContentService contentService,
            ControllerBaseParamModel controllerBaseParamModel,
            IHostingEnvironment hostingEnvironment,
            IVatService vatService,
            IProductService prodService,
            IProductLogService logService,
            IMesureUnitService unitService
        ) : base(controllerBaseParamModel)
        {
            _contentService = contentService;
            _hostingEnvironment = hostingEnvironment;
            _vatService = vatService;
            _prodService = prodService;
            _logService = logService;
            _unitService = unitService;
        }
        public async Task<IActionResult> Index(int? page, string search = null)
        {
            var data =await _prodService.Query()
                .Include(c=>c.Munit)
                .Include(c=>c.Vat)
               // .Include(c=>c.Contents)
                .Where(c=>c.IsActive==true)
                .SelectAsync(CancellationToken.None);
            string txt = search;

            if (search != null)
            {
                search = search.ToLower().Trim();
                data = data.Where(c => c.Name.ToLower().Contains(search)
                                              
                                               || (c.Code != null && (c.Code.ToLower().Contains(search)))
                                               || (c.ModelNo != null && (c.ModelNo.ToString().Contains(search)))   
                );
            }

            var pageNumber = page ?? 1;
            var listOfProduct = data.ToPagedList(pageNumber, 10);
            if (txt != null)
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = txt;
            }
            else
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = string.Empty;
            }
            return View(listOfProduct);
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
        public async Task<IActionResult> Create()
        {
            var prodVat =await _vatService.GetAll();
            var prodUnit = await _unitService.GetAll();
            IEnumerable<SelectListItems> prodVats = prodVat.Where(c => c.IsActive == true).Select(s => new SelectListItems
            {
                Id = s.VatId,
                Name = s.Name
            });
            IEnumerable<SelectListItems> prodUnits = prodUnit.Where(c => c.IsActive == true).Select(s => new SelectListItems
            {
                Id = s.MunitId,
                Name = s.Name
            });
            Product pro = new Product
            {
                // vmProductType = data.ToList(),
                MeasurementUnits = prodUnits,
                ProductVattypes = prodVats
            };

            return View(pro);
        }
        [HttpPost]
        public async Task<IActionResult> Create(vmProduct product)
        {
            product.EfectiveFrom = DateTime.Now;
            product.CreatedBy = _session.UserId;
            product.CreatedTime=DateTime.Now;
            product.IsActive = true;
    
            try
            {
                
                _prodService.Insert(product);
                await UnitOfWork.SaveChangesAsync();
                if (product.UploadFile.Length > 0)
                {
                    var File = product.UploadFile;
                    var FileSaveFeedbackDto = await FileSaveAsync(File);
                    Content content = new Content();
                    content.Name = "Images";
                    content.ContentTypeId = 1;
                    content.TransId = product.ProductId;
                    content.Remark = "Test";
                    content.CreatedBy = _session.UserId;
                    content.CreatedTime=DateTime.Now;
                    content.Url = FileSaveFeedbackDto.FileUrl;
                    _contentService.Insert(content);
                    await UnitOfWork.SaveChangesAsync();
                }
                
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(ControllerStaticData.DISPLAY_INDEX, ControllerStaticData.LIST_PRODUCTS);
            }
            catch (Exception e)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return View(product);
            }
            
        }
    }
}