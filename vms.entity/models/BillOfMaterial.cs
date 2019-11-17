using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class BillOfMaterial
    {
        public long BillOfMaterialId { get; set; }
        public long ProductionReceiveId { get; set; }
        public int RawMaterialId { get; set; }
        public decimal UsedQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public long StockInId { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual ProductionReceive ProductionReceive { get; set; }
        public virtual Product RawMaterial { get; set; }
        public virtual StockIn StockIn { get; set; }
    }
}