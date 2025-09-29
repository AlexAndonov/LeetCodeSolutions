using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.Medium
{
    public class LengthOfLongestSubstring
    {
        public int LengthOfSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>(); 
            int maxLength = 0; 
            int start = 0; 

            for (int end = 0; end < s.Length; end++)
            {
                
                while (set.Contains(s[end]))
                {
                    set.Remove(s[start]);
                    start++;
                }

                set.Add(s[end]); 
                maxLength = Math.Max(maxLength, end - start + 1); 
            }

            return maxLength;
        }
    }
}
