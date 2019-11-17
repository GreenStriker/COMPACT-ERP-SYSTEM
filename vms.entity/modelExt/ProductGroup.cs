using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(ProductGroupMetadata))]
    public partial class ProductGroup : URF.Core.EF.Trackable.Entity
    {
    }
    public class ProductGroupMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
    }
}