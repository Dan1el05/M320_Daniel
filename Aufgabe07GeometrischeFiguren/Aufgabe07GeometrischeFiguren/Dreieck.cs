using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Dreieck : Figur, IRotieren
    {

        public int height { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }


        public Dreieck(float x, float y, int height, int a, int b, int c) : base(x, y)
        {
            this.height = height;
            this.a = a;
            this.b = b;
            this.c = c;
            area = a * height;
        }

        public virtual void verschieben() 
        {
            base.verschieben();
        }


        public override void PrintArea() 
        {
            Console.WriteLine("Die Fläche von Dreieck ist: {0}", area);
        }

        public void PrintPossition()
        {
             base.PrintPossition();
          }

        public void Rotiern()
        {
            // Drehe das Dreieck um 90° im Uhrzeigersinn (Tausche die Koordinaten der Eckpunkte)
            float originalX = x;
            float originalY = y;

            x = y;
            y = -originalX;

            Console.WriteLine("Dreieck wurde um 90° im Uhrzeigersinn rotiert.");
        }
    }



}
