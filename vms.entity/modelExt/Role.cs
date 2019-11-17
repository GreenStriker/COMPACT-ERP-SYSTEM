using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using vms.entity.viewModels;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(RoleMetadata))]
    public partial class Role : URF.Core.EF.Trackable.Entity
    {
        [NotMapped]
        public string EncryptedId { get; set; }
        public IEnumerable<SelectListItems> Roles;
        public IEnumerable<SelectListItems> UserTypes;
    }
    public class RoleMetadata
    {
       
        [Display(Name = "Role")]
        [Required]
        [StringLength(64, ErrorMessage = "RoleName cannot be longer than 64 characters.")]
        public string RoleName { get; set; }
    }
}