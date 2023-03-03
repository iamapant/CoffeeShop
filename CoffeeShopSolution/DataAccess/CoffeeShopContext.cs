using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

public partial class CoffeeShopContext : DbContext
{
    public CoffeeShopContext()
    {
    }

    public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("CoffeeShopDB"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cart");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("amount");
            entity.Property(e => e.ItemId).HasColumnName("iid");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .HasColumnName("note");
            entity.Property(e => e.UserId).HasColumnName("uid");

            entity.HasOne(d => d.ItemIdNavigation).WithMany()
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Cart__iid__72C60C4A");

            entity.HasOne(d => d.UserIdNavigation).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Cart__uid__71D1E811");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__Item__3213E83FBE4CE8D1");

            entity.ToTable("Item");

            entity.Property(e => e.ItemId).HasColumnName("id");
            entity.Property(e => e.Descr)
                .HasMaxLength(200)
                .HasColumnName("descr");
            entity.Property(e => e.ItemName)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Stock)
                .HasDefaultValueSql("((1))")
                .HasColumnName("stock");
            entity.Property(e => e.ItemType)
                .HasMaxLength(40)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C2FFCF13CB1E6200");

            entity.Property(e => e.OrderId).HasColumnName("oid");
            entity.Property(e => e.Total)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UserId).HasColumnName("uid");

            entity.HasOne(d => d.UserIdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Orders__uid__76969D2E");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("amount");
            entity.Property(e => e.ItemId).HasColumnName("iid");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("note");
            entity.Property(e => e.OrderId).HasColumnName("oid");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ItemIdNavigation).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__OrderDetail__iid__7A672E12");

            entity.HasOne(d => d.OrderIdNavigation).WithMany()
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDetail__oid__797309D9");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__3213E83F63B8DC84");

            entity.Property(e => e.UserId).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("email");
            entity.Property(e => e.UserName)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(40)
                .HasColumnName("pass");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
