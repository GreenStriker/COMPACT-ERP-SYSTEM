using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PurchaseType
    {
        public PurchaseType()
        {
            ProductVattypes = new HashSet<ProductVattype>();
            Purchases = new HashSet<Purchase>();
        }

        public int PurchaseTypeId { get; set; }
        public string Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<ProductVattype> ProductVattypes { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}