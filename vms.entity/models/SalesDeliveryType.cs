using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class SalesDeliveryType
    {
        public SalesDeliveryType()
        {
            Sales = new HashSet<Sale>();
        }

        public int SalesDeliveryTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}