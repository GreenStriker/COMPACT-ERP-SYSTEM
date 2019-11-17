using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class OverHeadCost
    {
        public OverHeadCost()
        {
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
        }

        public int OverHeadCostId { get; set; }
        public int? OrganizationId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
    }
}