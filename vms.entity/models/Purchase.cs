using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Purchase
    {
        public Purchase()
        {
            DebitNotes = new HashSet<DebitNote>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            PurchasePayments = new HashSet<PurchasePayment>();
        }

        public int PurchaseId { get; set; }
        public int OrganizationId { get; set; }
        public int VendorId { get; set; }
        public string VatChallanNo { get; set; }
        public DateTime? VatChallanIssueDate { get; set; }
        public string VendorInvoiceNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurchaseTypeId { get; set; }
        public int PurchaseReasonId { get; set; }
        public int NoOfIteams { get; set; }
        public decimal TotalPriceWithoutVat { get; set; }
        public decimal DiscountOnTotalPrice { get; set; }
        public decimal TotalDiscountOnIndividualProduct { get; set; }
        public decimal TotalImportDuty { get; set; }
        public decimal TotalRegulatoryDuty { get; set; }
        public decimal TotalSupplementaryDuty { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotalAdvanceTax { get; set; }
        public decimal TotalAdvanceIncomeTax { get; set; }
        public bool IsVatDeductedInSource { get; set; }
        public string VdscertificateNo { get; set; }
        public DateTime? VdscertificateDate { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string LcNo { get; set; }
        public DateTime? LcDate { get; set; }
        public string BillOfEntry { get; set; }
        public DateTime? BillOfEntryDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string TermsOfLc { get; set; }
        public string PoNumber { get; set; }
        public int? MushakGenerationId { get; set; }
        public bool IsComplete { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual PurchaseReason PurchaseReason { get; set; }
        public virtual PurchaseType PurchaseType { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<DebitNote> DebitNotes { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
    }
}