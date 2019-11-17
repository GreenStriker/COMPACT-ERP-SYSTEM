using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class MeasurementUnit
    {
        public MeasurementUnit()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            CreditNoteDetails = new HashSet<CreditNoteDetail>();
            DebitNoteDetails = new HashSet<DebitNoteDetail>();
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
            PriceSetups = new HashSet<PriceSetup>();
            Products = new HashSet<Product>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
            StockIns = new HashSet<StockIn>();
        }

        public int MeasurementUnitId { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<CreditNoteDetail> CreditNoteDetails { get; set; }
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
        public virtual ICollection<PriceSetup> PriceSetups { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<StockIn> StockIns { get; set; }
    }
}