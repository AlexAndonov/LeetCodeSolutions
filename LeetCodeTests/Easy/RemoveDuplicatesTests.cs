using LeetCodeLib.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Easy
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);
            int expected = 5;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 1, 1, 2, 2, 3, 3, 4, 5, 6, 7, 7, 7, 8, 8, 8, 8, 8, 9 };
            int result = RemoveDuplicatesFromSortedArray.Solve(nums);
            int expected = 9;

            Assert.Equal(result, expected);
        }
    }
}
