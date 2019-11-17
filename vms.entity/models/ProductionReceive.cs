using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ProductionReceive
    {
        public ProductionReceive()
        {
            BillOfMaterials = new HashSet<BillOfMaterial>();
            StockIns = new HashSet<StockIn>();
        }

        public long ProductionReceiveId { get; set; }
        public string BatchNo { get; set; }
        public int OrganizationId { get; set; }
        public int? ProductionId { get; set; }
        public int ProductId { get; set; }
        public decimal ReceiveQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public DateTime ReceiveTime { get; set; }
        public decimal MaterialCost { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<StockIn> StockIns { get; set; }
    }
}