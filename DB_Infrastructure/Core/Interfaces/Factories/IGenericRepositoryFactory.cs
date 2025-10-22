using Database_Infrastructure.Core.Context.Abstract;
using DomainComponents.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Infrastructure.Core.Interfaces.Factories
{
    /// <summary>
    /// Interface of IGenericRepositoryFactory,
    /// in order to be able to swap concrete realizations of IGenericRepository
    /// </summary>
    public interface IGenericRepositoryFactory
    {
        public IGenericRepository<TEntity> Create<TEntity>(CommercePlatformContext context) where TEntity : class;
    }
}
