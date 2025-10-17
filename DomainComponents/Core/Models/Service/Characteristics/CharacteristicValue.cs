using DomainComponents.Core.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Service.Characteristics
{
    public abstract class CharacteristicValue<TValue>
    {
        public int CharacteristicId { get; set; }
        public int ProductId { get; set; }
        public TValue Value { get; set; }
        public Product Product { get; set; }
        public Сharacteristic Сharacteristic { get; set; }
    }
}
