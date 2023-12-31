﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe07GeometrischeFiguren
{
    internal class Kreis : Figur
    {
        private float radius;
        


        public float pi { get; set; }
        public float centreX { get; set; }
        public float centreY { get; set; }

        public float Radius
 c

        public Kreis( float radius, float centreX, float centreY) : base(centreX,centreY)
        {
            pi = (float)Math.PI;
            this.radius = radius;
            this.centreX = centreX;
            this.centreY = centreY;
            area = pi * (float)Math.Pow(radius, 2);
        }

        public override void Verschieben()
        {
            Random random = new Random();
            centreX += (float)(random.NextDouble() * 90.0 + 10.0);
        }

        public override void PrintArea()
        {
            Console.WriteLine("Die Fläche von Kreis ist: {0}", area);
        }

        public override void PrintPossition()
        {
            Console.WriteLine("Meine x und y Koordinate ist an folgender Stelle: x Achse: {0}, y Achse: {1}", centreX, centreY);
            Console.WriteLine("");
        }
      
    
            
        }
    }

