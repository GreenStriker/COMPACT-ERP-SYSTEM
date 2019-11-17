using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Sale
    {
        public Sale()
        {
            CreditNotes = new HashSet<CreditNote>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesPaymentReceives = new HashSet<SalesPaymentReceive>();
        }

        public int SalesId { get; set; }
        public string InvoiceNo { get; set; }
        public string VatChallanNo { get; set; }
        public int OrganizationId { get; set; }
        public int NoOfIteams { get; set; }
        public decimal TotalPriceWithoutVat { get; set; }
        public decimal DiscountOnTotalPrice { get; set; }
        public decimal TotalDiscountOnIndividualProduct { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotalSupplimentaryDuty { get; set; }
        public bool IsVatDeductedInSource { get; set; }
        public decimal? ReceivableAmount { get; set; }
        public decimal? PaymentReceiveAmount { get; set; }
        public decimal? PaymentDueAmount { get; set; }
        public int? CustomerId { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverContactNo { get; set; }
        public string ShippingAddress { get; set; }
        public int? ShippingCountryId { get; set; }
        public int SalesTypeId { get; set; }
        public int SalesDeliveryTypeId { get; set; }
        public string WorkOrderNo { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryMethodId { get; set; }
        public int? ExportTypeId { get; set; }
        public string LcNo { get; set; }
        public DateTime? LcDate { get; set; }
        public string BillOfEntry { get; set; }
        public DateTime? BillOfEntryDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string TermsOfLc { get; set; }
        public string CustomerPoNumber { get; set; }
        public bool IsComplete { get; set; }
        public bool IsTaxInvoicePrined { get; set; }
        public DateTime? TaxInvoicePrintedTime { get; set; }
        public int? MushakGenerationId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? OtherBranchOrganizationId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }
        public virtual ExportType ExportType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Organization OtherBranchOrganization { get; set; }
        public virtual SalesDeliveryType SalesDeliveryType { get; set; }
        public virtual SalesType SalesType { get; set; }
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesPaymentReceive> SalesPaymentReceives { get; set; }
    }
}