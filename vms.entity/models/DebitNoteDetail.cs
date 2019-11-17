using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class DebitNoteDetail
    {
        public int DebitNoteDetailId { get; set; }
        public int DebitNoteId { get; set; }
        public int PurchaseDetailId { get; set; }
        public decimal ReturnQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual DebitNote DebitNote { get; set; }
        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual PurchaseDetail PurchaseDetail { get; set; }
    }
}