using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class BubbleSort<T> : ASort<T> where T :IComparable
    {
        public override void Sort(T[] Items)
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                int tmpLength = Items.Length - 1;
                for (int i = 0; i < tmpLength; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) > 0)
                    {
                        T tmp = Items[i];
                        Items[i] = Items[i + 1];
                        Items[i + 1] = tmp;
                        swap = true;
                        SwapCount++;
                    }
                    CompareCount++;
                }
            }
        }
    }
}
