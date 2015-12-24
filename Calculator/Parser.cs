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
			var list = new List<string> ();
			while(equation.Contains("/") || equation.Contains("*") || equation.Contains("+") || equation.Contains("-"))
			{
				int operandIndex = equation.IndexOfAny (new char[]{ '/', '*', '+', '-' });
				list.Add (equation.Substring (0, operandIndex));
				list.Add (equation.Substring (operandIndex, 1));
				equation = equation.Remove (0, operandIndex + 1);
			}
			list.Add (equation);
			return list;
		}
	}
}

