using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class BubbleSort<T> where T :IComparable
    {
        public void Sort(T[] Items)
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < Items.Length - 1; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) > 0)
                    {
                        T tmp = Items[i];
                        Items[i] = Items[i + 1];
                        Items[i + 1] = tmp;
                        swap = true;
                    }
                }
            }
        }
    }
}
