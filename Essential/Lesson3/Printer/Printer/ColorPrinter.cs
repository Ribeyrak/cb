using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class ColorPrinter : Printer
    {
        public ColorPrinter(ConsoleColor color)
            : base(color)
        {

        }
    }
}
