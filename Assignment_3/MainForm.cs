using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
	/// <summary>
	/// class that handles the interactions between the user and application
	/// </summary>
	public partial class MainForm : Form
	{
		// creates an instance of the BMICalculator
		private BMICalculator bmiCalc = new BMICalculator();
		
		/// <summary>
		/// initialize the method
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			InitializeGUI();

		}

		/// <summary>
		/// method for initializations
		/// </summary>
		private void InitializeGUI()
		{
			this.Text += " Josefin Salomaa";
			lblBMI.Text = string.Empty;
			lblWeightCat.Text = string.Empty;
			lblNormalBMI.Text = "Normal weight";
			rbtnMetric.Checked = true;
			lblNormalBMI.Text = "Normal BMI is between 18.5 and 24.9";
			lblNormalWeight.Text = string.Empty;
		}

		


		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{


		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		
		/// <summary>
		/// the form changes to the american/imperial bmi system when user clicks on this button
		/// </summary>
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			lblHeight.Text = "Height (ft, in)";
			lblWeight.Text = "Weight (lbs)";
			txtInch.Visible = true;
		}


		/// <summary>
		/// when button is clicked, input is read and results are displayed if the correct values have been sent
		/// </summary>
		private void btnOK_Click(object sender, EventArgs e)
		{
			bool ok = ReadInputBMI();

			if (ok)
			{
			DisplayResults();
			}
		}

		/// <summary>
		/// method to display the results from the BMI calculations
		/// </summary>
		private void DisplayResults()
		{
			double bmi = bmiCalc.CalculateBMI();
			lblBMI.Text = bmi.ToString("f2");
			lblWeightCat.Text = bmiCalc.BmiWeightCategory();

			// displaying the normal weight for american or metric 
			if (bmiCalc.GetUnit() == UnitTypes.American)
			{
				lblNormalWeight.Text = "Normal weight should be between " + bmiCalc.CalculateWeight(18.50).ToString("f2") + " and " + bmiCalc.CalculateWeight(24.9).ToString("f2") + " lbs";
			}
			else
			{
				lblNormalWeight.Text = "Normal weight should be between " + bmiCalc.CalculateWeight(18.50).ToString("f2") + " and " + bmiCalc.CalculateWeight(24.9).ToString("f2") + " kg";
			}
		}


		/// <summary>
		/// method for calling the methods for the inputs
		/// </summary>
		private bool ReadInputBMI()
		{
			ReadUnit();
			ReadName();
			
			return ReadHeight() && ReadWeight();
		}

		/// <summary>
		/// determines the unit type depending on what choice the user has made
		/// </summary>
		private void ReadUnit()
		{
			if (rbtnMetric.Checked)
				bmiCalc.SetUnit(UnitTypes.Metric);
			else
				bmiCalc.SetUnit(UnitTypes.American);
		}

		/// <summary>
		/// Read the input name from the user
		/// Display the name provided by GetName if user hasn't provided a name
		/// </summary>
		private void ReadName()
		{
			string name = txtName.Text;
			name = name.Trim();
			if (!string.IsNullOrEmpty(txtName.Text))
				grpResults.Text = name;
			else
				grpResults.Text = bmiCalc.GetName();
			


		}

		/// <summary>
		/// Read the input height and check if the height is valid
		/// Height is converted to m or inch, depending on the unit type
		/// </summary>
		private bool ReadHeight()
		{
			double height = 0.0;
			

			bool ok = double.TryParse(txtCmFt.Text, out height);
			if (!ok)
			{
				MessageBox.Show("Invalid height value!", "Error");
			}
			double inch = 0.0;
			if (rbtnAmerican.Checked)
			{
				ok = ok && double.TryParse(txtInch.Text, out inch);
				if (!ok)
				{
					MessageBox.Show("Invalid inch value!", "Error");
				}
			}
			if (bmiCalc.GetUnit() == UnitTypes.American)
			{
				bmiCalc.SetHeight(height * 12.0 + inch);
			}
			else
			{
				bmiCalc.SetHeight(height / 100.0);
			}

			return ok;
		}


		/// <summary>
		/// Read the weight input and check if it is valid
		/// </summary>
		private bool ReadWeight()
		{
			double weight = 0.0;
			bool ok = double.TryParse(txtWeight.Text, out weight);
			if (!ok)
			{
				MessageBox.Show("Invalid weight value!", "Error");
			}
			bmiCalc.SetWeight(weight);

			return ok;
		}
	

		private void txtCmFt_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblNormalBMI_Click(object sender, EventArgs e)
		{

		}

		private void lblWeightCat_Click(object sender, EventArgs e)
		{

		}

		
		/// <summary>
		/// Display the metric system if the unit type metric is chosen
		/// </summary>
		private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
		{

			lblHeight.Text = "Height (cm)";
			lblWeight.Text = "Weight (kg)";
			txtInch.Visible = false;



		}
		

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}

		private void lblBMI_Click(object sender, EventArgs e)
		{

		}

		private void NormalWeight_Click(object sender, EventArgs e)
		{

		}
	}
}
