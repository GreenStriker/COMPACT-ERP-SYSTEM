using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public bool IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}