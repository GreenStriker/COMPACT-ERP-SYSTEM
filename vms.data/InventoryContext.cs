﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
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
        public virtual DbSet<Expence> Expences { get; set; }
        public virtual DbSet<ExpenceType> ExpenceTypes { get; set; }
        public virtual DbSet<MeasureUnit> MeasureUnits { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductLog> ProductLogs { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<PurchasePayment> PurchasePayments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalePayment> SalePayments { get; set; }
        public virtual DbSet<SalesDetail> SalesDetails { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StocktypeId> StocktypeIds { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
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

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.DeactiveDate)
                    .HasColumnName("Deactive_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.OpeningDate).HasColumnType("date");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(500);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Content_Product");
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

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nid).HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Employes)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Employe_Branch");
            });

            modelBuilder.Entity<Expence>(entity =>
            {
                entity.ToTable("Expence");

                entity.Property(e => e.ExpenceId).HasColumnName("ExpenceID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ExpenceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpencePurpose).HasMaxLength(500);

                entity.Property(e => e.ExpenceTypeId).HasColumnName("ExpenceTypeID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Expences)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Expence_Branch");

                entity.HasOne(d => d.ExpencePersonNavigation)
                    .WithMany(p => p.Expences)
                    .HasForeignKey(d => d.ExpencePerson)
                    .HasConstraintName("FK_Expence_Employe");

                entity.HasOne(d => d.ExpenceType)
                    .WithMany(p => p.Expences)
                    .HasForeignKey(d => d.ExpenceTypeId)
                    .HasConstraintName("FK_Expence_ExpenceType");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Expences)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Expence_payment");
            });

            modelBuilder.Entity<ExpenceType>(entity =>
            {
                entity.ToTable("ExpenceType");

                entity.Property(e => e.ExpenceTypeId).HasColumnName("ExpenceTypeID");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Remark).HasMaxLength(500);
            });

            modelBuilder.Entity<MeasureUnit>(entity =>
            {
                entity.HasKey(e => e.MunitId);

                entity.ToTable("MeasureUnit");

                entity.Property(e => e.MunitId).HasColumnName("MUnitId");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymetId);

                entity.ToTable("payment");

                entity.Property(e => e.PaymetId).HasColumnName("paymetID");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Remark).HasMaxLength(500);

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
                entity.ToTable("PaymentMethod");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EfectiveFrom).HasColumnType("date");

                entity.Property(e => e.EfectiveTo).HasColumnType("date");

                entity.Property(e => e.ModelNo).HasMaxLength(50);

                entity.Property(e => e.MunitId).HasColumnName("MUnitId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.VatId).HasColumnName("vatID");

                entity.HasOne(d => d.Munit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.MunitId)
                    .HasConstraintName("FK_Product_MeasureUnit");

                entity.HasOne(d => d.Vat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.VatId)
                    .HasConstraintName("FK_Product_vat");
            });

            modelBuilder.Entity<ProductLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("ProductLog");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EfectiveFrom).HasColumnType("date");

                entity.Property(e => e.EfectiveTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.VatId).HasColumnName("vatID");
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

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorMobile)
                    .HasColumnName("Vendor_mobile")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Purchase_Branch");
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

            modelBuilder.Entity<PurchasePayment>(entity =>
            {
                entity.ToTable("PurchasePayment");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.PurchasePayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_PurchasePayment_paymentMethod");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchasePayments)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_PurchasePayment_Purchase");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName).HasMaxLength(50);
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

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Sales_Branch");
            });

            modelBuilder.Entity<SalePayment>(entity =>
            {
                entity.ToTable("SalePayment");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.SalePayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_SalePayment_paymentMethod");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalePayments)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SalePayment_Sales");
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

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_SalesDetails_Stock");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.InQty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InitialQty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PurchaseReturnQty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SaleQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SaleReturnQty).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Stock_Branch");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Stock_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Stock_Product");

                entity.HasOne(d => d.PurchaseDetail)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.PurchaseDetailId)
                    .HasConstraintName("FK_Stock_purchaseDetail");
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

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Brach)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BrachId)
                    .HasConstraintName("FK_User_Branch");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Role");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.Name).HasMaxLength(50);
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