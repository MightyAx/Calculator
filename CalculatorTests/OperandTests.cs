using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture ()]
	public class OperandTests
	{
		[Test]
		[TestCase (UInt32.MinValue)]
		[TestCase (UInt32.MaxValue)]
		public void NumberBoundryTest (UInt32 testInput)
		{
			IOperand testOpp = new Number ((decimal)testInput);
			Assert.AreEqual (testInput, testOpp.GetResult());
		}
	}
}

