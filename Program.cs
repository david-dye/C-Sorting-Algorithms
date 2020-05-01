using System;

namespace C_Sharp_Test_Shell_Sort
{
    class Program
    {
        static void Main()
        {
            //Create an array of unsorted integers
            int[] unsorted = new int[100];
            for (int i = 0; i < unsorted.Length; i++)
            {
                Random rand = new Random();
                unsorted[i] = rand.Next(0, 100);
            }

            //Creates a Shellsort object that can sort integer arrays
            Shellsort shellSorter = new Shellsort();

            //sort the unsorted array
            int[] sorted = shellSorter.Sort(unsorted);

            //Write the before and after sorted arrays
            Console.Write("\n\n Before Sort:\n");
            foreach(int num in unsorted)
            {
                Console.WriteLine(" " + num);
            }
            Console.Write("\n\n After Sort:\n");
            foreach (int num in sorted)
            {
                Console.WriteLine(" " + num);
            }
        }
    }
}
