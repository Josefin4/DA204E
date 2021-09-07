using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
	class Album
	{
		private string albumName;
		private string artistName;
		private int numberOfTracks;
		public void Start()
		{
			Console.WriteLine();
			Console.WriteLine("\nStarting album program!");
			Console.WriteLine();

			ReadAndSaveAlbumData();
			DisplayAlbumInfo();
		}

		public void ReadAndSaveAlbumData()
		{
			Console.Write("What is the name of your favorite music album? ");
			albumName = Console.ReadLine();

			Console.Write("What is the name of the Artist or Band for " + albumName + "? ");
			artistName = Console.ReadLine();

			Console.Write("How many tracks does " + albumName + " have? ");
			string textValue = Console.ReadLine();
			numberOfTracks = int.Parse(textValue);

		}

		public void DisplayAlbumInfo()
		{
			string textOut = "Album name: " + albumName + "\nArtist/Band: " + artistName + "\nNumber of Tracks: " + numberOfTracks;
			Console.WriteLine(textOut);
			Console.WriteLine();
		}

	}
}
