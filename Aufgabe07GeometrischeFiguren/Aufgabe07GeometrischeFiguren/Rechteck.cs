using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Rechteck : Figur, IRotieren
    {
        public int height { get; set; }
        public int width { get; set; }




        public Rechteck(float x, float y, int height, int width) : base(x, y,)
        {
            this.height = height;
            this.width = width;
            area = height * width;
        }

        public void verschieben() 
        {
            base.verschieben();
        }
        public override void PrintArea() 
        {
            Console.WriteLine("Die Fläche von Rechteck ist: {0}", area);
        }


        public void printPossition() { }

        public void Rotiern()
        {

            int originalWidth = width;
            width = height;
            height = originalWidth;


            x -= (width - originalWidth) / 2;
            y -= (height - originalWidth) / 2;

            Console.WriteLine("Rechteck wurde um 90° im Uhrzeigersinn rotiert. Die Korrdinaten sind nun {0} und {1}", x, y);

        }
    }
}
