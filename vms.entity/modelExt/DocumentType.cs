
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(DocumentTypeMetadata))]
    public partial class DocumentType : URF.Core.EF.Trackable.Entity
    {
    }
    public class DocumentTypeMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
    }
}