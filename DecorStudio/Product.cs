using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio
{
    public class Product : IPrototype
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
