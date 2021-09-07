using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
	class SelectionAndIteration
	{
		public SelectionAndIteration()
		{
			Console.WriteLine();
			Console.WriteLine("My name is Josefin and I am a student of the VT 21 semester!");
			Console.WriteLine();

			ShowStringLength();
			Console.WriteLine();

			MakeMyDay();
			Console.WriteLine();

			SumNumbers();
		}

		public void ShowStringLength()
		{
			string text = string.Empty;
			bool done = false;

			Console.WriteLine("Let me calculate the length of strings for you!");
			do
			{

				Console.WriteLine("Give me a text or any length, or press Enter to exit!\n");
				text = Console.ReadLine();

				int length = text.Length;
				if (length == 0)
				{
					done = true;
				}
				else
				{
					text = text.ToUpper();
					Console.Write(text + "\n");
					Console.Write("Number of chars = " + length + "\n" + "\n");
				}
			}
			while (!done);
		}

		public void MakeMyDay()
		{
			Console.Write("I can predict your day for you. ");
			Console.Write("Give a number between 1 and 7: ");
			int day = int.Parse(Console.ReadLine());
			string fortune = string.Empty;

			switch (day)
			{
				case 1:
					fortune = "Monday: Keep calm! You can fall apart!";
					break;
				case 2:
				case 3:
					fortune = "Tuesday and Wednesday break your heart!";
					break;
				case 4:
					fortune = "Thursday, Uuush, still one day to Friday!";
					break;
				case 5:
					fortune = "It's Friday! You are in love!";
					break;
				case 6:
					fortune = "Saturday, do nothing and do plenty of it!";
					break;
				case 7:
					fortune = "And Sunday always comes too soon!";
					break;
				default:
					fortune = "Not in a good mode? This is not a valid date!";
					break;
			}
			Console.WriteLine(fortune);
		}

		private int SumNumbers(int start, int end)
		{
			int sum = 0;
			for (int i = start; i <= end; i++)
			{
				sum = sum + i;
			}
			return sum;
		}

		public void SumNumbers()
		{
			Console.WriteLine();
			Console.Write("Give start number: ");

			int startNum = int.Parse(Console.ReadLine());
			Console.Write("Give end number: ");
			int endNum = int.Parse(Console.ReadLine());
			int temp = startNum;

			if (startNum > endNum)
			{
				startNum = endNum;
				endNum = temp;
			}
			int sum = SumNumbers(startNum, endNum);
			Console.WriteLine("The sum between " + startNum + " and " + endNum + " is: " + sum);
		}

	}
}
