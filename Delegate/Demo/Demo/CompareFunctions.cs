using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class CompareFunctions
    {
        public static bool CompareGreater(int X, int Y)
        {
            return X > Y;
        }

        public static bool CompareLess(int X, int Y)
        {
            return X < Y;
        }

        public static bool CompareStringGreater(string str1 , string str2)
        {
            return str1?.Length > str2?.Length;
        }

        public static bool CompareStringLess(string str1, string str2)
        {
            return str1?.Length < str2?.Length;
        }
    }
}
