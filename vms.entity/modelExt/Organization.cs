using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(OrganizationMetadata))]
    public partial class Organization : URF.Core.EF.Trackable.Entity
    {
        [NotMapped]
        public List<KeyValuePair<int, string>> CountryIds { get; set; }
        [NotMapped]
        public int SelectedCountryId { get; set; }
        [NotMapped]
        public List<KeyValuePair<int, string>> CityIds { get; set; }
        [NotMapped]
        public int SelectedCityId { get; set; }
        [NotMapped]
        public string UserName { get; set; }
        [NotMapped]
        public string Mobile { get; set; }
        [NotMapped]
        public string EmailAddress { get; set; }
        [NotMapped]
        public string VatPersonName { get; set; }
        [NotMapped]
        public string VatPersonDesignation { get; set; }
        
    }
    public class OrganizationMetadata
    {
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Code cannot be longer than 50 characters.")]        
        public string Code { get; set; }

        [StringLength(50, ErrorMessage = "VatRegNo cannot be longer than 50 characters.")]       
        [Display(Name = "Vat Reg. No.")]
        public string VatregNo { get; set; }
        
        [Display(Name = "Certificate")]       
        public string CertificateNo { get; set; }

        [Display(Name = "Enlisted No.")]        
        public int? EnlistedNo { get; set; }
        
        [Display(Name = "Postal Code")]
        public int? PostalCode { get; set; }

        //[RegularExpression("^[0-9]*$", ErrorMessage = "Entered Mobile is not valid.")]
        //[StringLength(11, ErrorMessage = "Mobile cannot be longer than 11 characters.")]
        //[Required]
        //[Display(Name = "Mobile")]
        //public string Mobile { get; set; }

        [RegularExpression("^[A-Z0-9a-z._%+-]+@[a-zA-Z_]+?.[a-zA-Z]{2,3}$", ErrorMessage = "Entered Email Address is not valid.")]
        [StringLength(50, ErrorMessage = "Email Address cannot be longer than 50 characters.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [StringLength(100, ErrorMessage = "VatResponsiblePersonName cannot be longer than 100 characters.")]
        [Required]
        [Display(Name = "Vat Person Name")]
        public string VatResponsiblePersonName { get; set; }
      

        //[StringLength(50, ErrorMessage = "UserName cannot be longer than 50 characters.")]
        //[Required]
        //public string UserName { get; set; }
         

        [StringLength(50, ErrorMessage = "VatResponsiblePersonDesignation cannot be longer than 50 characters.")]
        [Required]
        public string VatResponsiblePersonDesignation { get; set; }

        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters.")]
         public string Address { get; set; }
    }

}