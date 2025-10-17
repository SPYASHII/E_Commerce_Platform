using DomainComponents.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainComponents.Core.Models.Main;

namespace DomainComponents.Core.Models.ServiceModels.Users
{
    /// <summary>
    ///  A Cart model that connects User with products that he want to buy
    /// </summary>
    /// <remarks>
    /// Save in database ONLY IF AUTHORIZED
    /// </remarks>
    public class Cart
    {
        public int UserId { get; set; }
        public List<Product> Products { get; set; }
        public User User { get; set; }
    }
}
