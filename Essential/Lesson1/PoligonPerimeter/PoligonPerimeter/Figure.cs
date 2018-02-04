
using System;

namespace PoligonPerimeter
{
    class Figure
    {
        double LengthSide(Point A, Point B)
        {
            return
        }

        void PerimeterCalculator()
        {
          
        }

        private Point[] point;

        private string type;
        public string Type
        {
            get { return type; }
        }
        
        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point [3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            type = "Triangle";

        }
    }
}
