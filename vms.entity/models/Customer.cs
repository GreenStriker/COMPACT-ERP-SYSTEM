using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Customer
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public int CustomerId { get; set; }
        public int? OrganizationId { get; set; }
        public int? CustomerOrganizationId { get; set; }
        public string Name { get; set; }
        public string Bin { get; set; }
        public string Nidno { get; set; }
        public int? CountryId { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}