using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class InsertionSort<T> : ASort<T> where T : IComparable
    {
        public override void Sort(T[] Items)
        {
            int i = 1;
            while (i < Items.Length)
            {
                int targetIndex = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Items[i].CompareTo(Items[j]) < 0)
                    {
                        targetIndex = j;
                        if (j == 0)
                        {
                            targetIndex = 0;
                        }
                    }
                    CompareCount++;
                }

                if (targetIndex >= 0)
                {
                    Swap(Items, i, targetIndex);
                    SwapCount++;
                }

                i++;
            }
        }

        private void Swap(T[] items, int orgIndex, int newIndex)
        {
            T tmp = items[orgIndex];
            for(int i = orgIndex; i > newIndex; i--)
            {
                if(i > 0)
                {
                    items[i] = items[i - 1];
                }
            }
            items[newIndex] = tmp;
        }
    }
}
