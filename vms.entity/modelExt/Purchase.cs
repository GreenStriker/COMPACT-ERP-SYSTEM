
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(PurchaseMetadata))]
    public partial class Purchase : URF.Core.EF.Trackable.Entity
    {
    }
    public class PurchaseMetadata
    {
        [Display(Name = "Expt. Del. Date")]
        public string ExpectedDeliveryDate { get; set; }
    }
}
