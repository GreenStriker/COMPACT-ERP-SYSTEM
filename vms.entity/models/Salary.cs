using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public decimal? SalaryAmount { get; set; }
        public int? EmployeId { get; set; }
        public DateTime? JoingDate { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Employe Employe { get; set; }
    }
}