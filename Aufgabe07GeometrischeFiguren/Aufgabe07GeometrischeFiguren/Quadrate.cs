using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Quadrate : Rechteck, IRotieren
    {
      
        public Quadrate(float x, float y, int height, int width) : base(x, y, height, width)
        {
            area = height * width;
        }
       
        public void TesteGleicheSeiten()
        {
            if (Height == Width)
            {
                Console.WriteLine("Es ist ein Quadrat.");
            }
            else
            {
                 Console.WriteLine("Die Figur ist kein Quadrat.");
            }
        }

        public void PrintArea() 
        {
            Console.WriteLine("Die Fläche von Quadrat ist: {0}", area);
        }

        public virtual void PrintPossition() 
        { 
            base.printPossition();
        }

        public void Verschieben() 
        { 
            base.verschieben(); 
        }

        public void Rotiern()
        {

            Console.WriteLine("Quadrat wurde um 90° im Uhrzeigersinn rotiert. Bleibt aber unverändert.");

        }

    }
}
