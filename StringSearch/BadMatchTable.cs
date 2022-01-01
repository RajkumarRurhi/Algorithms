using System;
using System.Collections.Generic;
using System.Text;

namespace StringSearch
{
    internal class BadMatchTable
    {
        readonly int missing;
        readonly Dictionary<char, int> table;

        public BadMatchTable(string searchText)
        {
            missing = searchText.Length;
            table = new Dictionary<char, int>();

            for(int i = 0; i < searchText.Length - 1; i++)
            {
                table[searchText[i]] = searchText.Length - i - 1;
            }
        }

        public int this[char index] => table.GetValueOrDefault(index, missing);
    }
}
