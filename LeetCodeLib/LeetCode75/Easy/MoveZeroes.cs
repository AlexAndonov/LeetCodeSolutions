using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.LeetCode75.Easy
{
    public static class MoveZeroes
    {
        public static int[] Solve(int[] nums)
        {
            int slow = 0;

            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            for (int i = slow; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
