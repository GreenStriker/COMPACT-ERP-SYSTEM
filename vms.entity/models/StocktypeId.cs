using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class StocktypeId
    {
        public StocktypeId()
        {
            Stocks = new HashSet<Stock>();
        }

        public int StocktypeId1 { get; set; }
        public string Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}