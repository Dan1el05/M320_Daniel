using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizza
{
    internal class Pizzeria
    {
        EinfachePizzaFabrik fabrik;

        public Pizzeria(EinfachePizzaFabrik fabrik)
        {
            this.fabrik = fabrik;
        }

        public Pizza bestellePizza(string typ)
        {
            Pizza pizza = null;

            pizza = fabrik.ErstellePizza(typ);

            
            return pizza;

        }

        
    }
}
