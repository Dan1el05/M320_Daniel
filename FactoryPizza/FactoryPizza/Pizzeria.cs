using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizza
{
    internal class Pizzeria : Pizza
    {
        EinfachePizzaFabrik fabrik;

        public Pizzeria(EinfachePizzaFabrik fabrik)
        {
            this.fabrik = fabrik;
        }

        Pizza bestellePizza(string typ)
        {
            Pizza pizza = null;

            pizza = fabrik.ErstellePizza(typ);

            pizza.vorbereiten();
            pizza.backen();
            pizza.schneiden();
            pizza.einpacken();
            return pizza;

        }

        
    }
}
