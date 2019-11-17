using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class BusinessNature
    {
        public BusinessNature()
        {
            Organizations = new HashSet<Organization>();
        }

        public int BusinessNatureId { get; set; }
        public string Name { get; set; }
        public string NameInBangla { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}