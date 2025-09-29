using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.Easy
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int Solve(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int j = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[j] = arr[i];
                    j++;
                }
            }

            return j;

            //if (arr.Length == 0) return 0;

            //int j = 1; 
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] != arr[i - 1])
            //    {
            //        arr[j] = arr[i];
            //        j++;
            //    }
            //}

            //return j;
        }
    }
}
