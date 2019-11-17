using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int ProductCategoryId { get; set; }
        public int? OrganizationId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}