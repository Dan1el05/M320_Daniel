using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es
{
    internal class Wetterdaten
    {

        public int WetterdatenErzeugen() 
        {
            Random rnd = new Random();
            int temperatureOut = rnd.Next(-20, 50);
            int windSpeed = rnd.Next(0, 100);
            bool regen = rnd.Equals(true);
            return temperatureOut + windSpeed +;
        }

        public bool ObRegen()
        {
            bool regen = false;
            return regen;
        }



    }
}
