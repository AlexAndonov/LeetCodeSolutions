using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.LeetCode75.Easy
{
    public static class PivotIndex
    {
        public static int Solve(int[] nums)
        {
            int sumRight = nums.Sum();
            int sumLeft = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumRight -= nums[i];

                if (sumLeft == sumRight)
                {
                    return i;
                }

                sumLeft += nums[i];
            }

            return -1;
        }
    }
}
