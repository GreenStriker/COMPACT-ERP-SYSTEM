
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using vms.entity.viewModels;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(PurchasePaymentMetadata))]
    public partial class PurchasePayment : URF.Core.EF.Trackable.Entity
    {
     
    }
    public class PurchasePaymentMetadata
    {
        [Required]
        public decimal PaidAmount { get; set; }

    }

   
}
