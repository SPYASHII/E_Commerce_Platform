using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Infrastructure.Core.Context.Abstract;
using Database_Infrastructure.Core.Interfaces.Factories;
using Database_Infrastructure.Services.Repositories;
using DomainComponents.Core.Interfaces.Services;

namespace Database_Infrastructure.Services.Factories.Repositories
{
    /// <summary>
    /// Default repository factory
    /// </summary>
    public class DefaultGenericRepositoryFactory : IGenericRepositoryFactory
    {
        public IGenericRepository<TEntity> Create<TEntity>(CommercePlatformContext context) where TEntity : class
        {
            return new DefaultGenericRepository<TEntity>(context);
        }
    }
}
