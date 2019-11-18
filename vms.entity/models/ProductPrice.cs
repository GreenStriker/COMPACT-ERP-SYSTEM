﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductPrice
    {
        public int PriceId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? EfectiveFrom { get; set; }
        public DateTime? EfectiveTo { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Product Product { get; set; }
    }
}