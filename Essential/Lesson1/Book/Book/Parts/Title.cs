using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Title
    {
        string field;
        public string Field
        {
            set { field = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(field);
        }
}
}
