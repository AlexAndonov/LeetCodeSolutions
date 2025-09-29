using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.Medium
{
    public static class LengthOfLongestSubstring
    {
        public static int Solve(string s)
        {
            HashSet<char> charSet = new();
            int left = 0;
            int right = 0;
            int maxLength = 0;

            while(right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
		}
    }
}
