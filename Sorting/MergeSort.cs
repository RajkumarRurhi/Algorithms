using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class MergeSort<T> : ASort<T> where T : IComparable
    {
        public override void Sort(T[] Items)
        {
            T[][] tmpMatrix = new T[Items.Length][];
            for (int i = 0; i < Items.Length; i++)
            {
                tmpMatrix[i] = new T[1];
                tmpMatrix[i][0] = Items[i];
            }

            while (tmpMatrix.Length > 1)
            {
                int halfLength = (tmpMatrix.Length % 2 > 0) ? (tmpMatrix.Length / 2) + 1 : (tmpMatrix.Length / 2);
                T[][] tmpMatrix2 = new T[halfLength][];

                for (int i = 0; i < halfLength; i++)
                {
                    if (((i * 2) + 1) == tmpMatrix.Length)
                    {
                        tmpMatrix2[i] = new T[tmpMatrix[(i * 2)].Length];
                        tmpMatrix2[i] = tmpMatrix[(i * 2)];
                    }
                    else
                    {
                        tmpMatrix2[i] = Merge(tmpMatrix[i * 2], tmpMatrix[(i * 2) + 1]);
                    }
                }

                tmpMatrix = tmpMatrix2;
            }

            tmpMatrix[0].CopyTo(Items, 0);
        }

        private T[] Merge(T[] ts1, T[] ts2)
        {
            T[] tmpArray = new T[ts1.Length + ts2.Length];

            int i = 0, j = 0, n = 0;

            while(i < ts1.Length && j < ts2.Length)
            {
                if(ts1[i].CompareTo(ts2[j]) > 0)
                {
                    tmpArray[n] = ts2[j];
                    SwapCount++;
                    j++;
                }
                else
                {
                    tmpArray[n] = ts1[i];
                    i++;
                }
                n++;
                CompareCount++;
            }

            for (; i < ts1.Length; i++)
            {
                tmpArray[n] = ts1[i];
                n++;
            }

            for (; j < ts2.Length; j++)
            {
                tmpArray[n] = ts2[j];
                n++;
            }

            return tmpArray;
        }
    }
}
