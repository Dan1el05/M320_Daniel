using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKpnstr
{
    internal class Rectangle
    {
        private int width;
        private int height;
        private Color color;
        private bool isTransparent;
        private int area;

        public Rectangle(int width, int height)
        {

            Console.WriteLine("Ich bin ein Rechteck und wurde instaziert");
            this.width = width;
            this.height = height;
            
        }
        
        public Rectangle(int width, int height, Color color) : this(width,height)
        {

            Console.WriteLine("Ich bin ein Rechteck und wurde instaziert");
            this.color = color;
        }
        public Rectangle(int width, int height, Color color, bool isTransparent)
        {

            Console.WriteLine("Ich bin ein Rechteck und wurde instaziert");
            this.width = width;
            this.height = height;
            this.color = color;
            this.isTransparent = isTransparent;
        }
        public Rectangle(int width, int height, Color color, bool isTransparent, int area)
        {

            Console.WriteLine("Ich bin ein Rechteck und wurde instaziert");
            this.width = width;
            this.height = height;
            this.color = color;
            this.isTransparent = isTransparent;
            this.area = area;
        }

        public void show()
        {
            Console.WriteLine("width {0}", width);
            Console.WriteLine("height {0}", height);
            Console.WriteLine("color {0}", color);
            Console.WriteLine("isTransparent {0}", isTransparent);
            Console.WriteLine("area {0}", area);
        }

    }
}
