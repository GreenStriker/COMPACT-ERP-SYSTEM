
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(VendorMetadata))]
    public partial class Vendor : URF.Core.EF.Trackable.Entity
    {
    }
    public class VendorMetadata
    {
        [StringLength(200, ErrorMessage = "Name cannot be longer than 200 characters.")]
        [Required]
        public string Name { get; set; }
       
        
        public int OrganizationId { get; set; }
        
       
        
        public string BinNo { get; set; }
       
        public string ContactNo { get; set; }
        [Display(Name = "Address")]
        [Required]
        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters.")]
        public string Address { get; set; }
    }
}


