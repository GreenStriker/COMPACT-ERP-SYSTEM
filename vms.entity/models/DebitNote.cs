﻿using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class DebitNote
    {
        public DebitNote()
        {
            DebitNoteDetails = new HashSet<DebitNoteDetail>();
        }

        public int DebitNoteId { get; set; }
        public int PurchaseId { get; set; }
        public string ReasonOfReturn { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Purchase Purchase { get; set; }
        public virtual ICollection<DebitNoteDetail> DebitNoteDetails { get; set; }
    }
}