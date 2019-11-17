using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class CreditNoteDetail
    {
        public int CreditNoteDetailId { get; set; }
        public int CreditNoteId { get; set; }
        public int SalesDetailId { get; set; }
        public decimal ReturnQuantity { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual CreditNote CreditNote { get; set; }
        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual SalesDetail SalesDetail { get; set; }
    }
}