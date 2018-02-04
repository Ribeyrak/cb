//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace PoligonPerimeter
{
    class Point
    {
        int a, b;
        string field;

        public int A
        {
            get { return a; }
        }

        public int B
        {
            get { return b; }
        }

        public string Field
        {
            get { return field; }
        }

        public Point(int a, int b, string field)
        {
            this.a = a;
            this.b = b;
            this.field = field;
        }
    }
}
