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
			if (Operator == Operator.divide) {
				return LeftHandSide.GetResult() / RightHandSide.GetResult();
			}
			if (Operator == Operator.multiply) {
				return LeftHandSide.GetResult() * RightHandSide.GetResult();
			}
			if (Operator == Operator.add) {
				return LeftHandSide.GetResult() + RightHandSide.GetResult();
			}
			if (Operator == Operator.subtract) {
				return LeftHandSide.GetResult() - RightHandSide.GetResult();
			}
			throw new ArithmeticException ();
		}

		#endregion

		public IOperand LeftHandSide { get; private set;}

		public Operator Operator { get; private set;}

		public IOperand RightHandSide { get; private set;}
	}

}

