using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.LeetCode75.Easy
{
    public static class MaximumAverageSubarray
    {
        public static double Solve(int[] nums, int k)
        {
            double sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            double max = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i];
                sum -= nums[i - k];

                if (sum > max)
                {
                    max = sum;
                }
            }

            return max / k;
        }
    }
}
