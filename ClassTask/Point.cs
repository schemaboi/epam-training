using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.HomeWork.ClassTask
{
    public struct Point 
    {   
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public static Point operator+(Point left, Point right)
        {
            return new Point(left.X + right.X, left.Y + right.Y);
        }
    }
}
