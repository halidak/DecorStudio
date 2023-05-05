using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio
{
    public class Supplier : IPrototype
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }
        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
