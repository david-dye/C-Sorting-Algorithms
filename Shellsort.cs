using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Test_Shell_Sort
{
    class Shellsort : SortCLS, ISort //Shellsort uses the ISort interface
    {
        public int[] Sort(int[] array)
        {
            //Use the private class method to make an array of gaps
            int[] gaps = CreateGaps(array);
            int[] newArray = new int[array.Length];
            //make a replica of given array
            array.CopyTo(newArray, 0);
            //go through each gap, which gets smaller each iteration
            foreach(int gap in gaps)
            {
                for(int i = gap; i < newArray.Length; i++)
                {
                    int temp = newArray[i];
                    int j;
                    //go through the array, and for every value that is bigger than the temp variable gets swapped with the temp variable
                    for(j = i; j >= gap && temp < newArray[j-gap]; j-=gap)
                    {
                        Comparisons++;
                        newArray[j] = newArray[j - gap];
                    }
                    //the new temp variable is the one that we switched with
                    newArray[j] = temp;
                }
            }
            return newArray;
        }

        private int[] CreateGaps(int[] array)
        {
            int gapNum = (int) Math.Log(array.Length, 2) - 2; //Subtracting 2 bc theres still a couple too many numbers
            //Create an empty array of length gapNum
            int[] gaps = new int[gapNum];
            for(int i = 1; i < gapNum + 1; i++)
            {
                //Use the series 2^i - 1 to populate the gap array in decreasing order
                int x = ((int)Math.Pow(2, i)) - 1;
                int index = gapNum - i;
                gaps[index] = x;
            }
            //gaps will have the number of gaps that produces O(N^3/2) according to Wikipedia
            return gaps;
        }
    }
}
