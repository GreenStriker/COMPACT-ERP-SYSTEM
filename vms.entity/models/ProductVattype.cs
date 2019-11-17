using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductVattype
    {
        public ProductVattype()
        {
            ProductVats = new HashSet<ProductVat>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public int ProductVattypeId { get; set; }
        public string Name { get; set; }
        public decimal DefaultVatPercent { get; set; }
        public decimal? SupplementaryDutyPercent { get; set; }
        public string DisplayName { get; set; }
        public string EffectiveFrom { get; set; }
        public string EffectiveTo { get; set; }
        public int? TransactionTypeId { get; set; }
        public int? PurchaseTypeId { get; set; }
        public int? SalesTypeId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual PurchaseType PurchaseType { get; set; }
        public virtual SalesType SalesType { get; set; }
        public virtual TransectionType TransactionType { get; set; }
        public virtual ICollection<ProductVat> ProductVats { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}