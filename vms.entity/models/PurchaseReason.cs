using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PurchaseReason
    {
        public PurchaseReason()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int PurchaseReasonId { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}