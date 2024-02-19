using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizza
{
    internal abstract class Pizza 
    {
        public abstract void vorbereiten();
       
        public void backen()
        {
            Console.WriteLine("Pizza wird vorbereitet");
        }
        public void schneiden()
        {
            Console.WriteLine("Pizza wird vorbereitet");
        }

        public void einpacken()
        {
            Console.WriteLine("Pizza wird vorbereitet");
        }
    }
}
