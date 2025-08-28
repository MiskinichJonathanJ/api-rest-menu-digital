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
                entity.Property(d => d.Name).HasColumnType("varchar(255)");
                entity.Property(d => d.Price).HasColumnType("decimal");
                entity.Property(d => d.Description).HasColumnType("text");
                entity.Property(d => d.ImageURL).HasColumnType("text");

                entity.HasOne(d => d.CategoryNav)
                    .WithMany(c => c.Dishes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
                entity.Property(c => c.Name).HasColumnType("varchar(25)");
                entity.Property(c => c.Description).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.HasKey(d => d.ID);
                entity.Property(d => d.ID).ValueGeneratedOnAdd();
                entity.Property(d => d.Name).HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
                entity.Property(o => o.DeliveryTo).HasColumnType("varchar(255)");
                entity.Property(o => o.Notes).HasColumnType("text");
                entity.Property(d => d.Price).HasColumnType("decimal");

                entity.HasOne(o =>o.DeliveryTypeNav)
                        .WithMany(d => d.OrdersNav)
                        .HasForeignKey(o => o.DeliveryTypeID)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                entity.HasOne(o => o.StatusNav)
                    .WithMany(s => s.OrdersNav)
                    .HasForeignKey(d => d.OverallStatusID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
                entity.Property(o => o.Notes).HasColumnType("text");

                entity.HasOne(o => o.DishNav)
                        .WithMany()
                        .HasForeignKey(o => o.DishId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                entity.HasOne(o => o.OrderNav)
                    .WithMany(ord => ord.Items)
                    .HasForeignKey(o => o.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                entity.HasOne(o => o.Status)
                    .WithMany(s => s.OrderItemsNav)
                    .HasForeignKey(o => o.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(s => s.ID);
                entity.Property(s => s.ID).ValueGeneratedOnAdd();
                entity.Property(s => s.Name).HasColumnType("varchar(25)");
            });
        }
    }
}
