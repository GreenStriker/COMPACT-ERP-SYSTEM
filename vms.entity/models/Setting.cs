﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Setting
    {
        public Setting()
        {
            Payrolls = new HashSet<Payroll>();
        }

        public int SettingsId { get; set; }
        public bool? IsattendenceCount { get; set; }
        public bool? IsProductDiscount { get; set; }
        public bool? IsIncentiveCount { get; set; }
        public decimal? IncentiveRetion { get; set; }
        public bool? IsrewardPoitCount { get; set; }
        public decimal? RewardPointRethio { get; set; }
        public DateTime? EfectiveFrom { get; set; }
        public DateTime? EfectiveTo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}