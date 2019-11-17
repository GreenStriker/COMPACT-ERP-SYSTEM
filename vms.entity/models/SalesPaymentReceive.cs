using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class SalesPaymentReceive
    {
        public int SalesPaymentReceiveId { get; set; }
        public int SalesId { get; set; }
        public int ReceivedPaymentMethodId { get; set; }
        public decimal ReceiveAmount { get; set; }
        public DateTime ReceiveDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual PaymentMethod ReceivedPaymentMethod { get; set; }
        public virtual Sale Sales { get; set; }
    }
}