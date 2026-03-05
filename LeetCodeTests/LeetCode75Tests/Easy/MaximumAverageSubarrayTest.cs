using LeetCodeLib.LeetCode75.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode75Tests.Easy
{
    public class MaximumAverageSubarrayTest
    {
        [Fact]
        public void Test1()
        {
            int[] arr = [1, 12, -5, -6, 50, 3];
            double expected = 12.75000;
            double actual = MaximumAverageSubarray.Solve(arr, 4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] arr = [5];
            double expected = 5;
            double actual = MaximumAverageSubarray.Solve(arr, 1);

            Assert.Equal(expected, actual);
        }
    }
}
