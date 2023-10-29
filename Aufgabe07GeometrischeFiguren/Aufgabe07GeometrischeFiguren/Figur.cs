﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Figur
    {

        public float Area { get; set; }

        public float x { get; set; }
        public float y { get; set; }

        public float area { get; set; }

        public Figur(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Figur(float x, float y, int routiren)
        {
            this.x = x;
            this.y = y;
           
        }

        public Figur()
        {
        }

        public virtual void Verschieben()
        {
            Random random = new Random();
            x += (float)(random.NextDouble() * 90.0 + 10.0);
        }

        public virtual void PrintArea()
        {
            Console.WriteLine("Die Fläche von der Figur ist: {0}", area); 
        }
        

        //3 sachen Modell frage und richtig imprementiert.
       public virtual void  PrintPossition()
      {
         Console.WriteLine("Meine x und y Koordinate ist an folgender Stelle: x Achse: {0}, y Achse {1}:", x, y);
      }
    }
}
