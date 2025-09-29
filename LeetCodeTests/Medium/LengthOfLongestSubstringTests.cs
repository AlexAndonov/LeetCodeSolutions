using LeetCodeLib.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Medium
{
	public class LengthOfLongestSubstringTests
	{
		[Fact]
		public void Test1()
		{
			string input = "abcabcbb";
			int result = LengthOfLongestSubstring.Solve(input);
			int expected = 3;

			Assert.Equal(expected, result);
		}
	}
}
