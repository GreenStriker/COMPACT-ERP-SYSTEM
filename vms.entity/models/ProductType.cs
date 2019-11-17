using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductType
    {
        public ProductType()
        {
            ProductProductTypeMappings = new HashSet<ProductProductTypeMapping>();
        }

        public int ProductTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductProductTypeMapping> ProductProductTypeMappings { get; set; }
    }
}