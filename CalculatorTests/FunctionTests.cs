using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture ()]
	public class FunctionTests
	{
		[Test, TestCase(5U, 9U)]
		public void FunctionSavesOperands (uint leftHandSide, uint rightHandSide )
		{
			IOperand lhs = new Number (leftHandSide);
			IOperand rhs = new Number (rightHandSide);
			Function testFunc = new Function (lhs, Operator.add, rhs);
			Assert.AreEqual (leftHandSide, testFunc.LeftHandSide.GetResult());
			Assert.AreEqual (rightHandSide, testFunc.RightHandSide.GetResult());
		}

		[Test]
		[TestCase(Operator.divide)]
		[TestCase(Operator.multiply)]
		[TestCase(Operator.add)]
		[TestCase(Operator.subtract)]
		public void FunctionSavesOperator (Operator testOp)
		{
			IOperand leftHandSide = new Number(5);
			IOperand rightHandSide = new Number(9);
			Function testFunc = new Function (leftHandSide, testOp, rightHandSide);
			Assert.AreEqual (testOp, testFunc.Operator);
		}

		[Test]
		[TestCase(5U, Operator.divide, 2U, Result = (5U / 2U))]
		[TestCase(7U, Operator.multiply, 2U, Result = (7U * 2U))]
		[TestCase(5U, Operator.add, 2U, Result = (5U + 2U))]
		[TestCase(4U, Operator.subtract, 1U, Result = (4U - 1U))]
		public decimal FunctionCanCalculate (uint lhs, Operator op, uint rhs)
		{
			Function func = new Function (new Number(lhs), op, new Number(rhs));
			return func.GetResult ();
		}
	}
}

