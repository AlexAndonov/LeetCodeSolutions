using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.Medium
{
    public class MaximumNumberOfVowels
    {
        public static int Solve(string s, int k)
        {
            int currentCount = 0;

            for (int i = 0; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    currentCount++;
                }
            }

            int max = currentCount;

            for (int i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i]))
                {
                    currentCount++;
                }

                if (IsVowel(s[i-k]))
                {
                    currentCount--;
                }

                max = Math.Max(max, currentCount);
            }

            return max;
        }

        private static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c =='i' || c == 'o' || c == 'u';
        }
    }
}
