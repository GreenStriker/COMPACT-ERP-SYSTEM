using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using vms.entity.attr;
using vms.entity.viewModels;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product : URF.Core.EF.Trackable.Entity
    {
        //public int ProductVattypeId { get; set; }
        //public IEnumerable<SelectListItems> ProductVattype;
        public IEnumerable<SelectListItems> MeasurementUnits;
        public IEnumerable<SelectListItems> ProductGroups;
        public IEnumerable<SelectListItems> ProductVattypes;
        public IEnumerable<SelectListItems> ProductCategories;
    }
    public class ProductMetadata
    {
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }

        //[Display(Name = "Model No")]
        //[StringLength(50, ErrorMessage = "ModelNo cannot be longer than 50 characters.")]
        //[Required]
        //public string ModelNo { get; set; }

        [Display(Name = "Code")]
        [StringLength(50, ErrorMessage = "Code cannot be longer than 50 characters.")]
        [Required]
        public string Code { get; set; }

        [Display(Name = "Category")]
       
        public int ProductCategoryId { get; set; }

        [Display(Name = "Group")]
     
        public int ProductGroupId { get; set; }

        [DisplayName("Org.")]
        [Required]
        public int OrganizationId { get; set; }

        [DisplayName("Unit")]
      
        public int MeasurementUnitId { get; set; }
        [DisplayName("Status")]
       
        public bool IsActive { get; set; }
        [DisplayName("Saleable")]
       
        public bool IsSellable { get; set; }
        [DisplayName("Raw.Material")]
       
        public bool IsRawMaterial { get; set; }


    }
}