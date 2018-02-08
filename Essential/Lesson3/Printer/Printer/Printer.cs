using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Printer
    {
        ConsoleColor color;

        public Printer(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            //Console.ForegroundColor = ConsoleColor.Gray;
        }

        
    }
}
