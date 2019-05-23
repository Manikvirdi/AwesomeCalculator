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
			[Test]
		public void GetDivision_Input10point0and2point0_Returns5point0()
		{
			//Arrange 
			double number1 = 10;
			double number2 = 2;

			double expectedResult = number1 / number2;
			Calc testCalc = new Calc(number1, number2);
			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetDivision_Input45point0and5point0_Returns9point0()
		{
			//Arrange 
			double number1 = 45;
			double number2 = 5;

			double expectedResult = number1 / number2;
			Calc testCalc = new Calc(number1, number2);
			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetDivision_Input99point0and3point0_Return33point0()
		{
			//Arrange 
			double number1 = 99;
			double number2 = 3;

			double expectedResult = number1 / number2;
			Calc testCalc = new Calc(number1, number2);
			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}
				[Test]
		public void GetMultiplication_Input3point0and5point0_Returns15point0()
		{
			//Arrange 
			double number1 = 3;
			double number2 = 5;

			double expectedResult = number1 * number2;
			Calc testCalc = new Calc(number1, number2);
			//Act 
			double actualResult = testCalc.GetMultiplication();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetMultiplication_Input100point0and2point0_Returns200point0()
		{
			//Arrange 
			double number1 = 100;
			double number2 = 2;

			double expectedResult = number1 * number2;
			Calc testCalc = new Calc(number1, number2);
			//Act 
			double actualResult = testCalc.GetMultiplication();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetMultiplication_Input6point0and6point0_Returns36point7()
		{
			//Arrange 
			double number1 = 6;
			double number2 = 6;

			double expectedResult = number1 * number2;
			Calc testCalc = new Calc(number1, number2);
			//Act 
			double actualResult = testCalc.GetMultiplication();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

	}
}
