using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DomainComponents.Core.Models.Main
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Сharacteristic> Сharacteristics { get; set; }
        public List<Product> Products { get; set; }
    }
}
