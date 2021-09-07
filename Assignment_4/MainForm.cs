using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
	/// <summary>
	/// Class handles the GUI through a Windows Form and interactions with user
	/// </summary>
	public partial class MainForm : Form
	{
		// object consisting of data and methods for the application
		PartyManager party;
		/// <summary>
		/// start point which initializes the GUI 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			InitializeGUI();
		}

		/// <summary>
		/// method for the GUI when it starts
		/// it also calls the clear input and output methods
		/// </summary>
		private void InitializeGUI()
		{
			ClearInputControls();
			ClearOutputControls();

			grpInvite.Enabled = false;
			grpParty.Enabled = true;
		}

		/// <summary>
		/// method to clear the input controls when the GUI starts
		/// </summary>
		private void ClearInputControls()
		{
			txtMaxNumOfGuests.Text = string.Empty;
			txtCostPerPerson.Text = string.Empty;
			txtFirstName.Text = string.Empty;
			txtLastName.Text = string.Empty;
		}

		/// <summary>
		/// method to clear the output controls when the GUI starts
		/// </summary>
		private void ClearOutputControls()
		{
			lblTotalCostOut.Text = "0,00";
			lblNumOfGuestsOut.Text = "0";
			lblTotalFeesOut.Text = "0,00";
			lblSurDefOut.Text = "0,00";
			lstAllGuests.Items.Clear();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lblFeePerPerson_Click(object sender, EventArgs e)
		{

		}

		private void lblFirstName_Click(object sender, EventArgs e)
		{

		}

		private void lblLastName_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// method connected to the Add button
		/// when user clicks on it, a new party nember is added
		/// unless the guest list is already full, in which case there
		/// is an error message
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (TrimName())
			{
				bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
				if (!ok)
				{
					MessageBox.Show("The guest list is already full!", "Error");
				}
				else
				{
					UpdateGUI();
				}
			}
		}

		/// <summary>
		/// method that validates the text so it is not null or empty
		/// </summary>
		private bool ValidateText(string text, string errMessage)
		{
			text = text.Trim();

			if (string.IsNullOrEmpty(text))
			{
				MessageBox.Show(errMessage);
				return false;
			}
			return true;

		}

		/// <summary>
		/// method to validate the input for first name and last name
		/// and the text gets trimmed in the text boxes
		/// </summary>
		private bool TrimName()
		{
			bool fstNameOK = ValidateText(txtFirstName.Text, "First name is required!");
			bool lstNameOK = ValidateText(txtLastName.Text, "Last name is required!");
			return fstNameOK && lstNameOK;
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void lblNumOfGuests_Click(object sender, EventArgs e)
		{

		}


		private void lblGuestList_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// method that validates the provided number of guests and cost per person
		/// and then creates a new party member
		/// </summary>
		private bool CreateParty()
		{
			int maxNumber = 0;
			bool ok = true;

			if (int.TryParse(txtMaxNumOfGuests.Text, out maxNumber) && maxNumber > 0)
			{
				party = new PartyManager(maxNumber);
				MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success");
			}
			else
			{
				MessageBox.Show("Invalid Total Number. Please try again!", "Error");
				return false;
			}

			return ok;
		}

		/// <summary>
		/// method that handles the input entries related to the cost per person
		/// and validates it and parses it
		/// </summary>
		private bool CostPerPerson()
		{
			double amount = 0.0;

			if (double.TryParse(txtCostPerPerson.Text, out amount) && amount > 0.0)
			{
				party.CostPerGuest = amount;
				return true;
			}
			else
			{
				MessageBox.Show("Invalid cost value!", "Error");
				return false;
			}
		}

		/// <summary>
		/// method that handles the input entries related to the fee per person
		/// and validates it and parses it
		/// </summary>
		private bool FeePerPerson()
		{
			double amount = 0.0;

			if (double.TryParse(txtFeePerPerson.Text, out amount) && amount > 0.0)
			{
				party.FeePerGuest = amount;
				return true;
			}
			else
			{
				MessageBox.Show("Invalid fee value!", "Error");
				return false;
			}
		}

		/// <summary>
		/// method that updates the GUI with the number of guests,
		/// total cost, fee cost and surplus/deficit.
		/// </summary>
		private void UpdateGUI()
		{
			lstAllGuests.Items.Clear();
			string[] guestList = party.GetGuestList();

			if (guestList != null)
			{
				for (int i = 0; i < guestList.Length; i++)
				{
					string str = $"{i + 1,4} {guestList[i],-20} ";
					lstAllGuests.Items.Add(str);
				}
			}

			double totalCost = party.CalcTotalCost();
			lblTotalCostOut.Text = totalCost.ToString("0.0");
			double totalFee = party.CalcTotalFee();
			lblTotalFeesOut.Text = totalFee.ToString("0.0");
			double totalSurplus = party.CalcSurplusDeficit();
			lblSurDefOut.Text = totalSurplus.ToString("0.0");
			lblNumOfGuestsOut.Text = party.NumOfGuests().ToString();
		}

		/// <summary>
		/// method to delete the selected guest
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			int index = lstAllGuests.SelectedIndex;


			if (index >= 0 && party.DeleteGuest(index))
			{
				MessageBox.Show("Guest has been deleted!", "Message");
			}


			UpdateGUI();

		}

		private void lblSurDefOut_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// the method is related to the create list button,
		/// when it is clicked, the inputs are validated
		/// and the new party object is then created
		/// </summary>
		private void btnCreateList_Click(object sender, EventArgs e)
		{
			bool maxNumOK = CreateParty();
			if (!maxNumOK)
				return;

			bool amountOK = CostPerPerson() && FeePerPerson();

			if (maxNumOK && amountOK)
			{
				grpInvite.Enabled = true;
				UpdateGUI();
			}
		}
	}
}
