﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductVat
    {
        public int ProductVatid { get; set; }
        public int ProductId { get; set; }
        public int ProductVattypeId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductVattype ProductVattype { get; set; }
    }
}