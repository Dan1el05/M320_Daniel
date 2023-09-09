using System;

namespace Repetition1.Lektion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 200, 450, 700, 175, 259 };
            int summe = 0;

            foreach (int num in array)
            {
                summe += num;
            }

            Console.WriteLine("Die Summe der Zahlen im Array beträgt: " + summe);
        }
    }
}