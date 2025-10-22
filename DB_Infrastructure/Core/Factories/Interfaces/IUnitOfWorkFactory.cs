using DomainComponents.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Infrastructure.Core.Factories.Interfaces
{
    /// <summary>
    /// Interface for IUnitOfWork factory
    /// </summary>
    public interface IUnitOfWorkFactory
    {
        public IUnitOfWork Create();
    }
}
