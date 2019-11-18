using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public int PurchaseId { get; set; }
        public byte[] VendorMobile { get; set; }
        public int? BranchId { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? EfectiveFrom { get; set; }
        public DateTime? EfectiveTo { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}