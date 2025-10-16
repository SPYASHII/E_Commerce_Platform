using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Service.Characteristics
{
    public class TextCharacteristicValue : CharacteristicValue<string>
    {
        public string Value { get; set; }
    }
}
