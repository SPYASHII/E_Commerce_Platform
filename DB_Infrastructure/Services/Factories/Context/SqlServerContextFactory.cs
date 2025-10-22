using Database_Infrastructure.Core.Context;
using Database_Infrastructure.Core.Context.Abstract;
using Database_Infrastructure.Core.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Infrastructure.Services.Factories.Context
{
    //HACK: maybe useless class, delete
    public class SqlServerContextFactory : IContextFactory
    {
        public CommercePlatformContext Create()
        {
            return new SqlServerContext();
        }
    }
}
