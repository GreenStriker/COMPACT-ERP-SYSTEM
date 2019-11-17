using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Role
    {
        public Role()
        {
            RoleRights = new HashSet<RoleRight>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int? OrganizationId { get; set; }
        public int? RoleDefaultPageId { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<RoleRight> RoleRights { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}