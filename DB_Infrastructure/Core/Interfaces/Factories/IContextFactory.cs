using Database_Infrastructure.Core.Context.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Infrastructure.Core.Interfaces.Factories
{
    /// <summary>
    /// Factory interface for swapping database context
    /// </summary>
    public interface IContextFactory
    {
        public CommercePlatformContext Create();
    }
}
