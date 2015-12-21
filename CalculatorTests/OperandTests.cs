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
			Operand testOpp = new Operand (testInput);
			Assert.AreEqual (testInput, testOpp.GetResult());
		}

		[Test, ExpectedException(typeof(ArgumentNullException))]
		public void OperandNullTest ()
		{
			Operand testOpp = new Operand ();
			testOpp.GetResult ();
		}
	}
}

