using System;

namespace Test_First_dki_cma
{
    public class StringCalculator
    {
        public int CalledCount { get; set; }
        public int Add(string numbers)
        {
            if (numbers == null) { return 0; }

            // Teile den Eingabestring anhand der Trennzeichen (Komma, Semikolon, etc.)
            // und konvertiere die Teilstrings in Zahlen
            string[] numberArray = numbers.Split(new char[] { ',', ';', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialisiere die Summe auf 0
            int sum = 0;

            // Iteriere durch die Zahlen und addiere sie zur Summe, wenn sie kleiner als 1000 sind
            foreach (var number in numberArray)
            {
                if (int.TryParse(number, out int num))
                {
                    // Überprüfen, ob eine Zahl kleiner als Null ist
                    if (num < 0)
                    {
                        Console.WriteLine($"Negatives not allowed: {num}");
                        return 0;
                    }

                    if (num < 1000)
                    {
                        sum += num;
                        CalledCount++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Calculation was unsuccessful");
                    return 0;
                }
            }

            // Gib die Summe zurück
            return sum;
        }
    }
}
