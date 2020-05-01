using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Test_Shell_Sort
{
    class SortCLS
    {
        public int Comparisons
        {
            get;
            protected set;
        }

        public bool CheckSorted(int[] array)
        {
            //Test if the array is sorted in ascending order
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] < array[i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
