using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(ExportTypeMetadata))]
    public partial class ExportType : URF.Core.EF.Trackable.Entity
    {
    }
    public class ExportTypeMetadata
    {
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string ExportTypeName { get; set; }
    }
}