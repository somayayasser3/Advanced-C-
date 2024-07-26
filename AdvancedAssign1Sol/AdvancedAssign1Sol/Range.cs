using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAssign1Sol
{
    internal class Range<T> where T : IComparable
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) >= 0) throw new Exception("Minimum Must be Less Than Maximum Value");

            Minimum = minimum;
            Maximum = maximum;
        }

        public bool InRange(T Value)
        {
            return (Minimum.CompareTo(Value) <= 0) && (Maximum.CompareTo(Value) >= 0);
        }

        public dynamic Length()
        {
            return ( (dynamic)Maximum - (dynamic)Minimum );
            // Dynamic to Be Fit for int or double Data Type
        }

        public override string ToString()
        {
            return $"Min = {Minimum} , Maximum = {Maximum}";
        }
    }
}
