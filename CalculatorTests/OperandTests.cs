using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture ()]
	public class OperandTests
	{
		[Test]
		[TestCase (0U)]
		[TestCase (4294967295U)]
		public void OperandBoundryTest (uint testInput)
		{
			IOperand testOpp = new Number (testInput);
			Assert.AreEqual (testInput, testOpp.GetResult());
		}
	}
}

