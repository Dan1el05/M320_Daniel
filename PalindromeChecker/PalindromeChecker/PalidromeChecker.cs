using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    internal class PalidromeChecker
    {
        private GerenicStack<char> stack;
        private char number;

        public void StackEinlesen()
        {
            Console.WriteLine("Geben sie ein Wort ein mit eineelnen buchstaben");
            number = char.Parse(Console.ReadLine());

            switch (number)
            {
                case 'e':
                    Environment.Exit(0);
                    break;
                case 'u':
                    Undo();
                    break;
            }

        public bool IsPalindrome(string value)
        {
            return true;
        }

            private void Undo()
            {
                if (stack.Count > 0)
                {
                    stack.Push(number);
                }
                else
                {
                    Console.WriteLine("Der Stack ist leer");
                }

            }
        }
