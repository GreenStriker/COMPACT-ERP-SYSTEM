﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Salary
    {
        public Salary()
        {
            PayrollDetails = new HashSet<PayrollDetail>();
        }

        public int SalaryId { get; set; }
        public decimal BaseSalary { get; set; }
        public int? EmployeId { get; set; }
        public DateTime? JoingDate { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Employe Employe { get; set; }
        public virtual ICollection<PayrollDetail> PayrollDetails { get; set; }
    }
}