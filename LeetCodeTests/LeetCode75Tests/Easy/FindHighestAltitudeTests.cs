using LeetCodeLib.LeetCode75.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode75Tests.Easy
{
    public class FindHighestAltitudeTests
    {
        [Fact]
        public void Test1()
        {
            int[] gain = [-5, 1, 5, 0, -7];
            int result = FindTheHighestAltitude.Solve(gain);
            int actual = 1;
            Assert.Equal(actual, result);
        }

        [Fact]
        public void Test2()
        {
            int[] gain = [44, 32, -9, 52, 23, -50, 50, 33, -84, 47, -14, 84, 36, -62, 37, 81, -36, -85, -39, 67, -63, 64, -47, 95, 91, -40, 65, 67, 92, -28, 97, 100, 81];
            int result = FindTheHighestAltitude.Solve(gain);
            int actual = 781;
            Assert.Equal(actual, result);
        }
    }
}
