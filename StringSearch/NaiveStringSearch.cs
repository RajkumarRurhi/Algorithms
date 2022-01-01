using System;
using System.Collections.Generic;
using System.Text;

namespace StringSearch
{
    internal class NaiveStringSearch
    {
        public int CompCount { get; private set; }
        public int FindFirstIndex(string ToBeSearched, string searchText)
        {
            int length = ToBeSearched.Length;
            int matchCount;

            for(int i = 0; i < length; i++)
            {
                matchCount = 0;
                while(ToBeSearched[i + matchCount] == searchText[matchCount])
                {
                    matchCount++;
                    if(matchCount == searchText.Length)
                    {
                        return i;
                    }
                    CompCount++;
                }
                CompCount++;
            }
            return -1;
        }
    }
}
