using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal abstract class ASort<T> where T :IComparable
    {
        public abstract void Sort(T[] Items);
        public int CompareCount { get; protected set; }
        public int SwapCount { get; protected set; }

    }
}
