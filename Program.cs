using System;

namespace C_Sharp_Test_Shell_Sort
{
    class Program
    {
        static void Main()
        {
            //Create an array of unsorted integers
            int[] unsorted = new int[1000];
            for (int i = 0; i < unsorted.Length; i++)
            {
                Random rand = new Random();
                unsorted[i] = rand.Next(0, 1000);
            }

            //Creates a sort object from a sorting class that can sort integer arrays
            QuickSort sorter = new QuickSort();

            //sort the unsorted array
            int[] sorted = sorter.Sort(unsorted);

            if(sorter.CheckSorted(sorted))
            {
                Console.WriteLine("The array is sorted correctly");
            }
            else
            {
                Console.WriteLine("The array is NOT sorted correctly");
            }

            Console.WriteLine("\nComparisons: " + sorter.Comparisons);
        }
    }
}
