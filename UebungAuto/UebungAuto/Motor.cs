using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungAuto
{
    internal class Motor
    {
        public void Starten()
        {
            Console.WriteLine("Motor starten");
            Motor motor = new Motor();
            Benzinpumpe benzinpumpe = new Benzinpumpe();
            Anlasser anlasser = new Anlasser();
            benzinpumpe.Pumpen();
            anlasser.Starten();
            motor.Regeln();

        }

        private void Regeln()
        {
            for (int i = 0; i < 7; i++) 
            {
                Console.WriteLine("Motor Regeln");

            }
            Anlasser anlasser = new Anlasser();
            anlasser.Stopen();
        }
    }
}
