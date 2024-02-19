using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizza
{
    internal class EinfachePizzaFabrik
    {
        public Pizza ErstellePizza(string typ)
        {
            Pizza pizza = null;

            if (typ.Equals("Salami"))
            {
                pizza = new SalamiPizza();
            }
            if (typ.Equals("Schinken"))
            {
                pizza = new SchinkenPizza();
            }
            return pizza;

        }
    }
}
