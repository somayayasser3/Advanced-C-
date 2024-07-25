using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X = {X} \n Y = {Y}";
        }

        public int CompareTo(Point other)
        {
            //Point 
            //Object from Class Inherit from Point
            if (other is null) return 1;
            if (X == other.X)
                return Y.CompareTo(other.Y);
            else
                return X.CompareTo(other.X);
        }

        //    public int CompareTo(object obj)
        //    {
        //        if (obj is Point PassedPoint)
        //        {
        //            if (this.X == PassedPoint.X)
        //            {
        //                return (this.Y.CompareTo(PassedPoint.Y));
        //            }
        //            else
        //                return (this.X.CompareTo(PassedPoint.X));
        //        }
        //        else
        //            return 1;
        //    }
        //}

    }
}
