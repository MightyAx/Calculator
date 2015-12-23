using System;

namespace Calculator
{
	public class Function : IOperand
	{
		public Function (IOperand lhs, Operator op, IOperand rhs)
		{
			LeftHandSide = lhs;
			Operator = op;
			RightHandSide = rhs;
		}

		#region IOperand implementation

		public decimal GetResult ()
		{
			throw new NotImplementedException ();
		}

		#endregion

		public IOperand LeftHandSide { get; private set;}

		public Operator Operator { get; private set;}

		public IOperand RightHandSide { get; private set;}
	}

	public enum Operator
	{
		divide,
		multiply,
		add,
		subtract,
	}
}

