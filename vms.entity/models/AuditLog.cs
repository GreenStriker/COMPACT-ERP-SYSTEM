﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class AuditLog
    {
        public int AuditLogId { get; set; }
        public int ObjectTypeId { get; set; }
        public int? PrimaryKey { get; set; }
        public int AuditOperationId { get; set; }
        public int UserId { get; set; }
        public DateTime Datetime { get; set; }
        public string Descriptions { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? OrganizationId { get; set; }

        public virtual AuditOperation AuditOperation { get; set; }
        public virtual ObjectType ObjectType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }
}