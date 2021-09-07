using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
	class TemperatureConverter
	{
		public TemperatureConverter()
		{
			Console.Clear();
			Start();
		}
		public void Start()
		{
			int choice = -1;
			while (choice != 0)
			{
				ShowMenu();
				choice = int.Parse(Console.ReadLine());
			}
			switch (choice)
			{
				case 0:
					break;
				case 1:
					ShowTableCelsiusToFahrenheit();
					break;
				case 2:
					ShowTableFahrenheitToCelsius();
					break;
				default:
					Console.WriteLine("Invalid option, try again!");
					break;
			}
		}
		public void ShowMenu()
		{
		}
		private void ShowTableCelsiusToFahrenheit()
		{
			const int columns = 2;
			const int max = 100;
			int p = 0;
			for (int i = 0; i < max; i += 4)
			{
				double result = CelsiusToFahrenheit(i);
				Console.Write("{0,6:f2} C= {1,6:f2} F ", i, result);

				p++;
				if ((p % columns == 0) && (p >= columns))
					Console.WriteLine();
			}
		}
		private double CelsiusToFahrenheit(double celsius)
		{
			return 9.0 / 5.0 * celsius + 32.0;
		}
		private void ShowTableFahrenheitToCelsius()
		{
			const int columns = 2;
			const int max = 100;
			int p = 0;
			for (int i = 0; i < max; i += 4)
			{
				double result = FahrenheitToCelsius(i);
				Console.Write("{0,6:f2} C= {1,6:f2} F ", i, result);

				p++;
				if ((p % columns == 0) && (p >= columns))
					Console.WriteLine();
			}
		}
		private double FahrenheitToCelsius(double celsius)
		{
			return 9.0 / 5.0 * celsius + 32.0;
		}
	}
}
