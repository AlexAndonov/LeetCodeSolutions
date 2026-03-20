using LeetCodeLib.LeetCode75.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode75Tests.Easy
{
    public class UniqueNumberOfOccurencesTests
    {
        [Fact]
        public void Test1()
        {
            int[] arr = [1, 2, 2, 1, 1, 3];
            bool expected = true;
            bool actual = UniqueNumberOfOccurences.Solve(arr);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] arr = [1, 2];
            bool expected = false;
            bool actual = UniqueNumberOfOccurences.Solve(arr);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] arr = [-3, 0, 1, -3, 1, 1, 1, -3, 10, 0];
            bool expected = true;
            bool actual = UniqueNumberOfOccurences.Solve(arr);

            Assert.Equal(expected, actual);
        }
    }
}
