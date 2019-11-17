﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PurchasePayment
    {
        public int PurchasePaymentId { get; set; }
        public int PurchaseId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}