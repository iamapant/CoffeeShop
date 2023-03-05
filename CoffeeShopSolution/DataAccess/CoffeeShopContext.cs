using System;
using System.Collections.Generic;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace DataAccess;

public partial class CoffeeShopContext : DbContext {
    public CoffeeShopContext() {
    }

    public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)
        : base(options) {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected internal User admin = getAdmin();

    private static User getAdmin() {
        User admin = new User();
        IConfiguration configuration = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", true, true).Build();
        admin = new User {
            UserName = configuration["account:admin:username"],
            Password = configuration["account:admin:password"]
        };
        return admin;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        IConfiguration configuration = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", true, true).Build();
        optionsBuilder.UseSqlServer(configuration["ConnectionStrings:CoffeeShopDB"]);
        admin = new User {
            UserName = configuration["account:admin:username"],
            Password = configuration["account:admin:password"]
        };
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Cart>(entity => {
            entity
                .HasNoKey()
                .ToTable("Cart");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("amount");
            entity.Property(e => e.ItemId).HasColumnName("iid");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("note");
            entity.Property(e => e.UserId).HasColumnName("uid");

            entity.HasOne(d => d.ItemIdNavigation).WithMany()
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Cart__iid__52593CB8");

            entity.HasOne(d => d.UserIdNavigation).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Cart__uid__5165187F");
        });

        modelBuilder.Entity<Item>(entity => {
            entity.HasKey(e => e.ItemId).HasName("PK__Item__3213E83F715703FE");

            entity.ToTable("Item");

            entity.HasIndex(e => e.ItemName, "UQ__Item__72E12F1B038CAD42").IsUnique();

            entity.Property(e => e.ItemId).HasColumnName("id");
            entity.Property(e => e.Descr)
                .HasMaxLength(200)
                .HasColumnName("descr");
            entity.Property(e => e.ItemName)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Stock)
                .HasDefaultValueSql("((1))")
                .HasColumnName("stock");
            entity.Property(e => e.ItemType)
                .HasMaxLength(40)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Order>(entity => {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C2FFCF138CD9ED3A");

            entity.Property(e => e.OrderId).HasColumnName("oid");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UserId).HasColumnName("uid");

            entity.HasOne(d => d.UserIdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Orders__uid__571DF1D5");
        });

        modelBuilder.Entity<OrderDetail>(entity => {
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
                .HasConstraintName("FK__OrderDetail__iid__5AEE82B9");

            entity.HasOne(d => d.OrderIdNavigation).WithMany()
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDetail__oid__59FA5E80");
        });

        modelBuilder.Entity<User>(entity => {
            entity.HasKey(e => e.UserId).HasName("PK__Users__3213E83FCB6CDA9E");

            entity.HasIndex(e => e.UserName, "UQ__Users__72E12F1BA20CA1F0").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E6164BA4C325B").IsUnique();

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
