using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungAuto
{
    internal class Auto
    {
        public void Anlassen()
        {
            Console.WriteLine("Auto Anlassen");
            Motor motor = new Motor();
            motor.Starten();
           


        }
    }
}
