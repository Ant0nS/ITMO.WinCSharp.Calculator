using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Calculator
{
	public class CalcEngine
	{
		// Operation Constants.
		public enum Operator: int
		{
			eUnknown,
			eSum,
			eSubstract,
			eMultiply,
			eDivide,
			eDegree
		}

		// Module-level Variables.
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;

		// Class Constructor.
		public CalcEngine()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		// Called when a number key is pressed on the keypad.
		public static string CalcNumber(string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

		// Called when an operator is selected (+, -, *, /, yx)
		public static void CalcOperation(Operator calcOper)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
				firstNumber = Convert.ToDouble(stringAnswer);
				calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
			}
		}

		// Called when the +/- key is pressed.
		public static string CalcSign()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = Convert.ToDouble(stringAnswer);
				stringAnswer = Convert.ToString(numHold * (-1));
			}

			return (stringAnswer);
		}

		// Called when the <-- key is pressed.
		public static string CalcDelete()
        {
			if (stringAnswer != "")
			{
				int lenght = stringAnswer.Length - 1;
				string text = stringAnswer;
				stringAnswer = "";
				for (int i = 0; i < lenght; i++)
				{
					stringAnswer = stringAnswer + text[i];
				}
				return stringAnswer;
			}
            else
            {
				return stringAnswer = "0";
			}
		}

		// Called when the . key is pressed.
		public static string CalcDecimal()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		// Called when Square key is pressed.
		public static string CalcSquare()
		{
			double numHold;
			if (stringAnswer != "")
			{
				secondNumberAdded = true;
				numHold = Convert.ToDouble(stringAnswer);
				stringAnswer = Convert.ToString(numHold * numHold);
			}
			return stringAnswer;
		}

		// Called when Cube key is pressed.
		public static string CalcCube()
		{
			double numHold;
			if (stringAnswer != "")
			{
				numHold = Convert.ToDouble(stringAnswer);
				double numTemp = Math.Pow(numHold,3);
				stringAnswer = Convert.ToString(numTemp);
			}
			return stringAnswer;
		}

		// Called when Factorial key is pressed.
		public static string CalcFactorial()
		{
			int numHold;
			if (stringAnswer != "") 
			{
				try
				{
					numHold = Convert.ToInt32(stringAnswer);
					if (numHold >= 0)
					{
						if (numHold > 2)
						{
							int f = 1;
							for (int k = 2; k <= numHold; k++)
							{
								f = f * k;
							}
							stringAnswer = Convert.ToString(f);
						}
						else
                   				{
							stringAnswer = "1";
                   				}
					}
					else 
					{
						stringAnswer = "Can not compute";
					}
				catch
				{
					stringAnswer = "Can not compute";
				}
			}
			return stringAnswer;
		}

		// Called when = is pressed.
		public static string CalcEqual()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = System.Convert.ToDouble(stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eSum:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubstract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;

					case Operator.eDegree:
						numericAnswer = Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;

					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString(numericAnswer);
			}

			return (stringAnswer);
		}

		// Called when SquareRoot is pressed.
		public static string CalcSqrRoot()
        {
			double numHold;
			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				double numTemp = Math.Pow(numHold, 1.0/2.0);
				stringAnswer = System.Convert.ToString(numTemp);
			}
			return stringAnswer;
		}

		// Called when CubeRoot is pressed.
		public static string CalcCubeRoot()
		{
			double numHold;
			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				double numTemp = Math.Pow(numHold, 1.0 / 3.0);
				stringAnswer = System.Convert.ToString(numTemp);
			}
			return stringAnswer;
		}

		// Called when CalcInverseValue is pressed.
		public static string CalcInverseValue()
		{
			double numHold;
			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				double numTemp = Math.Pow(numHold, 1.0 / 3.0);
				stringAnswer = System.Convert.ToString(numTemp);
			}
			return stringAnswer;
		}

	// Resets the various module-level variables for the next calculation.
	public static void CalcReset()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;
		}
	}
}
