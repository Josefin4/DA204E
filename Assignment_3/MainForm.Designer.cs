
namespace BMICalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblHeight = new System.Windows.Forms.Label();
			this.txtCmFt = new System.Windows.Forms.TextBox();
			this.txtInch = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBMI = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblWeightCat = new System.Windows.Forms.Label();
			this.lblNormalBMI = new System.Windows.Forms.Label();
			this.grpUnit = new System.Windows.Forms.GroupBox();
			this.rbtnAmerican = new System.Windows.Forms.RadioButton();
			this.rbtnMetric = new System.Windows.Forms.RadioButton();
			this.grpResults = new System.Windows.Forms.GroupBox();
			this.lblWeight = new System.Windows.Forms.Label();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.lblNormalWeight = new System.Windows.Forms.Label();
			this.grpUnit.SuspendLayout();
			this.grpResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Your name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(201, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(269, 30);
			this.txtName.TabIndex = 1;
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeight.Location = new System.Drawing.Point(45, 76);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(68, 25);
			this.lblHeight.TabIndex = 2;
			this.lblHeight.Text = "Height";
			this.lblHeight.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtCmFt
			// 
			this.txtCmFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCmFt.Location = new System.Drawing.Point(247, 76);
			this.txtCmFt.Name = "txtCmFt";
			this.txtCmFt.Size = new System.Drawing.Size(100, 30);
			this.txtCmFt.TabIndex = 3;
			this.txtCmFt.TextChanged += new System.EventHandler(this.txtCmFt_TextChanged);
			// 
			// txtInch
			// 
			this.txtInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInch.Location = new System.Drawing.Point(370, 76);
			this.txtInch.Name = "txtInch";
			this.txtInch.Size = new System.Drawing.Size(100, 30);
			this.txtInch.TabIndex = 4;
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(223, 163);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(140, 39);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "Calculate";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Your BMI";
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// lblBMI
			// 
			this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBMI.Location = new System.Drawing.Point(191, 33);
			this.lblBMI.Name = "lblBMI";
			this.lblBMI.Size = new System.Drawing.Size(181, 35);
			this.lblBMI.TabIndex = 7;
			this.lblBMI.Text = "label3";
			this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblBMI.Click += new System.EventHandler(this.lblBMI_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Weight Category";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// lblWeightCat
			// 
			this.lblWeightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblWeightCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWeightCat.Location = new System.Drawing.Point(191, 83);
			this.lblWeightCat.Name = "lblWeightCat";
			this.lblWeightCat.Size = new System.Drawing.Size(320, 36);
			this.lblWeightCat.TabIndex = 9;
			this.lblWeightCat.Text = "label3";
			this.lblWeightCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblWeightCat.Click += new System.EventHandler(this.lblWeightCat_Click);
			// 
			// lblNormalBMI
			// 
			this.lblNormalBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNormalBMI.ForeColor = System.Drawing.Color.Green;
			this.lblNormalBMI.Location = new System.Drawing.Point(71, 390);
			this.lblNormalBMI.Name = "lblNormalBMI";
			this.lblNormalBMI.Size = new System.Drawing.Size(385, 40);
			this.lblNormalBMI.TabIndex = 10;
			this.lblNormalBMI.Text = "label3";
			this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNormalBMI.Click += new System.EventHandler(this.lblNormalBMI_Click);
			// 
			// grpUnit
			// 
			this.grpUnit.Controls.Add(this.rbtnAmerican);
			this.grpUnit.Controls.Add(this.rbtnMetric);
			this.grpUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpUnit.Location = new System.Drawing.Point(488, 43);
			this.grpUnit.Name = "grpUnit";
			this.grpUnit.Size = new System.Drawing.Size(273, 159);
			this.grpUnit.TabIndex = 11;
			this.grpUnit.TabStop = false;
			this.grpUnit.Text = "  Unit";
			// 
			// rbtnAmerican
			// 
			this.rbtnAmerican.AutoSize = true;
			this.rbtnAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnAmerican.Location = new System.Drawing.Point(21, 79);
			this.rbtnAmerican.Name = "rbtnAmerican";
			this.rbtnAmerican.Size = new System.Drawing.Size(174, 29);
			this.rbtnAmerican.TabIndex = 1;
			this.rbtnAmerican.TabStop = true;
			this.rbtnAmerican.Text = "Imperial (ft, lbs) ";
			this.rbtnAmerican.UseVisualStyleBackColor = true;
			this.rbtnAmerican.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rbtnMetric
			// 
			this.rbtnMetric.AutoSize = true;
			this.rbtnMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnMetric.Location = new System.Drawing.Point(21, 34);
			this.rbtnMetric.Name = "rbtnMetric";
			this.rbtnMetric.Size = new System.Drawing.Size(166, 29);
			this.rbtnMetric.TabIndex = 0;
			this.rbtnMetric.TabStop = true;
			this.rbtnMetric.Text = "Metric (kg, cm)";
			this.rbtnMetric.UseVisualStyleBackColor = true;
			this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
			// 
			// grpResults
			// 
			this.grpResults.Controls.Add(this.label2);
			this.grpResults.Controls.Add(this.lblBMI);
			this.grpResults.Controls.Add(this.label4);
			this.grpResults.Controls.Add(this.lblWeightCat);
			this.grpResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpResults.Location = new System.Drawing.Point(45, 227);
			this.grpResults.Name = "grpResults";
			this.grpResults.Size = new System.Drawing.Size(530, 144);
			this.grpResults.TabIndex = 12;
			this.grpResults.TabStop = false;
			this.grpResults.Text = "Results for";
			// 
			// lblWeight
			// 
			this.lblWeight.AutoSize = true;
			this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWeight.Location = new System.Drawing.Point(39, 122);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(74, 25);
			this.lblWeight.TabIndex = 13;
			this.lblWeight.Text = "Weight";
			// 
			// txtWeight
			// 
			this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWeight.Location = new System.Drawing.Point(247, 122);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(100, 30);
			this.txtWeight.TabIndex = 14;
			// 
			// lblNormalWeight
			// 
			this.lblNormalWeight.AutoSize = true;
			this.lblNormalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNormalWeight.ForeColor = System.Drawing.Color.Green;
			this.lblNormalWeight.Location = new System.Drawing.Point(80, 441);
			this.lblNormalWeight.Name = "lblNormalWeight";
			this.lblNormalWeight.Size = new System.Drawing.Size(64, 25);
			this.lblNormalWeight.TabIndex = 15;
			this.lblNormalWeight.Text = "label3";
			this.lblNormalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNormalWeight.Click += new System.EventHandler(this.NormalWeight_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 525);
			this.Controls.Add(this.lblNormalWeight);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.lblWeight);
			this.Controls.Add(this.grpResults);
			this.Controls.Add(this.grpUnit);
			this.Controls.Add(this.lblNormalBMI);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtInch);
			this.Controls.Add(this.txtCmFt);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMI Calculator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.grpUnit.ResumeLayout(false);
			this.grpUnit.PerformLayout();
			this.grpResults.ResumeLayout(false);
			this.grpResults.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.TextBox txtCmFt;
		private System.Windows.Forms.TextBox txtInch;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblBMI;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblWeightCat;
		private System.Windows.Forms.Label lblNormalBMI;
		private System.Windows.Forms.GroupBox grpUnit;
		private System.Windows.Forms.RadioButton rbtnAmerican;
		private System.Windows.Forms.RadioButton rbtnMetric;
		private System.Windows.Forms.GroupBox grpResults;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.Label lblNormalWeight;
	}
}

