using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.LeetCode75.Easy
{
    public static class UniqueNumberOfOccurences
    {
        public static bool Solve(int[] arr)
        {
            Dictionary<int, int> occurences = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (occurences.ContainsKey(num))
                {
                    occurences[num]++;
                }
                else
                {
                    occurences[num] = 1;
                }
            }

            HashSet<int> seen = new HashSet<int>();

            foreach (int i in occurences.Values)
            {
                if (!seen.Add(i))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
