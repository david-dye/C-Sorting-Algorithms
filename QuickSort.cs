using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace C_Sharp_Test_Shell_Sort
{
    class QuickSort : SortCLS, ISort
    {
        public int[] Sort(int[] array)
        {
            //copy the given array into a new array
            int[] newArray = new int[array.Length];
            array.CopyTo(newArray, 0);
            MainSort(newArray, 0, newArray.Length - 1);
            return newArray;
        }

        private void MainSort(int[] array, int lowIndex, int highIndex)
        {
            //this is the recursive break condition
            if(lowIndex < highIndex)
            {
                Comparisons++;
                //Take everything that is less than a value and put it on one side of the partition, and save the partition's index
                int part = Partition(array, lowIndex, highIndex);
                //Now sort the left half of the array
                MainSort(array, lowIndex, part - 1);
                //Now sort the right half of the array
                MainSort(array, part + 1, highIndex);
            }
        }

        private int Partition(int[] array, int lowIndex, int highIndex)
        {
            //things bigger than the pivot will be moved to the right of it
            int pivot = array[highIndex];
            //loop will start at the lowIndex
            int index = lowIndex;
            for(int i = lowIndex; i < highIndex; i++)
            {
                //if a value is less than the pivot, swap the index value with the current value
                //ex: (8, 5, 3), 3 would be the pivot, and, since 8 is less than 3, when we get to 5 the 8 and 5 will swap.
                if(array[i] < pivot)
                {
                    Comparisons++;
                    int temp = array[index];
                    array[index] = array[i];
                    array[i] = temp;
                    index++;
                }
            }
            //Now the pivot (highIndex) is smaller than everything to the left of it up to the last index value
            //Therefore, we swap the pivot and the index value.
            int temp2 = array[index];
            array[index] = array[highIndex];
            array[highIndex] = temp2;
            //Return the index where everything to the left is smaller than what the highest value was
            return index;
        }
    }
}
