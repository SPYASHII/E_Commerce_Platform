using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainComponents.Core.Models.Main;
using DomainComponents.Core.Models.Service.Characteristics;

namespace DomainComponents.Core.Models.ServiceModels.Characteristics
{
    public class NumericCharacteristicValue : CharacteristicValue<float>
    {
        public float Value { get; set; }
    }
}
