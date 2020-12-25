using InternetStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetStore.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Order>().ToTable("Orders");

            modelBuilder.Entity<OrderToProduct>()
            .HasKey(t => new { t.OrderId, t.ProductId });

            modelBuilder.Entity<OrderToProduct>()
                .HasOne(sc => sc.Product)
                .WithMany(s => s.OrderToProduct)
                .HasForeignKey(sc => sc.ProductId);

            modelBuilder.Entity<OrderToProduct>()
                .HasOne(sc => sc.Order)
                .WithMany(c => c.OrderToProduct)
                .HasForeignKey(sc => sc.OrderId);
        }
    }

   
}
