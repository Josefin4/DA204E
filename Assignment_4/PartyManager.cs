using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
	/// <summary>
	/// class that handles all the logic and operations for the application that
	/// does not interact with the user directly
	/// </summary>
	class PartyManager
	{
		//array for the guest list
		private string[] guestList;


		private double costPerPerson;
		private double feePerPerson;
		private double surplusDeficit;

		/// <summary>
		/// property to get and set values for CostPerGuest
		/// </summary>
		public double CostPerGuest
		{
			get
			{
				return costPerPerson;
			}

			set
			{
				if (value >= 0)
					costPerPerson = value;
			}
		}


		/// <summary>
		/// property to get and set values for FeePerGuest
		/// </summary>
		public double FeePerGuest
		{
			get
			{
				return feePerPerson;
			}


			set
			{
				if (value >= 0)
					feePerPerson = value;
			}
		}
		/// <summary>
		/// property to get and set values for SurplusDeficit
		/// </summary>
		public double SurplusDeficit
		{
			get
			{
				return surplusDeficit;
			}

			set
			{
				if (value >= 0)
					surplusDeficit = value;
			}
		}


		/// <summary>
		/// constructor for the class that creates the guest list array
		/// </summary>
		public PartyManager(int maxNumberofGuests)
		{
			guestList = new string[maxNumberofGuests];
		}

		/// <summary>
		/// method that gets the party guests from the guestList array
		/// and counts the number of guests
		/// </summary>
		public int NumOfGuests()
		{
			int numGuests = 0;

			for (int i = 0; i < guestList.Length; i++)
			{
				if (!string.IsNullOrEmpty(guestList[i]))
				{
					numGuests++;
				}
			}

			return numGuests;
		}

		/// <summary>
		/// gets the party guests from the guestlist array to find the first empty or
		/// null string value position to make it possible for a new guest to be added
		/// </summary>
		private int FindVacantPos()
		{
			int vacantPos = -1;

			for (int i = 0; i < guestList.Length; i++)
			{
				if (string.IsNullOrEmpty(guestList[i]))
				{
					vacantPos = i;
					break;
				}
			}

			return vacantPos;
		}


		/// <summary>
		/// method that takes a guest's first and last name and
		/// searches for the first vacant position in the array and
		/// the guest is then added to it with its first and last name
		/// </summary>
		public bool AddNewGuest(string firstName, string lastName)
		{
			bool ok = true;
			int vacantPos = FindVacantPos();

			if (vacantPos != -1)
			{
				guestList[vacantPos] = FullName(firstName, lastName);
			}
			else
				return false;

			return ok;
		}

		/// <summary>
		/// method that takes the guest's first and last name and
		/// turns it into a string that containts the full name
		/// </summary>
		private string FullName(string firstName, string lastName)
		{
			return lastName.ToUpper() + ", " + firstName;
		}

		/// <summary>
		/// method that refers to array guestList and creates a new array guests with
		/// the names of the guests that are not null nor empty,
		/// and returns the new guests array
		/// </summary>
		public string[] GetGuestList()
		{
			int size = NumOfGuests();

			if (size <= 0)
				return null;

			string[] guests = new string[size];

			for (int i = 0, j = 0; i < guestList.Length; i++)
			{
				if (!string.IsNullOrEmpty(guestList[i]))
				{
					guests[j++] = guestList[i];
				}
			}

			return guests;
		}




		/// <summary>
		/// method that calculates the total cost of the party
		/// this is done by multiplying the cost per person with the number of guests
		/// </summary>
		public double CalcTotalCost()
		{
			return costPerPerson * NumOfGuests();
		}

		/// <summary>
		/// method that calculates the total fee cost
		/// this is done by multiplying the fee per person with the number of guests
		/// </summary>
		public double CalcTotalFee()
		{
			return feePerPerson * NumOfGuests();
		}

		/// <summary>
		/// method that calculates the surplus deficit
		/// this is done by subtracting the total fee cost with the total cost
		/// </summary>
		public double CalcSurplusDeficit()
		{
			surplusDeficit = CalcTotalFee() - CalcTotalCost();
			return surplusDeficit;
		}


		/// <summary>
		/// method that deletes a guest
		/// </summary>
		public bool DeleteGuest(int index)
		{
			int size = GetGuestList().Length;

			if (size <= 0)
				return false;

			for (int i = index + 1; i < guestList.Length; i++)
			{
				guestList[i - 1] = guestList[i];
				guestList[i] = string.Empty;
			}
			return true;
		}


	}
}
