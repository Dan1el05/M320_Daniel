using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungsaufgabe_1
{
    internal class MyMath
    {

        //Methode zum Berechnen vom ggT
        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        //Methode zum Berechnen vom kgV
       public static int Calc_kgV(int a, int b)
       {
            int gcd = Calc_ggT(a, b);
            return a * b / gcd;
        }
        //Berechnen vom ggT rekursiv
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
          return Calc_ggT(b, a%b);

        }

        //Methode zum Einlesen Von Ganzen Zahlen
        public static int ReadInt(string promt)
        {
            Console.WriteLine(promt);
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
            }
        }

        //Methode zum anzeigen vom Resultat
        public static void ShowResult(string operation, int a, int b, int result) 
        {
            Console.WriteLine($"{operation} von {a} und {b} ist {result}");
        }

        internal static int Calc_ggT(int a, object b)
        {
            throw new NotImplementedException();
        }

        //Methode zum Berechnen vom arithmetischer Mittelwert
        public static double CalculateMean(int[] numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        //Berechnen vom kleinsten Wert
        public static int FindMinValue(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        //Berechnen vom grössten Wert
        public static int FindMaxValue(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        //Methode zum einlesen von Zahlen in das Array numbers
        public static int[] ReadNumber(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Geben Sie Zahl {i + 1} ein: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
        //Vertauscht den Inhalt von Zwei übergebenen Zahlen
        public static int Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return temp;
        }
        //Funktion zum umkehren von einem Array
        public static void ReverseArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                Swap(ref array[left], ref array[right]);
                left++;
                right--;

            }
        }

    }

 
    
}
