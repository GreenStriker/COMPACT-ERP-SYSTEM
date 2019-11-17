using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class District
    {
        public District()
        {
            BankBranches = new HashSet<BankBranch>();
        }

        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string NameInBangla { get; set; }

        public virtual ICollection<BankBranch> BankBranches { get; set; }
    }
}