using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = GenerateAndPrintArray(r);

            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            bubbleSort.Sort(array);
            Console.WriteLine("\n\n-------- Sorted Arrary using bubble sort -------------");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\n\n****************************************************************\n\n");

            int[] array2 = GenerateAndPrintArray(r);
            InsertionSort<int> insertionSort = new InsertionSort<int>();
            insertionSort.Sort(array2);
            Console.WriteLine("\n\n-------- Sorted Arrary using insertion sort -------------");
            foreach (int i in array2)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }

        private static int[] GenerateAndPrintArray(Random r)
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = r.Next(0, 1000);
            }
            Console.WriteLine("-------- Unsorted Arrary ------------- ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }

            return array;
        }
    }
}
