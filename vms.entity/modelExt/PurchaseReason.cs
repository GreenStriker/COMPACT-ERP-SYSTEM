using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(PurchaseReasonMetadata))]
    public partial class PurchaseReason : URF.Core.EF.Trackable.Entity
    {
    }
    public class PurchaseReasonMetadata
    {

        [StringLength(50, ErrorMessage = "Reason cannot be longer than 50 characters.")]
        [Required]
        public string Reason { get; set; }
    }
}
