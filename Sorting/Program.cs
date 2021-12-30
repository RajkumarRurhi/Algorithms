using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = GenerateAndPrintArray(r);
            int[] array2 = new int[array.Length];
            int[] array3 = new int[array.Length];
            int[] array4 = new int[array.Length];

            array.CopyTo(array2, 0);
            array.CopyTo(array3, 0);
            array.CopyTo(array4, 0);

            ASort<int> bubbleSort = new BubbleSort<int>();
            bubbleSort.Sort(array);
            Console.WriteLine("\n\n-------- Sorted Arrary using bubble sort -------------");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\n Compare Count : {bubbleSort.CompareCount}");
            Console.WriteLine($" Swap Count : {bubbleSort.SwapCount}");

            Console.WriteLine("\n\n\n****************************************************************");

            ASort<int> insertionSort = new InsertionSort<int>();
            insertionSort.Sort(array2);
            Console.WriteLine("\n\n-------- Sorted Arrary using insertion sort -------------");
            foreach (int i in array2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\n Compare Count : {insertionSort.CompareCount}");
            Console.WriteLine($" Swap Count : {insertionSort.SwapCount}");

            Console.WriteLine("\n\n\n****************************************************************");

            ASort<int> mergeSort = new MergeSort<int>();
            mergeSort.Sort(array3);
            Console.WriteLine("\n\n-------- Sorted Arrary using merge sort -------------");
            foreach (int i in array3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\n Compare Count : {mergeSort.CompareCount}");
            Console.WriteLine($" Swap Count : {mergeSort.SwapCount}");

            Console.WriteLine("\n\n\n****************************************************************");

            ASort<int> quickSort = new QuickSort<int>();
            quickSort.Sort(array4);
            Console.WriteLine("\n\n-------- Sorted Arrary using quick sort -------------");
            foreach (int i in array4)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\n Compare Count : {quickSort.CompareCount}");
            Console.WriteLine($" Swap Count : {quickSort.SwapCount}");

            Console.ReadLine();
        }

        private static int[] GenerateAndPrintArray(Random r)
        {
            int itemsCount = 100;
            int[] array = new int[itemsCount];
            for (int i = 0; i < itemsCount; i++)
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
