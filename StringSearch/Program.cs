using System;

namespace StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstOccuranceIndex;

            string sourceString = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            string searchText = "essentially";

            NaiveStringSearch naiveStringSearch = new NaiveStringSearch();
            firstOccuranceIndex = naiveStringSearch.FindFirstIndex(sourceString, searchText);
            Console.WriteLine($"First Occured Index : {firstOccuranceIndex}");
            Console.WriteLine($"Naive search comparision count: {naiveStringSearch.CompCount}");

            BMHStringSearch bmhStringSearch = new BMHStringSearch();
            firstOccuranceIndex = bmhStringSearch.FindFirstIndex(sourceString, searchText);
            Console.WriteLine($"First Occured Index : {firstOccuranceIndex}");
            Console.WriteLine($"BMH search comparision count: {bmhStringSearch.CompCount}");

            Console.ReadLine();
        }
    }
}
