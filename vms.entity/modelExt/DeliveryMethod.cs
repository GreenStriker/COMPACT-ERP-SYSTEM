
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(DeliveryMethodMetadata))]
    public partial class DeliveryMethod : URF.Core.EF.Trackable.Entity
    {
    }
    public class DeliveryMethodMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
    }
}
