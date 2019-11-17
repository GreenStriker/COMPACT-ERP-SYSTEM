using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Production
    {
        public Production()
        {
            ProductionDetails = new HashSet<ProductionDetail>();
        }

        public int ProductionId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? OrganizationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ExpectedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<ProductionDetail> ProductionDetails { get; set; }
    }
}