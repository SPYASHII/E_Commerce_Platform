using DomainComponents.Core.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Service.Characteristics
{
    /// <summary>
    /// Abstract class for concrete value types of characteristics
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public abstract class CharacteristicValue<TValue>
    {
        public int CharacteristicId { get; set; }
        public int ProductId { get; set; }
        public TValue Value { get; set; }
        public Product Product { get; set; }
        public Сharacteristic Сharacteristic { get; set; }
    }
}
