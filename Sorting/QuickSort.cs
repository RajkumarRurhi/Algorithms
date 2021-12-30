using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class QuickSort<T> : ASort<T> where T : IComparable
    {

        public override void Sort(T[] Items)
        {
            Random r = new Random();
            DivideAndSort(Items, r);
        }

        private void DivideAndSort(T[] Items, Random r)
        {
            if(Items == null || Items.Length <= 1)
            {
                return;
            }

            int pivotIndex = r.Next(Items.Length - 1);
            T pivotValue = Items[pivotIndex];

            int i = 0;
            int movedCount = 0;
            while (i < pivotIndex)
            {
                if (Items[i].CompareTo(pivotValue) > 0)
                {
                    MoveItemRight(Items, i);
                    SwapCount++;
                    movedCount++;
                    pivotIndex--;
                }
                else
                {
                    i++;
                }
                CompareCount++;
            }

            int j = Items.Length - 1 - movedCount;
            while (j > pivotIndex)
            {
                if (Items[j].CompareTo(pivotValue) < 0)
                {
                    MoveItemLeft(Items, j);
                    SwapCount++;
                    pivotIndex++;
                }
                else
                {
                    j--;
                }
                CompareCount++;
            }

            T[] tmpArray1 = null;
            T[] tmpArray2 = null;

            if(pivotIndex > 0)
            {
                tmpArray1 = new T[pivotIndex];
            }

            for(int n = 0; n < pivotIndex; n++)
            {
                tmpArray1[n] = Items[n];
            }
            DivideAndSort(tmpArray1, r);

            if(pivotIndex < Items.Length - 1)
            {
                tmpArray2 = new T[Items.Length - pivotIndex - 1];
            }

            int tmpLength = Items.Length - pivotIndex - 1;
            for (int m = 0; m < tmpLength; m++)
            {
                tmpArray2[m] = Items[pivotIndex + m + 1];
            }
            DivideAndSort(tmpArray2, r);

            T[] tmpArray = new T[Items.Length];

            int firstArrayLength = 0;
            if (tmpArray1 != null && tmpArray1.Length > 0)
            {
                firstArrayLength = tmpArray1.Length;
                tmpArray1.CopyTo(tmpArray, 0);
            }

            tmpArray[firstArrayLength] = pivotValue;

            if (tmpArray2 != null && tmpArray2.Length > 0)
            {
                tmpArray2.CopyTo(tmpArray, firstArrayLength + 1);
            }

            tmpArray.CopyTo(Items, 0);
        }

        private void MoveItemLeft(T[] items, int index)
        {
            T tmpItem = items[index];

            for(int i = index; i > 0; i--)
            {
                items[i] = items[i - 1];
            }
            items[0] = tmpItem;
        }

        private void MoveItemRight(T[] items, int index)
        {
            T tmpItem = items[index];

            for(int i = index; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            items[items.Length - 1] = tmpItem;
        }
    }
}
