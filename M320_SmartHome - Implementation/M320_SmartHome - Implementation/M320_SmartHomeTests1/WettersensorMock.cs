using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M320_SmartHome
{
    public class WettersensorMock : IWettersensor
    {
        private Wetterdaten daten;

        public WettersensorMock(double Aussentemperatur, double Windgeschwindigkeit, bool Regen) 
        {
           
            
        }
        public Wetterdaten GetWetterdaten()
        {
            return daten;
        }
    }
}
