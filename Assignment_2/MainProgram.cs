﻿using System;

namespace Assignment_2
{
	class MainProgram
	{
		static void Main(string[] args)
		{
			Console.Title = "Selection and iteration in C#";
			SelectionAndIteration warmupObj = new SelectionAndIteration();

			Console.WriteLine("Press any key to continue!");
			Console.ReadLine();

			Console.Title = "Fahrenheit and Celsius Converter";
			TemperatureConverter converter = new TemperatureConverter();

			Console.WriteLine("Press any key to continue!");
			Console.ReadLine();
		}
	}
}
