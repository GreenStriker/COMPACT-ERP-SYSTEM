using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class StockIn
    {
        public StockIn()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            Damages = new HashSet<Damage>();
        }

        public long StockInId { get; set; }
        public int OrganizationId { get; set; }
        public int ProductId { get; set; }
        public long? ProductionReceiveId { get; set; }
        public int? PurchaseDetailId { get; set; }
        public decimal? InitialQuantity { get; set; }
        public decimal InQuantity { get; set; }
        public decimal? InitUnitPriceWithoutVat { get; set; }
        public decimal? EndUnitPriceWithoutVat { get; set; }
        public int MeasurementUnitId { get; set; }
        public decimal SaleQuantity { get; set; }
        public decimal DamageQuantity { get; set; }
        public decimal UsedInProductionQuantity { get; set; }
        public decimal PurchaseReturnQty { get; set; }
        public decimal SalesReturnQty { get; set; }
        public decimal? CurrentStock { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductionReceive ProductionReceive { get; set; }
        public virtual PurchaseDetail PurchaseDetail { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<Damage> Damages { get; set; }
    }
}