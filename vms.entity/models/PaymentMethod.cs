using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            PurchasePayments = new HashSet<PurchasePayment>();
            SalesPaymentReceives = new HashSet<SalesPaymentReceive>();
        }

        public int PaymentMethodId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
        public virtual ICollection<SalesPaymentReceive> SalesPaymentReceives { get; set; }
    }
}