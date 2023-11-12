using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    public class StringStack
    {

        string[] values;
        int index;

        public StringStack(int size)
        {
            this.values = new string[size];
        }
       public void Push(string value)
        {
            if(IsFull) {
                Console.WriteLine("Der Stack ist voll");
                
            }
            this.values[index++] = value;

        }

        public string Pop() 
        {
            if (IsEmpty)
            {
                return "Es ist das letzte Element";
            }
            index--;
            return this.values[index];
        }

        public string Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack ist leer.");
            }

            return this.values[index];
        }

        public void Swap()
        {
            if (Count < 2)
            {
                throw new InvalidOperationException("Stack hat nicht genügend Elemente zum nehmen.");
            }

            string temp = values[index];
            values[index] = values[index - 1];
            values[index - 1] = temp;
        }

        public void Clear()
        {
            Array.Clear(values, 0, values.Length);
            index = -1;
        }

        public override string ToString()
        {
            return string.Join(", ", values);
        }

        public bool IsEmpty => index == -1;

        public int Count => index + 1;

        public bool IsFull => index == values.Length - 1;



    }
}
