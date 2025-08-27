using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Status> Statuses  { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>(entity =>
            {
                entity.HasKey(d => d.ID);
                entity.Property(d => d.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.HasKey(d => d.ID);
                entity.Property(d => d.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(s => s.ID);
                entity.Property(s => s.ID).ValueGeneratedOnAdd();
            });
        }
    }
}
