
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using vms.entity.viewModels;

namespace vms.entity.models
{
    [ModelMetadataType(typeof(SalesPaymentReceiveMetadata))]
    public partial class SalesPaymentReceive : URF.Core.EF.Trackable.Entity
    {
       
    }
    public class SalesPaymentReceiveMetadata
    {
        [Required]
        public decimal ReceiveAmount { get; set; }

    }
}