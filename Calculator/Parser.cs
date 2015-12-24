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

		public Operator ParseOperator(string op)
		{
			if (op == "/") {
				return Operator.divide;
			}
			if (op == "*") {
				return Operator.multiply;
			}
			if (op == "+") {
				return Operator.add;
			}
			if (op == "-") {
				return Operator.subtract;
			}
			throw new ArgumentException ("Invalid Operator");
		}

		public List<string> ParseEquation(string equation)
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

		public IOperand ParseList(List<string> components)
		{
			int op = components.FindIndex ((s) => s == "/" || s == "*");
			if (op == -1) {
				components.FindIndex ((s) => s == "+" || s == "-");
			}
			if (op == -1) {
				//return new number
			}
			UInt32 left, right;
			if (UInt32.TryParse(components[op - 1], out left) && UInt32.TryParse(components[op + 1], out right)) {
				Function significantFunction = new Function (new Number (left), ParseOperator (components [op]), new Number (right));
				//add pre and post funtion to create a function.
				return significantFunction;
			}
			throw new InvalidOperationException ();
		}
	}
}

