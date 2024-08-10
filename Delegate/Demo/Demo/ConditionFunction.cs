using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class ConditionFunction
    {
        public static bool CheckOdd(int Num)
        {
            return Num % 2 != 0;
        }

        public static bool CheckEven(int Num)
        {
            return Num % 2 == 0;
        }

        public static bool CheckDivisibleBySeven(int Num)
        {
            return Num % 7 == 0;
        }

        public static bool CheckDivisibleByTen(int Num)
        {
            return Num % 10 == 0;
        }

        public static bool CheckStringLength(string Word)
        {
            return Word?.Length > 4;
        }
    }
}
