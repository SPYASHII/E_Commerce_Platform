using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Service.Characteristics
{
    /// <summary>
    /// Text type of characteristic (for everything that is not a number)
    /// </summary>
    public class TextCharacteristicValue : CharacteristicValue<string>
    {
        public string Value { get; set; }
    }
}
