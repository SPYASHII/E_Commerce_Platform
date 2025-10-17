using DomainComponents.Core.Enums;
using DomainComponents.Core.Models.ServiceModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Main
{
    /// <summary>
    /// User model
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
        public UserRoles Role {  get; set; }
        public Cart Cart { get; set; }
    }
}
