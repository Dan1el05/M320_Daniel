using System;

namespace Calculator
{
    class Program
    {
        private static int result = 0; // Interner Zustand zum Speichern des Ergebnisses

        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Bitte wählen Sie eine Operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Beenden");

                int choice = int.Parse(Console.ReadLine()); // Benutzereingabe für die gewünschte Operation

                switch (choice)
                {
                    case 1:
                        Console.Write("Geben Sie den Wert für die Addition ein: ");
                        int addend = int.Parse(Console.ReadLine()); // Benutzereingabe für den Summanden
                        result = PerformOperation(result, addend, Add); // Führt die Addition aus und aktualisiert das Ergebnis
                        Console.WriteLine("Ergebnis: " + result);
                        break;

                    case 2:
                        Console.Write("Geben Sie den Wert für die Subtraktion ein: ");
                        int subtrahend = int.Parse(Console.ReadLine()); // Benutzereingabe für den Subtrahenden
                        result = PerformOperation(result, subtrahend, Subtract); // Führt die Subtraktion aus und aktualisiert das Ergebnis
                        Console.WriteLine("Ergebnis: " + result);
                        break;

                    case 3:
                        Console.Write("Geben Sie den Wert für die Multiplikation ein: ");
                        int multiplier = int.Parse(Console.ReadLine()); // Benutzereingabe für den Multiplikator
                        result = PerformOperation(result, multiplier, Multiply); // Führt die Multiplikation aus und aktualisiert das Ergebnis
                        Console.WriteLine("Ergebnis: " + result);
                        break;

                    case 4:
                        Console.Write("Geben Sie den Wert für die Division ein: ");
                        int divisor = int.Parse(Console.ReadLine()); // Benutzereingabe für den Divisor
                        result = PerformOperation(result, divisor, Divide); // Führt die Division aus und aktualisiert das Ergebnis
                        Console.WriteLine("Ergebnis: " + result);
                        break;

                    case 5:
                        continueCalculating = false; // Beendet die Schleife und das Programm
                        break;

                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                        break;
                }
            }
        }

        // Methode zum Ausführen einer Rechenoperation mit einem Operanden
        public static int PerformOperation(int operand1, int operand2, Func<int, int, int> operation)
        {
            return operation(operand1, operand2);
        }

        // Methoden für die Grundrechenoperationen
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b != 0)
                return a / b; // Führt die Division aus, wenn der Divisor nicht Null ist
            else
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
                return a; // Gibt das unveränderte Ergebnis zurück, wenn der Divisor Null ist
            }
        }
    }
}