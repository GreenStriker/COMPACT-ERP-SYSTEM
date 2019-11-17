using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class AuditOperation
    {
        public AuditOperation()
        {
            AuditLogs = new HashSet<AuditLog>();
        }

        public int AuditOperationId { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}