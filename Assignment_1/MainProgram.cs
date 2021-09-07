using System;

namespace Assignment_1
{
	class MainProgram
	{
		static void Main(string[] args)
		{
			Pet petObj = new Pet();
			petObj.Start();

			Album albumObj = new Album();
			albumObj.Start();
			Console.ReadLine();
		}
	}
}
