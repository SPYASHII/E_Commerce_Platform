using DomainComponents.Core.Models.Main;
using DomainComponents.Core.Models.Service.Characteristics;
using DomainComponents.Core.Models.ServiceModels.Characteristics;
using DomainComponents.Core.Models.ServiceModels.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace Database_Infrastructure.Core
{
    public class CommercePlatformContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Сharacteristic> Сharacteristics { get; set; }
        public DbSet<NumericCharacteristicValue> NumericCharacteristicValues { get; set; }
        public DbSet<TextCharacteristicValue> TextCharacteristicValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //HACK: Only for first tests
            optionsBuilder.UseSqlServer("Server=DESKTOP-SU7JF9S\\MSSQLSERVER_2;Database=E_Commerce_test1;Trusted_Connection=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlite("Data Source=database.dat");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("money");

            modelBuilder.Entity<Cart>()
                .HasKey(c => c.UserId);

            modelBuilder.Entity<Cart>()
                .HasMany<Product>()
                .WithMany();

            modelBuilder.Entity<NumericCharacteristicValue>()
                .HasOne(x => x.Сharacteristic)
                .WithMany()
                .HasForeignKey(x => x.CharacteristicId);

            modelBuilder.Entity<NumericCharacteristicValue>()
                .HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<NumericCharacteristicValue>()
                .HasKey(x => new {x.ProductId, x.CharacteristicId});


            modelBuilder.Entity<TextCharacteristicValue>()
               .HasOne(x => x.Сharacteristic)
               .WithMany()
               .HasForeignKey(x => x.CharacteristicId);

            modelBuilder.Entity<TextCharacteristicValue>()
                .HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<TextCharacteristicValue>()
                .HasKey(x => new { x.ProductId, x.CharacteristicId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
