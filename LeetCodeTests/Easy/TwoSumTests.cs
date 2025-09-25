using LeetCodeLib.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Easy
{
    public class TwoSumTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };
            int[] result = TwoSum.Solve(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 3, 4, 5, 9, 3 };
            int target = 6;
            int[] expected = { 0, 4 };
            int[] result = TwoSum.Solve(nums, target);

            Assert.Equal(expected, result);
        }
    }
}
