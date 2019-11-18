using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class SalesDetail
    {
        public int SalesDetailId { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}