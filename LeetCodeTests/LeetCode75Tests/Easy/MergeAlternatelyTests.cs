using LeetCodeLib.LeetCode75.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode75Tests.Easy
{
    public class MergeAlternatelyTests
    {
        [Fact]
        public void Test1()
        {
            string word1 = "abc";
            string word2 = "pqr";

            string expected = "apbqcr";
            string actual = MergeAlternately.Solve(word1, word2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string word1 = "ab";
            string word2 = "pqrs";

            string expected = "apbqrs";
            string actual = MergeAlternately.Solve(word1, word2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string word1 = "abcd";
            string word2 = "pq";

            string expected = "apbqcd";
            string actual = MergeAlternately.Solve(word1, word2);

            Assert.Equal(expected, actual);
        }
    }
}
