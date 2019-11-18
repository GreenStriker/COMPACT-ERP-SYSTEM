using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Product
    {
        public Product()
        {
            ProductPrices = new HashSet<ProductPrice>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int? VatId { get; set; }
        public string Code { get; set; }
        public DateTime? EfectiveFrom { get; set; }
        public DateTime? EfectiveTo { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Vat Vat { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}