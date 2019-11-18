using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Stock
    {
        public int StockId { get; set; }
        public int? StoicktypeId { get; set; }
        public int? TranId { get; set; }
        public bool? IsReturn { get; set; }
        public decimal? Qty { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsActive { get; set; }

        public virtual StocktypeId Stoicktype { get; set; }
    }
}