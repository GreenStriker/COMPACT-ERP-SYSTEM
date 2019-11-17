using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class DamageType
    {
        public DamageType()
        {
            Damages = new HashSet<Damage>();
        }

        public int DamageTypeId { get; set; }
        public int? OrganizationId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Damage> Damages { get; set; }
    }
}