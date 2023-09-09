namespace DemoKpnstr
{
    internal class Program
    {
        private static System.Drawing.Color red;
        private static System.Drawing.Color blue;

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5,4);
            rectangle.show();
            Rectangle rectangle1 = new Rectangle(7,8, red);
            rectangle1.show();
            Rectangle rectangle2 = new Rectangle(7, 8, System.Drawing.Color.Red, false);
            rectangle2.show();
            Rectangle rectangle3 = new Rectangle(7, 8, blue, false, 56);
            rectangle3.show();
        }
    }
}