using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PurchaseDetail
    {
        public int PurchaseDetailId { get; set; }
        public int? PurchaseId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}