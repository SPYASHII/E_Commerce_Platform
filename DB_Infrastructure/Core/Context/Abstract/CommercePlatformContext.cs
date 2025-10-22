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


namespace Database_Infrastructure.Core.Context.Abstract
{
    /// <summary>
    /// App database Context
    /// </summary>
    public abstract class CommercePlatformContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Сharacteristic> Сharacteristics { get; set; }
        public DbSet<NumericCharacteristicValue> NumericCharacteristicValues { get; set; }
        public DbSet<TextCharacteristicValue> TextCharacteristicValues { get; set; }
    }
}
