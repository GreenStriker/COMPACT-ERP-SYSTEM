using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Right
    {
        public Right()
        {
            RoleRights = new HashSet<RoleRight>();
        }

        public int RightId { get; set; }
        public string RightName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<RoleRight> RoleRights { get; set; }
    }
}