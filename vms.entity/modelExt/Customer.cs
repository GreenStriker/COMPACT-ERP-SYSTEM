using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(CustomerMetadata))]
    public partial class Customer : URF.Core.EF.Trackable.Entity
    {
    }
    public class CustomerMetadata
    {
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        [Display(Name = "Phone No.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Entered PhoneNo is not valid.")]
        public string PhoneNo { get; set; }
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

    }
}