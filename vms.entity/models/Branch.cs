﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Branch
    {
        public Branch()
        {
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            Users = new HashSet<User>();
        }

        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int? BranchHeadId { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual User BranchNavigation { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}