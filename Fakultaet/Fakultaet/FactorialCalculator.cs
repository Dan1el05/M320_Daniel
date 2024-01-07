using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultaet
{
    public class FactorialCalculator
    {
        public int Calculate(int number)
        {

            if (number < 0)
            {
                Console.WriteLine("Fakultät für Minuszahlen nicht definiert");
                return 0;
              
            }

          if (number < 2) { return 1; }
           


         if (number > 2)

            {
                int fakultaet = 1;

                for (int i = 1; i <= number; i++)
                {
                    fakultaet = fakultaet * i;
                    
                }
                return fakultaet;
            }
         return 0;
        } }
}

