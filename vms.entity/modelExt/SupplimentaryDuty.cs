
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(SupplimentaryDutyMetadata))]
    public partial class SupplimentaryDuty : URF.Core.EF.Trackable.Entity
    {
      
    }
    public class SupplimentaryDutyMetadata
    {
        [Required]
        public decimal SdPercent { get; set; }
    }
}