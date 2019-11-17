using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Product
    {
        public Product()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            Damages = new HashSet<Damage>();
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
            PriceSetups = new HashSet<PriceSetup>();
            ProductProductTypeMappings = new HashSet<ProductProductTypeMapping>();
            ProductVats = new HashSet<ProductVat>();
            ProductionDetails = new HashSet<ProductionDetail>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
            StockIns = new HashSet<StockIn>();
            SupplimentaryDuties = new HashSet<SupplimentaryDuty>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ModelNo { get; set; }
        public string Code { get; set; }
        public string Hscode { get; set; }
        public int? ProductCategoryId { get; set; }
        public int ProductGroupId { get; set; }
        public int OrganizationId { get; set; }
        public decimal TotalQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool IsSellable { get; set; }
        public bool IsRawMaterial { get; set; }
        public bool? IsNonRebateable { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<Damage> Damages { get; set; }
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
        public virtual ICollection<PriceSetup> PriceSetups { get; set; }
        public virtual ICollection<ProductProductTypeMapping> ProductProductTypeMappings { get; set; }
        public virtual ICollection<ProductVat> ProductVats { get; set; }
        public virtual ICollection<ProductionDetail> ProductionDetails { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<StockIn> StockIns { get; set; }
        public virtual ICollection<SupplimentaryDuty> SupplimentaryDuties { get; set; }
    }
}