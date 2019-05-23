using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace CalculatorTest
{
	[TestFixture]
	public class Class1
    {
		[Test]
		public void GetAddition_Input0point8and7point8_Returns8point6()
		{

			//Arrange 
			double number1 = 0.8;
			double number2 = 7.8; 

			double expectedResult = number1 + number2;
			Calc testCalc = new Calc(number1, number2);
			//Act double actualResult = testCalc.GetAddition(); 

			//Assert Assert.AreEqual(expectedResult, actualResult); 
		}

		[Test]
		public void GetAddition_Input0point008and47point128_Returns47point136()
		{

			//Arrange 
			double number1 = 0.008;
			double number2 = 47.128;

			double expectedResult = number1 + number2;
			Calc testCalc = new Calc(number1, number2);
			//Act double actualResult = testCalc.GetAddition(); 

			//Assert Assert.AreEqual(expectedResult, actualResult); 
		}
		[Test]
		public void GetAddition_Input112point06and47point128_Returns159point188()
		{

			//Arrange 
			double number1 = 112.06;
			double number2 = 47.128;

			double expectedResult = number1 + number2;
			Calc testCalc = new Calc(number1, number2);
			//Act double actualResult = testCalc.GetAddition(); 

			//Assert Assert.AreEqual(expectedResult, actualResult); 
		}
	}
}
