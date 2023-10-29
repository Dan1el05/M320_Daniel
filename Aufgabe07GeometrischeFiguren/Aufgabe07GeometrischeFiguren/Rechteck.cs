using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Rechteck : Figur, IRotieren
    {
        private int height { get; set; }
        private int width { get; set; }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    Console.WriteLine("Ungültiger Wert für Höhe. Höhe muss positiv sein.");
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("Ungültiger Wert für Höhe. Höhe muss positiv sein.");
            }
        }

        public Rechteck(float x, float y, int height, int width) : base(x, y)
        {
            this.height = height;
            this.width = width;
            area = height * width;
        }

        public void verschieben() 
        {
            base.Verschieben();
        }
        public override void PrintArea() 
        {
            Console.WriteLine("Die Fläche von Rechteck ist: {0}", area);
        }


        public override void PrintPossition() 
        {
            Console.WriteLine("Meine x und y Koordinaten von obere Linke Seite ist x: {0} und y: {1}", x, y);
            y += height;
            x += width;
            Console.WriteLine("Untere Ecke ist die Koordinate x: {0} und y: {1}", x, y);
            Console.WriteLine("");
        }
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
