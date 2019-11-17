using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ExportType
    {
        public ExportType()
        {
            Sales = new HashSet<Sale>();
        }

        public int ExportTypeId { get; set; }
        public string ExportTypeName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}