using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_320
{
    internal class ConsoleLogger : ILogger
{
        public ConsoleLogger(string message)
        {
            Console.WriteLine(message);
        }
}
}
