using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Damage
    {
        public int DamageId { get; set; }
        public int? OrganizationId { get; set; }
        public int ProductId { get; set; }
        public long StockInId { get; set; }
        public decimal DamageQty { get; set; }
        public int DamageTypeId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual DamageType DamageType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Product Product { get; set; }
        public virtual StockIn StockIn { get; set; }
    }
}