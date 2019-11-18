﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Payment
    {
        public Payment()
        {
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
        }

        public int PaymetId { get; set; }
        public int? PaymentMethodId { get; set; }
        public decimal? AmountPaid { get; set; }
        public string TransactionId { get; set; }
        public string Remark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Createdtime { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}