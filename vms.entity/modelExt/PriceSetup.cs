
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using vms.entity.viewModels;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(PriceSetupMetadata))]
    public partial class PriceSetup : URF.Core.EF.Trackable.Entity
    {
        public IEnumerable<SelectListItems> MeasurementUnits;
        public IEnumerable<SelectListItems> OverHeadCost;
        public string ProductName;
        public string MeasurementUnitName;
        public string ProductGroupName;
        public string ProductCategoryName;
        public string HSCode;
        //public int OverHeadCostId { get; set; }
    }
    public class PriceSetupMetadata
    {

        [Required]
        [Display(Name = "Purchase Unit Price")]
        public decimal PurchaseUnitPrice { get; set; }
        [Required]
        [Display(Name = "Sales Unit Price")]
        public decimal SalesUnitPrice { get; set; }
        [Display(Name = "Base Tp")]
        public decimal? BaseTp { get; set; }
    }
}
