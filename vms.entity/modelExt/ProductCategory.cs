using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(ProductCategoryMetadata))]
    public partial class ProductCategory : URF.Core.EF.Trackable.Entity
    {
    }
    public class ProductCategoryMetadata
    {

        [Display(Name = "Org.")]
        public int OrganizationId { get; set; }
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [Required]
        public string Name { get; set; }
    }
}

