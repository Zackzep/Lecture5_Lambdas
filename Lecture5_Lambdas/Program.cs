using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Lambdas
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			//Parse is a method used to tell the computer to check if a string is actually a type of number

			string number52 = "52";
			string number7 = "7";
			string result = number52 + number7;

			//using parse
			int num52 = int.Parse("52");
			int num7 = int.Parse("7");
			int numResult = num52 + num7;
			Console.WriteLine(numResult);

			//Using convert
			int con52 = Convert.ToInt32("52");
			int con7 = Convert.ToInt32("7");
			Console.WriteLine(con52 + con7);

			Console.Write("Please enter a number: ");
			string userString1 = Console.ReadLine();
			Console.Write("Please enter a number: ");
			string userString2 = Console.ReadLine();
			int userNum1 = int.Parse(userString1);
			int userNum2 = int.Parse(userString2);
			int userResult = userNum1 + userNum2;
			Console.WriteLine($"{userNum1} + {userNum2} = {userResult}");

			Console.ReadLine();
		}

		public static void MathExample()
		{
			//Math operations +, -, *, /, %
			//Assignment operations
			//Comparison operation
			//Compound operations

			//Perform the math
			int num1 = 123;
			int num2 = 634;
			int add = num1 + num2;
			string symbol = "+";
			//Display to user
			FormattedMathString(num1, num2, add, symbol);

			int sub1 = 9876546;
			int sub2 = 1374828;
			int subResult = sub1 - sub2;
			symbol = "-";
			FormattedMathString(sub1, sub2, subResult, symbol);

			int multi1 = 946;
			int multi2 = 28;
			int multiresult = multi1 * multi2;
			symbol = "*";
			FormattedMathString(multi1, multi2, multiresult, symbol);

			int div1 = 946;
			int div2 = 28;
			double divResult = div1 / (div2 * 1.0);
			symbol = "/";
			FormattedMathString(div1, div2, divResult, symbol);

			int mod1 = 20;
			int mod2 = 15;
			int modResult = mod1 % mod2;
			int divmod1 = mod1;
			int divmod2 = mod2;
			int divModResult = divmod1 / divmod2;
			Console.WriteLine("How division and mod compliment each other");
			symbol = "%";
			FormattedMathString(mod1, mod2, modResult, symbol);
			symbol = "/";
			FormattedMathString(divmod1, divmod2, divModResult, symbol);

			//How to get a random number
			Random rand = new Random();
			Console.WriteLine(rand.Next(0, 100));
		}

		public static void FormattedMathString(int num1, int num2, double result, string operation)
		{
			Console.WriteLine($"{num1} {operation} {num2} = {result}");
		}

		public static void IntegerExample()
		{
			//Integral - Whole Number
			//To declare a variable that will hold a whole number
			int number1 = 65;
			int number2 = 87;
			int result = number1 + number2;

			string stringNum1 = "65";
			string stringNum2 = "87";
			string stringResult = stringNum1 + stringNum2;

			sbyte sbyteNumber1 = 80;
			sbyte sbyteNumber2 = 120;
			//Error because result is too large for sbyte
			//sbyte sbyteResult = sbyteNumber1 + sbyteNumber2;

			Console.WriteLine(stringResult);
		}
	}
}
