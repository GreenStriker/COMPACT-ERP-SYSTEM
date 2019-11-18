﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Sale
    {
        public Sale()
        {
            SalesDetails = new HashSet<SalesDetail>();
        }

        public int SalesId { get; set; }
        public string CusMobile { get; set; }
        public int? PaymentId { get; set; }
        public decimal? Vat { get; set; }
        public int? BranchId { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Discount { get; set; }
        public int? SoldBy { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}