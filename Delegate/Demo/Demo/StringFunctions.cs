using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperChars(string Name)
        {
            int Count = 0;
            if (Name != null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                        Count++;

                }
            }
            return Count;
        }


        public static int GetCountOfLowerChars(string Name)
        {
            int Count = 0;
            if (Name != null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsLower(Name[i]))
                        Count++;

                }
            }
            return Count;
        }
    }
}
