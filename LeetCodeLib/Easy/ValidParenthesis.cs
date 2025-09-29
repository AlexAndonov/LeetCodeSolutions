using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib.Easy
{
	public static class ValidParenthesis
	{
		public static bool Solve(string s)
		{
			Stack<char> stack = new();

			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];

				if (c == '(' || c == '[' || c == '{')
				{
					stack.Push(s[i]);
				}
				else
				{
					if (stack.Count == 0) return false;
					char top = stack.Pop();

					if (c == ')' && top != '(') return false;
					if (c == ']' && top != '[') return false;
					if (c == '}' && top != '{') return false;
				}
			}

			return stack.Count == 0;
		}
	}
}
