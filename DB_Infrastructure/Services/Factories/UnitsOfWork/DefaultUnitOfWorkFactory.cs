using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Infrastructure.Core.Context.Abstract;
using Database_Infrastructure.Core.Interfaces.Factories;
using Database_Infrastructure.Services.UnitsOfWork;
using DomainComponents.Core.Interfaces.Services;

namespace Database_Infrastructure.Services.Factories.UnitsOfWork
{
    /// <summary>
    /// Default unit of work factory
    /// </summary>
    public class DefaultUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private IContextFactory _contextFactory;
        private IGenericRepositoryFactory _genericRepositoryFactory;
        public DefaultUnitOfWorkFactory(IContextFactory contextFactory, IGenericRepositoryFactory genericRepositoryFactory)
        {
            _contextFactory = contextFactory;
            _genericRepositoryFactory = genericRepositoryFactory;
        }
        public IUnitOfWork Create()
        {
            CommercePlatformContext context = _contextFactory.Create();

            DefaultUnitOfWork unitOfWork = new DefaultUnitOfWork(context, _genericRepositoryFactory);

            return unitOfWork;
        }
    }
}
