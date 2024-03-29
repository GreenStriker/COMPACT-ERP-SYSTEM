﻿using System;
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
using vms.entity.StoredProcedureModel;
using vms.entity.viewModels;
using vms.Models;
using vms.service.dbo;
using vms.service.dbo.StoredProdecure;
using vms.utility.StaticData;
using X.PagedList;

namespace Inventory.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IVatService _vatService;
        private readonly IProductPriceService _PriceService;
        private readonly IProductService _prodService;
        private readonly IProductLogService _logService;
        private readonly IMesureUnitService _unitService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IContentService _contentService;
        private  IAutocompleteService _autocompleteService;
        public ProductsController(
            IAutocompleteService autocompleteService,
            IContentService contentService,
            IProductPriceService PriceService,
            ControllerBaseParamModel controllerBaseParamModel,
            IHostingEnvironment hostingEnvironment,
            IVatService vatService,
            IProductService prodService,
            IProductLogService logService,
            IMesureUnitService unitService
        ) : base(controllerBaseParamModel)
        {
            _autocompleteService = autocompleteService;
            _contentService = contentService;
            _hostingEnvironment = hostingEnvironment;
            _vatService = vatService;
            _prodService = prodService;
            _logService = logService;
            _unitService = unitService;
            _PriceService = PriceService;
        }
        public async Task<IActionResult> Index(int? page, string search = null)
        {

            var data =await _prodService.Query().Include(c => c.Munit).Include(c => c.Vat).Include(c => c.Contents)
                .Where(c => c.IsActive == true).SelectAsync(CancellationToken.None);
            
            string txt = search;

            if (search != null)
            {
                search = search.ToLower().Trim();
                data = data.Where(c => c.Name.ToLower().Contains(search)
                                       || (c.Code != null && c.Code.ToLower().Contains(search))
                                        || (c.ModelNo != null && (c.ModelNo.ToString().Contains(search))));
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
                if (product.UploadFile != null && product.UploadFile.Length > 0)
                {
                    var File = product.UploadFile;
                    var FileSaveFeedbackDto = await FileSaveAsync(File);
                    Content content = new Content();
                    content.IsActive = true;
                    content.Name = "Images";
                   // content.ContentTypeId = 1;
                    content.ProductId = product.ProductId;
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



        public async Task<IActionResult> PriceSetup(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price =await _PriceService.Query().Include(c=>c.Product).SingleOrDefaultAsync(w => w.ProductId == id && w.IsActive == true, CancellationToken.None);


            if(price==null)
            {

                price = new ProductPrice();
                price.ProductId = id;
            }

            

            return View(price);
        }

        [HttpPost]


        public async Task<IActionResult> PriceSetup(ProductPrice price)
        {
            if (price.ProductId!= null)
            {
                
               
                var previous = await _PriceService.Query().SingleOrDefaultAsync(p => p.ProductId == price.ProductId && p.IsActive == true, CancellationToken.None);

                if (previous!= null)
                {
                    previous.IsActive = false;
                    previous.EfectiveTo = DateTime.Now;

                    _PriceService.Update(previous);

                    await UnitOfWork.SaveChangesAsync();
                }


                price.PriceId = 0;

                price.CreatedBy = _session.UserId;
                price.CreatedTime = DateTime.Now;
                price.EfectiveFrom = DateTime.Now;

                price.IsActive = true;
                

                _PriceService.Insert(price);
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
            return View(price);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var prodVat = await _vatService.GetAll();
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

            var data =await _prodService.GetById(id);
            data.MeasurementUnits = prodUnits;
            data.ProductVattypes = prodVats;
            //Product pro = new Product
            //{
            //    // vmProductType = data.ToList(),
            //    MeasurementUnits = prodUnits,
            //    ProductVattypes = prodVats,
            //    ProductId = id,
            //    ModelNo = data.ModelNo,
            //    Code = data.Code,
            //    MunitId = data.MunitId,
            //    VatId = data.VatId,
            //    Name = data.Name
            //};
            return View(data);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(vmProduct product)
        {
            var editData =await _prodService.GetById(product.ProductId);
            editData.ModelNo = product.ModelNo;
            editData.Code = product.Code;
            editData.MunitId = product.MunitId;
            editData.VatId = product.VatId;
            editData.Name = product.Name;
           // product.EfectiveFrom = DateTime.Now;
            product.CreatedBy = _session.UserId;
            product.CreatedTime = DateTime.Now;
           // product.IsActive = true;

            try
            {

                _prodService.Update(editData);
                await UnitOfWork.SaveChangesAsync();
                if (product.UploadFile!=null && product.UploadFile.Length > 0)
                {
                    var contentData =await _contentService.GetById(product.ProductId);
                    if (contentData!=null)
                    {
                        contentData.IsActive = false;
                        _contentService.Update(contentData);
                        await UnitOfWork.SaveChangesAsync();
                    }
                    
                    var File = product.UploadFile;
                    var FileSaveFeedbackDto = await FileSaveAsync(File);
                    Content content = new Content();
                    content.Name = "Images";
                    //content.ContentTypeId = 1;
                    content.ProductId = product.ProductId;
                    content.Remark = "Test";
                    content.CreatedBy = _session.UserId;
                    content.CreatedTime = DateTime.Now;
                    content.Url = FileSaveFeedbackDto.FileUrl;
                    content.IsActive = true;
                    _contentService.Insert(content);
                    await UnitOfWork.SaveChangesAsync();
                }

                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(ControllerStaticData.DISPLAY_INDEX, ControllerStaticData.LIST_PRODUCTS);
            }
            catch (Exception e)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                var prodVat = await _vatService.GetAll();
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

                var data = await _prodService.GetById(product.ProductId);
                data.MeasurementUnits = prodUnits;
                data.ProductVattypes = prodVats;
                return View(data);
            }

        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            try
            {
                var data = await _prodService.GetById(id);
                data.IsActive = false;
                data.EfectiveTo=DateTime.Now;
                _prodService.Update(data);
                await UnitOfWork.SaveChangesAsync();
                var priceData = await _PriceService.Query().Where(c => c.IsActive == true)
                    .FirstOrDefaultAsync(c => c.ProductId == id, CancellationToken.None);
                if (priceData!=null)
                {
                    priceData.IsActive = false;
                    priceData.EfectiveTo = DateTime.Now;
                    _PriceService.Update(priceData);
                    await UnitOfWork.SaveChangesAsync();

                }

                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(ControllerStaticData.DISPLAY_INDEX, ControllerStaticData.LIST_PRODUCTS);
            }
            catch (Exception e)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return RedirectToAction(ControllerStaticData.DISPLAY_INDEX, ControllerStaticData.LIST_PRODUCTS);
            }
            
           
        }
        public  IActionResult ProductBarCode(int id)
        {
            BarCode code=new BarCode();
            code.ProductId = id;
            return View(code);
        }
        [HttpPost]
        public async Task<IActionResult> ProductBarCode(BarCode barCode)
        {
           // ViewData["ProductId"] = new SelectList(await _prodService.Query().Where(c => c.IsActive == true).SelectAsync(), "ProductId", "Code");

            var salesPRice = await _PriceService.Query().Include(c => c.Product).SingleOrDefaultAsync(c => c.ProductId == barCode.ProductId && c.IsActive == true, CancellationToken.None);

            if (barCode.ProductId == 0 || salesPRice == null)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return View(barCode);
            }
            ViewBag.Price = salesPRice.SaleAmount;
            ViewBag.SaleCode = salesPRice.Product.Code;
            ViewBag.NumberOfBarCode = barCode.Value;
            ViewBag.Flag = true;
            var barcodeValue = salesPRice.Product.Code;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var image = barcode.Draw(barcodeValue, 25, 1);
            // ViewBag.Image = image;
            var imgName = "sabbir";
            var FileExtenstion = Path.GetExtension(imgName);

            string FileName = Guid.NewGuid().ToString();

            FileName += FileExtenstion;
            var FolderName = ControllerStaticData.APPLICATION_DOCUMENT + "BarCode";
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, FolderName);
            // string ImageFolder = Server.MapPath("~/img");
            //image.Save(ImageFolder + "/" + imgName.Trim() + ".bmp");


            bool exists = Directory.Exists(uploads);
            if (!exists)
            {
                Directory.CreateDirectory(uploads);
            }

            var filePath = Path.Combine(uploads, imgName);

            image.Save(uploads + "/" + imgName.Trim() + ".bmp");

            //image to displa in view  
            var virtualPath = string.Format("~/Images/{0}.bmp", imgName.Trim());
            //ViewBag.Image = virtualPath;
           
            return View(barCode);

        }
        public async Task<JsonResult> PurchaseProductAutoComplete(string filterText)
        {
            //var organizationId = _session.OrganizationId;
            var productList = await _PriceService.Query().Include(c=>c.Product.Vat).Where(c=>c.IsActive==true && c.Product.IsActive==true && c.Product.Name.Contains(filterText)).SelectAsync(CancellationToken.None);
            // var product = await _productVatService.Query().Include(c => c.Product).Include(c => c.Product.PriceSetups).Include(c => c.ProductVattype).Where(c => c.Product.Name.Contains(filterText) && c.Product.OrganizationId == organizationId).SelectAsync(CancellationToken.None);
            return new JsonResult(productList.Select(x => new
            {
                Id = x.ProductId,
                Name = x.Product.Name,
                UnitPrice = x.PurchaseAmount,
                Vat = x.Product.Vat.Percentage
            }).ToList());
        }
        public async Task<JsonResult> SaleProductAutoComplete(string filterText)
        {
            var branchId = _session.BranchId;
            List<SpGetProductAutocompleteForSale> productList;
            try
            {
                 productList = await _autocompleteService.GetProductAutocompleteForSales(_session.BranchId, filterText);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return new JsonResult(productList.Select(x => new
            {
                Id = x.ProductId,
                Name = x.ProductName,
                UnitPrice = x.SaleAmount,
                Unit = x.MUnitId,
                Vat = x.VatPercent,
                MaxSaleQty = x.MaxSaleQty
            }).ToList());
        }
    }
}