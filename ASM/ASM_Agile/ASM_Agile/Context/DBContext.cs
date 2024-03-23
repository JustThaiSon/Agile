using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ASM_Agile.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PhoneCategories> PhoneCategories { get; set; }
        public virtual DbSet<PhoneCustomers> PhoneCustomers { get; set; }
        public virtual DbSet<PhoneEmployees> PhoneEmployees { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-APKREC8K\\SQLEXPRESS;Initial Catalog=Quan_ly_dien_thoaii;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__Brands__DAD4F3BED10860DE");

                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.BrandName).IsUnicode(false);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Categori__19093A2B3035ABA0");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName).IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B81B9C559A");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Customer__A9D10534849D2737")
                    .IsUnique();

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Pass).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1A64FF972");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Employee__A9D1053417DB5C88")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Pass).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Employees__Manag__37703C52");
            });

            modelBuilder.Entity<Managers>(entity =>
            {
                entity.HasKey(e => e.ManagerId)
                    .HasName("PK__Managers__3BA2AA8141F65969");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Managers__A9D1053402AC6C19")
                    .IsUnique();

                entity.Property(e => e.ManagerId).ValueGeneratedNever();

                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Pass).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.Property(e => e.NhaSanXuatId).ValueGeneratedNever();

                entity.Property(e => e.TenNhaSanXuat).IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK__OrderDet__D3B9D30CDFA1A8F0");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__0B5CAFEA");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("FK__OrderDeta__Phone__0C50D423");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAF5F8F32B7");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__0880433F");
            });

            modelBuilder.Entity<PhoneCategories>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.CategoryId })
                    .HasName("PK__PhoneCat__527ED872A513CBD4");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PhoneCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCate__Categ__30C33EC3");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneCategories)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCate__Phone__2FCF1A8A");
            });

            modelBuilder.Entity<PhoneCustomers>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.CustomerId })
                    .HasName("PK__PhoneCus__69A4AD9B956E36D0");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PhoneCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCust__Custo__41EDCAC5");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneCustomers)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCust__Phone__40F9A68C");
            });

            modelBuilder.Entity<PhoneEmployees>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.EmployeeId })
                    .HasName("PK__PhoneEmp__F4434F2F5DB8E6DB");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PhoneEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneEmpl__Emplo__3E1D39E1");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneEmployees)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneEmpl__Phone__3D2915A8");
            });

            modelBuilder.Entity<Phones>(entity =>
            {
                entity.HasKey(e => e.PhoneId)
                    .HasName("PK__Phones__F3EE4BD036FEE3BD");

                entity.Property(e => e.PhoneId).ValueGeneratedNever();

                entity.Property(e => e.Model).IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Phones__BrandID__2CF2ADDF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
