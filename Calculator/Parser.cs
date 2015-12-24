using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
	public class Parser
	{
		const string PATTERN = "^((\\d+[\\+\\-\\*\\/])+\\d+)$";

		public Parser ()
		{
		}

		public List<string> Parse(string equation)
		{
			if (!Regex.IsMatch(equation, PATTERN))
			{
				throw new ArgumentException ("equation");
			}

		}
	}
}

