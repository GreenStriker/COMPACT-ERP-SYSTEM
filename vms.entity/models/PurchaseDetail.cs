using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class PurchaseDetail
    {
        public PurchaseDetail()
        {
            DebitNoteDetails = new HashSet<DebitNoteDetail>();
            StockIns = new HashSet<StockIn>();
        }

        public int PurchaseDetailId { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int ProductVattypeId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPerItem { get; set; }
        public decimal ImportDutyPercent { get; set; }
        public decimal RegulatoryDutyPercent { get; set; }
        public decimal SupplementaryDutyPercent { get; set; }
        public decimal Vatpercent { get; set; }
        public decimal AdvanceTaxPercent { get; set; }
        public decimal AdvanceIncomeTaxPercent { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductVattype ProductVattype { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
        public virtual ICollection<StockIn> StockIns { get; set; }
    }
}