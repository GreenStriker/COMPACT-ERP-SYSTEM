using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class TransectionType
    {
        public TransectionType()
        {
            ProductVattypes = new HashSet<ProductVattype>();
        }

        public int TransectionTypeId { get; set; }
        public string Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<ProductVattype> ProductVattypes { get; set; }
    }
}