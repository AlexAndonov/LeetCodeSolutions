using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.LeetCode75.Easy
{
    public static class FindTheHighestAltitude
    {
        public static int Solve(int[] gain)
        {
            int highest = 0;
            int current = highest;

            for (int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                if (current > highest)
                {
                    highest = current;
                }
            }

            return highest;
        }
    }
}
