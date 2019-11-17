using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            Products = new HashSet<Product>();
        }

        public int ProductGroupId { get; set; }
        public string Name { get; set; }
        public int? ParentGroupId { get; set; }
        public string Node { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}