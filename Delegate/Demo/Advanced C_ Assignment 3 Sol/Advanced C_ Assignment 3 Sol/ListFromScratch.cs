using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__Assignment_3_Sol
{
    internal class ListFromScratch<T>
    {
        public T [] Items { get; set; }
        public int Count { get; set; }

        public ListFromScratch()
        {
            Items = new T[4]; 
            Count = 0;
        }

        public void CheckCapacity()
        {
            if (Count >= Items.Length)
            {
                T[] newArray = new T[Items.Length * 2];
                Array.Copy(Items, newArray, Items.Length);
                Items = newArray;
            }
        }

        public void Add(T Item)
        {
            CheckCapacity();
            Items[Count++] = Item;
        }

        public bool Exist(Predicate<T> predicate)
        {
            if (Items != null)
            {
                foreach (T item in Items)
                {
                    if (predicate(item))
                        return true;
                }
            }
            return false;
        }

        public T Find(Predicate<T> predicate)
        {
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    if (predicate(item))
                    {
                        return item;
                    }
                }
            }
            return default(T);
        }

        public List<T> FindAll(Predicate<T> predicate)
        {
            List<T> Res = new List<T>();
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    if (predicate(item))
                    {
                        Res.Add(item);
                    }
                }
            }
            return Res;
        }

        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < Count; i++)
            {
                if (predicate(Items[i]))
                {
                    return i;
                }
            }
            return -1; 
        }

        public T FindLast(Predicate<T> predicate)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (predicate(Items[i]))
                {
                    return Items[i];
                }
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> predicate)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (predicate(Items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(Items[i]);
            }
        }

        public bool TrueForAll(Predicate<T> predicate)
        {
            for (int i = 0; i < Count; i++)
            {
                if (!predicate(Items[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
