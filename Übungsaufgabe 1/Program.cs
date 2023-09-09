using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungsaufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
 
            while (true)
            {
                
                Console.WriteLine("1. ggt berechnen");
                Console.WriteLine("2. kgv berechnen");
                Console.WriteLine("3. kgv rekrusiv berechnen");
                Console.WriteLine("4. Arithmetischer Mittelwert kleinster Wert grösster Wert ausrechnen ");
                Console.WriteLine("5. Variabeln vertauschen");
                Console.WriteLine("6. Inhalt eines Array vertauschen");
                Console.WriteLine("7. Beenden");
                int choice = MyMath.ReadInt("Wählen eine Option: ");

                if (choice == 1)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int gcd = MyMath.Calc_ggT(a, b);
                    MyMath.ShowResult("ggT", a, b, gcd);
                    Console.WriteLine("");
                }
                else if (choice == 2)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int lcm = MyMath.Calc_kgV(a, b);
                    MyMath.ShowResult("KgV", a, b, lcm);
                    Console.WriteLine("");
                }
                else if (choice == 3)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int lcm = MyMath.Calc_ggT_r(a, b);
                    MyMath.ShowResult("KgV_r", a, b, lcm);
                    Console.WriteLine("");
                }
                else if (choice == 4)
                {
                    int count = MyMath.ReadInt("Geben Sie die Anzahl der Zahlen für das Array ein: ");
                    int[] numbers = MyMath.ReadNumber(count);

                    double mean = MyMath.CalculateMean(numbers);
                    int minValue = MyMath.FindMinValue(numbers);
                    int maxValue = MyMath.FindMaxValue(numbers);

                    Console.WriteLine($"Arithmetischer Mittelwert: {mean}");
                    Console.WriteLine("");
                    Console.WriteLine($"Kleinster Wert: {minValue}");
                    Console.WriteLine("");
                    Console.WriteLine($"Größter Wert: {maxValue}");
                    Console.WriteLine("");
                }
                else if (choice == 5)
                {
                    int x = MyMath.ReadInt("Geben Sie den Wert von x ein: ");
                    int y = MyMath.ReadInt("Geben Sie den Wert von y ein: ");
                    MyMath.Swap(ref x, ref y);
                    Console.WriteLine($"Nach dem Swap: x = {x}, y = {y}");
                    Console.WriteLine("");

                }
                else if (choice == 6)
                {
                    int count = MyMath.ReadInt("Geben Sie die Anzahl der Zahlen ein: ");
                    int[] numbers = MyMath.ReadNumber(count);
                    MyMath.ReverseArray(numbers);

                    Console.Write("Array nach der Umkehr: ");
                    foreach (int num in numbers)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine("");
                }


                else if (choice == 7)
                {
                    Console.WriteLine("Programm wird beendet");
                    break;
                }



            }
        }
    }
}



