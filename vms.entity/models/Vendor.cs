using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int VendorId { get; set; }
        public int? OrganizationId { get; set; }
        public int? VendorOrganizationId { get; set; }
        public string Name { get; set; }
        public string BinNo { get; set; }
        public string NationalIdNo { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool IsRegisteredAsTurnOverOrg { get; set; }
        public bool IsRegistered { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}