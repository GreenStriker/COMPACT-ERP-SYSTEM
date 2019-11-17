using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class SalesType
    {
        public SalesType()
        {
            ProductVattypes = new HashSet<ProductVattype>();
            Sales = new HashSet<Sale>();
        }

        public int SalesTypeId { get; set; }
        public string SalesTypeName { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<ProductVattype> ProductVattypes { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}