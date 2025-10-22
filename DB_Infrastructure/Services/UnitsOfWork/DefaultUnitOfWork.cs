using Database_Infrastructure.Core.Context.Abstract;
using Database_Infrastructure.Core.Interfaces.Factories;
using DomainComponents.Core.Interfaces.Services;
using DomainComponents.Core.Models;
using DomainComponents.Core.Models.Main;
using DomainComponents.Core.Models.Service.Characteristics;
using DomainComponents.Core.Models.ServiceModels.Characteristics;
using DomainComponents.Core.Models.ServiceModels.Users;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Database_Infrastructure.Services.UnitsOfWork
{
    /// <summary>
    /// Unit of work for CommercePlatformContext,
    /// uses IGenericRepositoryFactory to create instances of IGenericRepository
    /// </summary>
    public class DefaultUnitOfWork : IUnitOfWork
    {

        private CommercePlatformContext _context;
        private IGenericRepositoryFactory _genericRepositoryFactory;

        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Cart> _cartRepository;

        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<Category> _categoryRepository;

        private IGenericRepository<Сharacteristic> _characteristicRepository;

        private IGenericRepository<NumericCharacteristicValue> _numericCharacteristicValueRepository;
        private IGenericRepository<TextCharacteristicValue> _textCharacteristicValueRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">Derived class from CommercePlatformContext</param>
        /// <param name="genericRepositoryFactory">Generic Repository Factory</param>
        public DefaultUnitOfWork(CommercePlatformContext context, IGenericRepositoryFactory genericRepositoryFactory)
        {
            _context = context;
            _genericRepositoryFactory = genericRepositoryFactory;
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                _userRepository ??= _genericRepositoryFactory.Create<User>(_context);
                return _userRepository;
            }
        }

        public IGenericRepository<Cart> CartRepository
        {
            get
            {
                _cartRepository ??= _genericRepositoryFactory.Create<Cart>(_context);
                return _cartRepository;
            }
        }

        public IGenericRepository<Product> ProductRepository
        {
            get
            {
                _productRepository ??= _genericRepositoryFactory.Create<Product>(_context);
                return _productRepository;
            }
        }

        public IGenericRepository<Category> CategoryRepository
        {
            get
            {
                _categoryRepository ??= _genericRepositoryFactory.Create<Category>(_context);
                return _categoryRepository;
            }
        }

        public IGenericRepository<Сharacteristic> СharacteristicRepository
        {
            get
            {
                _characteristicRepository ??= _genericRepositoryFactory.Create<Сharacteristic>(_context);
                return _characteristicRepository;
            }
        }

        public IGenericRepository<TextCharacteristicValue> TextСharacteristicValueRepository
        {
            get
            {
                _textCharacteristicValueRepository ??= _genericRepositoryFactory.Create<TextCharacteristicValue>(_context);
                return _textCharacteristicValueRepository;
            }
        }

        public IGenericRepository<NumericCharacteristicValue> NumericCharacteristicValueRepository
        {
            get
            {
                _numericCharacteristicValueRepository ??= _genericRepositoryFactory.Create<NumericCharacteristicValue>(_context);
                return _numericCharacteristicValueRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
