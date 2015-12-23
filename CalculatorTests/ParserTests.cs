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
			const string input = "4+5*2";
			List<string> expectedResult = new List<string>(new string[] { "4", "+", "5", "*", "2"});

			Parser parser = new Parser ();
			List<string> result = parser.Parse (input);

			Assert.AreEqual (expectedResult.Count, result);
			for (int i = 0; i < expectedResult.Count; i++)
			{
				Assert.AreEqual (expectedResult [i], result [i]);
			}
		}
	}
}

