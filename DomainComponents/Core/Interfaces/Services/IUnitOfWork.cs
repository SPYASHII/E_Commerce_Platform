using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using DomainComponents.Core.Models;

namespace DomainComponents.Core.Interfaces.Services
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<User> UserRepository { get; }
        public IGenericRepository<Cart> CartRepository { get; }
        public IGenericRepository<Product> ProductRepository { get; }
        public IGenericRepository<Category> CategoryRepository { get; }
        public IGenericRepository<Сharacteristic> СharacteristicRepository { get; }
        public void Save();
    }
}
