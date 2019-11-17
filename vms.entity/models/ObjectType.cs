using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class ObjectType
    {
        public ObjectType()
        {
            AuditLogs = new HashSet<AuditLog>();
        }

        public int ObjectTypeId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}