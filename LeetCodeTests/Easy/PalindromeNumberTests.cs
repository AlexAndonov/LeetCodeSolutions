using LeetCodeLib.Easy;

namespace LeetCodeTests.Easy
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(PalindromeNumber.IsPalindrome(121));
            Assert.False(PalindromeNumber.IsPalindrome(-121));
            Assert.False(PalindromeNumber.IsPalindrome(10));
            Assert.True(PalindromeNumber.IsPalindrome(0));
        }
    }
}
