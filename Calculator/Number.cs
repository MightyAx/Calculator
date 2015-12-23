using System;

namespace Calculator
{
	public class Number : IOperand
	{
		private decimal _number;

		public Number (decimal number)
		{
			_number = number;
		}

		#region IOperand implementation

		public decimal GetResult ()
		{
			return _number;
		}

		#endregion
	}
}

