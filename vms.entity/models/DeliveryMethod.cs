using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class DeliveryMethod
    {
        public DeliveryMethod()
        {
            Sales = new HashSet<Sale>();
        }

        public int DeliveryMethodId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}