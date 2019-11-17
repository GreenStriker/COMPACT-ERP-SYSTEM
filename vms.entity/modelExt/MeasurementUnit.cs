using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(MeasurementUnitMetadata))]
    public partial class MeasurementUnit : URF.Core.EF.Trackable.Entity
    {
    }
    public class MeasurementUnitMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        public string Name { get; set; }
    }
}