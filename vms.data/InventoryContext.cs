﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace vms.entity.models
{
    public partial class InventoryContext : DbContext
    {
        public InventoryContext()
        {
        }

        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Contenttype> Contenttypes { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesDetail> SalesDetails { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StocktypeId> StocktypeIds { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vat> Vats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.BranchId).ValueGeneratedOnAdd();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.DeactiveDate)
                    .HasColumnName("Deactive_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.OpeningDate).HasColumnType("date");

                entity.HasOne(d => d.BranchNavigation)
                    .WithOne(p => p.Branch)
                    .HasForeignKey<Branch>(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branch_User");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("FK_Content_Contenttype");
            });

            modelBuilder.Entity<Contenttype>(entity =>
            {
                entity.ToTable("Contenttype");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.ToTable("Employe");

                entity.Property(e => e.EmployeId).HasColumnName("EmployeID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.AlterMobile)
                    .HasColumnName("Alter_mobile")
                    .HasMaxLength(50);

                entity.Property(e => e.DeactiveDate).HasColumnType("date");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nid).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymetId);

                entity.ToTable("payment");

                entity.Property(e => e.PaymetId).HasColumnName("paymetID");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_payment_paymentMethod");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.PaymenttypeId);

                entity.ToTable("paymentMethod");

                entity.Property(e => e.PaymenttypeId).HasColumnName("PaymenttypeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(10);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EfectiveFrom).HasColumnType("date");

                entity.Property(e => e.EfectiveTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.VatId).HasColumnName("vatID");

                entity.HasOne(d => d.Vat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.VatId)
                    .HasConstraintName("FK_Product_vat");
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.HasKey(e => e.PriceId);

                entity.ToTable("ProductPrice");

                entity.Property(e => e.PriceId).HasColumnName("priceId");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EfectiveFrom).HasColumnType("date");

                entity.Property(e => e.EfectiveTo).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPrices)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductPrice_Product");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.EfectiveFrom).HasColumnType("date");

                entity.Property(e => e.EfectiveTo).HasColumnType("date");

                entity.Property(e => e.VendorMobile)
                    .HasColumnName("Vendor_mobile")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Purchase_Branch");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Purchase_payment");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.ToTable("purchaseDetail");

                entity.Property(e => e.PurchaseDetailId).HasColumnName("PurchaseDetailID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_purchaseDetail_Product");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_purchaseDetail_Purchase");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.ToTable("salary");

                entity.Property(e => e.SalaryId).HasColumnName("SalaryID");

                entity.Property(e => e.DeactiveDate).HasColumnType("date");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.JoingDate).HasColumnType("date");

                entity.Property(e => e.SalaryAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Salaries)
                    .HasForeignKey(d => d.EmployeId)
                    .HasConstraintName("FK_salary_Employe");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.SalesId);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CusMobile)
                    .HasColumnName("Cus_mobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Sales_Branch");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Sales_payment");
            });

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unitPrice")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SalesDetails_Product");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SalesDetails_Sales");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.HasOne(d => d.Stoicktype)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.StoicktypeId)
                    .HasConstraintName("FK_Stock_StocktypeId");
            });

            modelBuilder.Entity<StocktypeId>(entity =>
            {
                entity.HasKey(e => e.StocktypeId1);

                entity.ToTable("StocktypeId");

                entity.Property(e => e.StocktypeId1).HasColumnName("StocktypeId");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("User");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.BrachId).HasColumnName("brachId");

                entity.Property(e => e.DeactiveDate)
                    .HasColumnName("Deactive_date")
                    .HasColumnType("date");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.JoingDate)
                    .HasColumnName("Joing_date")
                    .HasColumnType("date");

                entity.Property(e => e.Moble)
                    .HasColumnName("moble")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Brach)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BrachId)
                    .HasConstraintName("FK_User_Branch");
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.ToTable("vat");

                entity.Property(e => e.VatId).HasColumnName("VatID");

                entity.Property(e => e.EfectiveFrom).HasColumnType("date");

                entity.Property(e => e.EfectiveTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}