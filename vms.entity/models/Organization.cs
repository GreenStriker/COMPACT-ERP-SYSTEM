using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Organization
    {
        public Organization()
        {
            AuditLogs = new HashSet<AuditLog>();
            Customers = new HashSet<Customer>();
            DamageTypes = new HashSet<DamageType>();
            Damages = new HashSet<Damage>();
            DocumentTypes = new HashSet<DocumentType>();
            MushakGenerations = new HashSet<MushakGeneration>();
            PriceSetups = new HashSet<PriceSetup>();
            ProductCategories = new HashSet<ProductCategory>();
            ProductionReceives = new HashSet<ProductionReceive>();
            Productions = new HashSet<Production>();
            Products = new HashSet<Product>();
            Purchases = new HashSet<Purchase>();
            Roles = new HashSet<Role>();
            SaleOrganizations = new HashSet<Sale>();
            SaleOtherBranchOrganizations = new HashSet<Sale>();
            StockIns = new HashSet<StockIn>();
            SupplimentaryDuties = new HashSet<SupplimentaryDuty>();
            Users = new HashSet<User>();
            Vendors = new HashSet<Vendor>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public int? ParentOrganizationId { get; set; }
        public string Code { get; set; }
        public string VatregNo { get; set; }
        public string Bin { get; set; }
        public int FinancialActivityNatureId { get; set; }
        public int BusinessNatureId { get; set; }
        public bool IsDeductVatInSource { get; set; }
        public bool IsSellStandardVatProduct { get; set; }
        public string CertificateNo { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string VatResponsiblePersonName { get; set; }
        public string VatResponsiblePersonDesignation { get; set; }
        public string VatResponsiblePersonMobileNo { get; set; }
        public string VatResponsiblePersonEmailAddress { get; set; }
        public bool IsActive { get; set; }
        public int? EnlistedNo { get; set; }
        public int? PostalCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual BusinessNature BusinessNature { get; set; }
        public virtual FinancialActivityNature FinancialActivityNature { get; set; }
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DamageType> DamageTypes { get; set; }
        public virtual ICollection<Damage> Damages { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerations { get; set; }
        public virtual ICollection<PriceSetup> PriceSetups { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductionReceive> ProductionReceives { get; set; }
        public virtual ICollection<Production> Productions { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Sale> SaleOrganizations { get; set; }
        public virtual ICollection<Sale> SaleOtherBranchOrganizations { get; set; }
        public virtual ICollection<StockIn> StockIns { get; set; }
        public virtual ICollection<SupplimentaryDuty> SupplimentaryDuties { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}