using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PriceSetup
    {
        public PriceSetup()
        {
            PriceSetupProductCosts = new HashSet<PriceSetupProductCost>();
        }

        public int PriceSetupId { get; set; }
        public int OrganizationId { get; set; }
        public int ProductId { get; set; }
        public int MeasurementUnitId { get; set; }
        public decimal? BaseTp { get; set; }
        public decimal? Mrp { get; set; }
        public decimal PurchaseUnitPrice { get; set; }
        public decimal SalesUnitPrice { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<PriceSetupProductCost> PriceSetupProductCosts { get; set; }
    }
}