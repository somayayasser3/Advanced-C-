using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced_Assign2
{
    internal class FixedSizeList<T>
    {


        public int Capacity { get; set; }
        public T [] Elements { get; set; }
        public int LastIndex;

        public FixedSizeList(int capacity)
        {
            if(capacity <= 0)
            {
                throw new Exception("Capacity Must Be Greater Than Zero.");
            }
            Capacity = capacity;
            Elements = new T [capacity];
            LastIndex = 0;
        }

        public void Add(T Element)
        {
            if (LastIndex >= Capacity)
                throw new Exception("The List Is Already Full.");
            Elements[LastIndex] = Element;
            LastIndex++;
        }

        public T Get(int Index)
        {
            if (Index < 0 || Index > LastIndex)
                throw new IndexOutOfRangeException("This Index is Invalid.[Not In Range]");
            return Elements[Index];
        }
    }
}
