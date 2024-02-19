using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizza
{
    internal class SchinkenPizza : Pizza
    {
        public override void vorbereiten()
        {
            Console.WriteLine("Die Schinkenipizza wird vorbereitet");
        }
        public SchinkenPizza() { }
    }
}
