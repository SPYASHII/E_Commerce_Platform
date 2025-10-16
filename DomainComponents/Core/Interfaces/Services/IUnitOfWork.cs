using DomainComponents.Core.Models.Main;
using DomainComponents.Core.Models.Service.Characteristics;
using DomainComponents.Core.Models.ServiceModels.Characteristics;
using DomainComponents.Core.Models.ServiceModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Interfaces.Services
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<User> UserRepository { get; }
        public IGenericRepository<Cart> CartRepository { get; }
        public IGenericRepository<Product> ProductRepository { get; }
        public IGenericRepository<Category> CategoryRepository { get; }
        public IGenericRepository<Models.Main.Сharacteristic> СharacteristicRepository { get; }
        public IGenericRepository<TextCharacteristicValue> TextСharacteristicRepository { get; }
        public IGenericRepository<FloatCharacteristicValue> FloatСharacteristicRepository { get; }
        public void Save();
    }
}
