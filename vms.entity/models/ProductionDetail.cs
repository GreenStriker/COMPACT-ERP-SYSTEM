using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductionDetail
    {
        public int ProductionDetailsId { get; set; }
        public int ProductionId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Production Production { get; set; }
    }
}