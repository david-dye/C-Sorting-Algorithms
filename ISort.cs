using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace C_Sharp_Test_Shell_Sort
{
    public interface ISort
    {
        public int[] Sort(int[] array); //Returns an array of sorted values
        public int Comparisons
        {
            //Returns the number of comparisons the algorithm has done
            get;
        }
    }
}
