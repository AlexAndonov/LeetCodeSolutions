using LeetCodeLib.LeetCode75.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode75Tests.Easy
{
    public class PivotIndexTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = [1, 7, 3, 6, 5, 6];
            int expected = 3;
            int actual = PivotIndex.Solve(nums);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [1, 2, 3, 4];
            int expected = -1;
            int actual = PivotIndex.Solve(nums);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [2, 1, -1];
            int expected = 0;
            int actual = PivotIndex.Solve(nums);
            Assert.Equal(expected, actual);
        }
    }
}
