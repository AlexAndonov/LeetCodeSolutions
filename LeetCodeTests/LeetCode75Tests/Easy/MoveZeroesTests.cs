using LeetCodeLib.LeetCode75.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode75Tests.Easy
{
    public class MoveZeroesTests
    {
        [Fact]
        public void Test1()
        {
            int[] arr = [0, 1, 0, 3, 12];
            int[] expected = [1, 3, 12, 0, 0];
            int[] result = MoveZeroes.Solve(arr);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test2()
        {
            int[] arr = [0, 0, 2, 3, 0, 12, 0, 5, 46, 0, 0, 128];
            int[] expected = [2, 3, 12, 5, 46, 128, 0, 0, 0, 0, 0, 0];
            int[] result = MoveZeroes.Solve(arr);

            Assert.Equal(expected, result);
        }
    }
}
