﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class CreditNote
    {
        public CreditNote()
        {
            CreditNoteDetails = new HashSet<CreditNoteDetail>();
        }

        public int CreditNoteId { get; set; }
        public int SalesId { get; set; }
        public string ReasonOfReturn { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Sale Sales { get; set; }
        public virtual ICollection<CreditNoteDetail> CreditNoteDetails { get; set; }
    }
}