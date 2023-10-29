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

        private int height;
        private int a;
        private int b;
        private int c;

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

        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                    Console.WriteLine("Ungültiger Wert für Höhe. Höhe muss positiv sein.");
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                    Console.WriteLine("Ungültiger Wert für Höhe. Höhe muss positiv sein.");
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                if (value > 0)
                    c = value;
                else
                    Console.WriteLine("Ungültiger Wert für Höhe. Höhe muss positiv sein.");
            }
        }

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
            base.Verschieben();
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
            float originalX = x;
            float originalY = y;

            x = y;
            y = -originalX;

            Console.WriteLine("Dreieck wurde um 90° im Uhrzeigersinn rotiert.");
        }
    }



}
