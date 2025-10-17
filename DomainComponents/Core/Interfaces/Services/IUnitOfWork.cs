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
    /// <summary>
    /// Unit Of Work Pattern for Database.
    /// Use to connect implementation of database connection with Main Services.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<User> UserRepository { get; }
        public IGenericRepository<Cart> CartRepository { get; }
        public IGenericRepository<Product> ProductRepository { get; }
        public IGenericRepository<Category> CategoryRepository { get; }
        public IGenericRepository<Models.Main.Сharacteristic> СharacteristicRepository { get; }
        public IGenericRepository<TextCharacteristicValue> TextСharacteristicRepository { get; }
        public IGenericRepository<NumericCharacteristicValue> FloatСharacteristicRepository { get; }
        public void Save();
    }
}
