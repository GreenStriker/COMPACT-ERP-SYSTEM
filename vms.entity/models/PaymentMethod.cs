using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Payments = new HashSet<Payment>();
        }

        public int PaymenttypeId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Remark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}