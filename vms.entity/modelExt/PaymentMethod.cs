
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(PaymentMethodMetadata))]
    public partial class PaymentMethod : URF.Core.EF.Trackable.Entity
    {
    }
    public class PaymentMethodMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
       
    }
}
