using Exam_320;

namespace Exam.M320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            President bill = new President();
            VicePresident john = new VicePresident();
            Director max = new Director();

            Purchase p1 = new Purchase(3, 350, 7 - 7);
            Purchase p2 = new Purchase(1, 15000, 0);
            Purchase p3 = new Purchase(1, 100000, 2 - 4);

            max.processRequest(p1);
            max.processRequest(p2);
            max.processRequest(p3);
        }
    }
}
   