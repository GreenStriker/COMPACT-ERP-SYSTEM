﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Purchase
    {
        public Purchase()
        {
            DebitNotes = new HashSet<DebitNote>();
            PurchaseContents = new HashSet<PurchaseContent>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            PurchasePayments = new HashSet<PurchasePayment>();
        }

        public int PurchaseId { get; set; }
        public string PurchaseInvoice { get; set; }
        public string VoucherNo { get; set; }
        public int? VendorId { get; set; }
        public int? BranchId { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? DiscountOnTotal { get; set; }
        public decimal? TotalDiscountOnIndividualProduct { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public DateTime? EfectiveFrom { get; set; }
        public DateTime? EfectiveTo { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<DebitNote> DebitNotes { get; set; }
        public virtual ICollection<PurchaseContent> PurchaseContents { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
    }
}