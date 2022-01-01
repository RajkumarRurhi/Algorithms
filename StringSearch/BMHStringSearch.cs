using System;
using System.Collections.Generic;
using System.Text;

namespace StringSearch
{
    //Boyer Moore Horspool string search
    internal class BMHStringSearch
    {
        public int CompCount { get; private set; }
        public int FindFirstIndex(string ToBeSearched, string SearchText)
        {
            BadMatchTable badMatchTable = new BadMatchTable(SearchText);
            
            int searchTextLngth = SearchText.Length;
            int i = searchTextLngth - 1;
            int m, n;
            int slideCount;
            while (i < ToBeSearched.Length)
            {
                if(ToBeSearched[i] == SearchText[searchTextLngth - 1])
                {
                    m = i - 1;
                    n = searchTextLngth - 2;
                    while(n >= 0)
                    {
                        if(ToBeSearched[m] == SearchText[n])
                        {
                            m--; 
                            n--;
                        }
                        else
                        {
                            slideCount = badMatchTable[ToBeSearched[m]];
                            i += slideCount;
                            break;
                        }
                        CompCount++;
                    }

                    if(n == -1)
                    {
                        return i - searchTextLngth + 1;
                    }
                }
                else
                {
                    slideCount = badMatchTable[ToBeSearched[i]];
                    i += slideCount;
                }

                CompCount++;
            }

            return -1;
        }
    }
}
