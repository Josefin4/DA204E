using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
	/// <summary>
	/// Calculates the BMI and has fields that can be accessed through
	/// getter and setter methods
	/// </summary>
	class BMICalculator
	{
		private string name = "No Name";
		private double height = 0;
		private double weight = 0;

		private UnitTypes unit;

		/// <summary>
		/// Constructor with the unit type metric
		/// </summary>
		public BMICalculator()
		{
			unit = UnitTypes.Metric;
		}

		/// <summary>
		/// getter method for the name-field
		/// </summary>
		/// <returns>the name in the name field</returns>
		public string GetName()
		{
			return name;
		}

		/// <summary>
		/// setter method that changes the value that is saved in
		/// the instance variable name by a new value that comes to this method
		/// through the parameter value
		/// </summary>
		/// <param name="value">new value to be saved in name from input</param>
		public void SetName(string value)
		{
			if (!string.IsNullOrEmpty(value))
				name = value;
		}

		/// <summary>
		/// getter method for the height field
		/// </summary>
		/// <returns>the value in the height field</returns>
		public double GetHeight()
		{
			return height;
		}

		/// <summary>
		///  setter method that changes the value that is saved in
		/// the instance variable height by a new value that comes to this method
		/// through the parameter value
		/// </summary>
		/// <param name="height">new height value to be saved</param>
		public void SetHeight(double height)
		{
			if (height >= 0.0)
				this.height = height;
		}

		/// <summary>
		/// getter method for the weight field
		/// </summary>
		/// <returns>the value in the weight field</returns>
		public double GetWeight()
		{
			return weight;
		}

		/// <summary>
		/// setter method that changes the value that is saved in
		/// the instance variable weight by a new value that comes to this method
		/// through the parameter value
		/// </summary>
		/// <param name="weight">new weight value to be saved</param>
		public void SetWeight(double weight)
		{
			if (weight >= 0)
				this.weight = weight;
		}
		/// <summary>
		/// getter method for the unit types field
		/// </summary>
		/// <returns>the unit</returns>
		public UnitTypes GetUnit()
		{
			return unit;
		}
		/// <summary>
		/// setter method that changes the value that is saved in
		/// the instance variable unit types by a new value that comes to this method
		/// through the parameter value
		/// </summary>
		/// <param name="unit">the unit type is saved</param>
		public void SetUnit(UnitTypes unit)
		{
			this.unit = unit;
		}


		/// <summary>
		/// calculating the bmi for both unit types
		/// </summary>
		/// <returns>the bmi value</returns>
		public double CalculateBMI()
		{
			double bmi = 0.0;

			// calculates the bmi value if the unit type is American
			if (unit == UnitTypes.American)
			{

				bmi = (weight * 703.0) / (height * height);
			}
			// else, it calculates the bmi value for the metric type
			else
				bmi = weight / (height * height);

			return bmi;
		}




		/// <summary>
		/// determines the weight category 
		/// based on the bmi results by calling the CalculateBMI method
		/// </summary>
		/// <returns>the corresponding weight class</returns>
		public string BmiWeightCategory()
		{
			double result = CalculateBMI();

			if (result < 18.5)
				return "Underweight";
			else if (result <= 24.9)
				return "Normal weight";
			else if (result <= 29.9)
				return "Overweight(Pre-obesity)";
			else if (result <= 34.9)
				return "Overweight(Obesity class I)";
			else if (result <= 39.9)
				return "Overweight(Obesity class II)";
			else
				return "Overweight(Obesity class III)";


		}

		/// <summary>
		/// method to calculate the weight value that has been provided
		/// from the input based on the height value
		/// </summary>
		public double CalculateWeight(double bmi)
		{
			double weight = 0.0;

			
			if (unit == UnitTypes.American)
			{
				weight = bmi * (this.GetHeight() * this.GetHeight()) / 703.0;
			}
			else
			{
				weight = bmi * (this.GetHeight() * this.GetHeight());
			}

			return weight;
		}
	}
}
