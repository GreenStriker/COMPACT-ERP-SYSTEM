
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(SalesDeliveryTypeMetadata))]
    public partial class SalesDeliveryType : URF.Core.EF.Trackable.Entity
    {
    }
    public class SalesDeliveryTypeMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
    }
}
