using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(ProductVattypeMetadata))]
    public partial class ProductVattype : URF.Core.EF.Trackable.Entity
    {
    }
    public class ProductVattypeMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Vat %")]
        [Required]
        public decimal DefaultVatPercent { get; set; }
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Display(Name = "Display Name")]
        [Required]
        public string DisplayName { get; set; }

        [Display(Name = "SD %")]
        public string SupplementaryDutyPercent { get; set; }

        [Display(Name = "Purchase Type")]
        public string PurchaseType { get; set; }

        [Display(Name = "Sales Type")]
        public string SalesType { get; set; }

        [Display(Name = "Transaction Type")]
        public string TransactionType { get; set; }

    }
}