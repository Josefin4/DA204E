using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
	class Pet
	{
		private string name;
		private int age;
		private bool isFemale;

		public void Start()
		{
			Console.WriteLine();
			Console.WriteLine("Greetings from the pet application!");
			Console.WriteLine();

			ReadAndSavePetData();
			DisplayPetInfo();
		}

		public void ReadAndSavePetData()
		{
			Console.Write("What is the name of your pet? ");
			name = Console.ReadLine();

			Console.Write("What is " + name + "'s age? ");
			string textValue = Console.ReadLine();
			age = int.Parse(textValue);

			Console.Write("Is your pet a female (y/n)? ");
			string strGender = Console.ReadLine();
			strGender = strGender.Trim();
			char response = strGender[0];

			if ((response == 'y') || (response == 'Y'))
				isFemale = true;
			else
				isFemale = false;
		}

		public void DisplayPetInfo()
		{
			string textOut = "Name: " + name + "\nAge: " + age;
			Console.WriteLine(textOut);
			Console.WriteLine();
			if (isFemale == true)
				Console.Write(name + " is a good girl!");
			else
				Console.Write(name + " is a good boy!");
		}

	}
}
