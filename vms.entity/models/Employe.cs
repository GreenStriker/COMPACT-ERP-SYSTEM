﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Employe
    {
        public Employe()
        {
            AdvancedSalaries = new HashSet<AdvancedSalary>();
            Expences = new HashSet<Expence>();
            Overtimes = new HashSet<Overtime>();
            Salaries = new HashSet<Salary>();
        }

        public int EmployeId { get; set; }
        public string Name { get; set; }
        public int? BranchId { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string Nid { get; set; }
        public string Mobile { get; set; }
        public string AlterMobile { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ICollection<AdvancedSalary> AdvancedSalaries { get; set; }
        public virtual ICollection<Expence> Expences { get; set; }
        public virtual ICollection<Overtime> Overtimes { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}