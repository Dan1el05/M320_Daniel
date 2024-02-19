using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizza
{
    internal class SalamiPizza : Pizza
    {
        public override void vorbereiten()
        {
            Console.WriteLine("Die Salamipizza wird vorbereitet");
        }
        public SalamiPizza() { }
    }
}
