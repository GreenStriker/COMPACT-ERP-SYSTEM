using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class SalesDetail
    {
        public SalesDetail()
        {
            CreditNoteDetails = new HashSet<CreditNoteDetail>();
        }

        public int SalesDetailId { get; set; }
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int ProductVattypeId { get; set; }
        public int StockInId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPerItem { get; set; }
        public decimal Vatpercent { get; set; }
        public decimal SupplementaryDutyPercent { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductVattype ProductVattype { get; set; }
        public virtual Sale Sales { get; set; }
        public virtual ICollection<CreditNoteDetail> CreditNoteDetails { get; set; }
    }
}