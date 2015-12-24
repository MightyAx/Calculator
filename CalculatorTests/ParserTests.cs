using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;

namespace CalculatorTests
{
	[TestFixture ()]
	public class ParserTests
	{
		[Test]
		public void ParserCanMakeList ()
		{
			const string equation = "123+56*2";
			List<string> expectedResult = new List<string>(new string[] { "123", "+", "56", "*", "2"});

			Parser parser = new Parser ();
			List<string> result = parser.ParseEquation (equation);

			Assert.AreEqual (expectedResult.Count, result.Count);
			for (int i = 0; i < expectedResult.Count; i++)
			{
				Assert.AreEqual (expectedResult [i], result [i]);
			}
		}
	}
}

