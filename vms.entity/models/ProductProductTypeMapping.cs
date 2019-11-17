using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductProductTypeMapping
    {
        public int ProductProductTypeMappingId { get; set; }
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}