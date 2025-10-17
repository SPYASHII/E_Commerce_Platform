using DomainComponents.Core.Enums;
using DomainComponents.Core.Models.Service.Characteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Main
{
    public class Сharacteristic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CharacteristicType CharacteristicType { get; set; }
        public List<Category> Categories { get; set; }
    }
}
