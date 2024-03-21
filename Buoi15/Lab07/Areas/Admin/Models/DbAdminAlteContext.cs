using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab07.Areas.Admin.Models;

public partial class DbAdminAlteContext : DbContext
{
    public DbAdminAlteContext()
    {
    }

    public DbAdminAlteContext(DbContextOptions<DbAdminAlteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.; Database=DB_AdminALTE;Trusted_Connection=True; MultipleActiveResultSets=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Banner__3214EC0719074429");

            entity.ToTable("Banner");

            entity.HasIndex(e => e.Name, "UQ__Banner__737584F60D92E4D3").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Blog__3214EC074114C960");

            entity.ToTable("Blog");

            entity.HasIndex(e => e.Name, "UQ__Blog__737584F6811109B5").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC0736DC84CE");

            entity.ToTable("Category");

            entity.HasIndex(e => e.Name, "UQ__Category__737584F6B7AB1D83").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC0786554381");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Name, "UQ__Product__737584F6A4A0C364").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SalePrice).HasColumnName("salePrice");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Product__Categor__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
