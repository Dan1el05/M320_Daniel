using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Figur
    {
        private float area1;

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

        public virtual void verschieben()
        {
            Random random = new Random();
            x += random.Nextfloat() * 400 - 200; 
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
