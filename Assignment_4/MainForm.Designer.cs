
namespace Assignment_4
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
			this.grpParty = new System.Windows.Forms.GroupBox();
			this.btnCreateList = new System.Windows.Forms.Button();
			this.txtFeePerPerson = new System.Windows.Forms.TextBox();
			this.lblFeePerPerson = new System.Windows.Forms.Label();
			this.txtCostPerPerson = new System.Windows.Forms.TextBox();
			this.lblCostPerPerson = new System.Windows.Forms.Label();
			this.txtMaxNumOfGuests = new System.Windows.Forms.TextBox();
			this.lblMaxNumOfGuests = new System.Windows.Forms.Label();
			this.grpInvite = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblNumOfGuests = new System.Windows.Forms.Label();
			this.lblTotalCost = new System.Windows.Forms.Label();
			this.lblTotalFees = new System.Windows.Forms.Label();
			this.lblSurDef = new System.Windows.Forms.Label();
			this.lblNumOfGuestsOut = new System.Windows.Forms.Label();
			this.lblTotalCostOut = new System.Windows.Forms.Label();
			this.lblTotalFeesOut = new System.Windows.Forms.Label();
			this.lblSurDefOut = new System.Windows.Forms.Label();
			this.lstAllGuests = new System.Windows.Forms.ListBox();
			this.lblGuestList = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.grpParty.SuspendLayout();
			this.grpInvite.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpParty
			// 
			this.grpParty.Controls.Add(this.btnCreateList);
			this.grpParty.Controls.Add(this.txtFeePerPerson);
			this.grpParty.Controls.Add(this.lblFeePerPerson);
			this.grpParty.Controls.Add(this.txtCostPerPerson);
			this.grpParty.Controls.Add(this.lblCostPerPerson);
			this.grpParty.Controls.Add(this.txtMaxNumOfGuests);
			this.grpParty.Controls.Add(this.lblMaxNumOfGuests);
			this.grpParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpParty.Location = new System.Drawing.Point(12, 12);
			this.grpParty.Name = "grpParty";
			this.grpParty.Size = new System.Drawing.Size(406, 237);
			this.grpParty.TabIndex = 0;
			this.grpParty.TabStop = false;
			this.grpParty.Text = "New Party";
			// 
			// btnCreateList
			// 
			this.btnCreateList.Location = new System.Drawing.Point(130, 181);
			this.btnCreateList.Name = "btnCreateList";
			this.btnCreateList.Size = new System.Drawing.Size(141, 39);
			this.btnCreateList.TabIndex = 6;
			this.btnCreateList.Text = "Create list";
			this.btnCreateList.UseVisualStyleBackColor = true;
			this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
			// 
			// txtFeePerPerson
			// 
			this.txtFeePerPerson.Location = new System.Drawing.Point(230, 132);
			this.txtFeePerPerson.Name = "txtFeePerPerson";
			this.txtFeePerPerson.Size = new System.Drawing.Size(118, 30);
			this.txtFeePerPerson.TabIndex = 5;
			// 
			// lblFeePerPerson
			// 
			this.lblFeePerPerson.AutoSize = true;
			this.lblFeePerPerson.Location = new System.Drawing.Point(11, 135);
			this.lblFeePerPerson.Name = "lblFeePerPerson";
			this.lblFeePerPerson.Size = new System.Drawing.Size(144, 25);
			this.lblFeePerPerson.TabIndex = 4;
			this.lblFeePerPerson.Text = "Fee per person";
			this.lblFeePerPerson.Click += new System.EventHandler(this.lblFeePerPerson_Click);
			// 
			// txtCostPerPerson
			// 
			this.txtCostPerPerson.Location = new System.Drawing.Point(230, 93);
			this.txtCostPerPerson.Name = "txtCostPerPerson";
			this.txtCostPerPerson.Size = new System.Drawing.Size(118, 30);
			this.txtCostPerPerson.TabIndex = 3;
			// 
			// lblCostPerPerson
			// 
			this.lblCostPerPerson.AutoSize = true;
			this.lblCostPerPerson.Location = new System.Drawing.Point(11, 93);
			this.lblCostPerPerson.Name = "lblCostPerPerson";
			this.lblCostPerPerson.Size = new System.Drawing.Size(151, 25);
			this.lblCostPerPerson.TabIndex = 2;
			this.lblCostPerPerson.Text = "Cost per person";
			// 
			// txtMaxNumOfGuests
			// 
			this.txtMaxNumOfGuests.Location = new System.Drawing.Point(230, 45);
			this.txtMaxNumOfGuests.Name = "txtMaxNumOfGuests";
			this.txtMaxNumOfGuests.Size = new System.Drawing.Size(118, 30);
			this.txtMaxNumOfGuests.TabIndex = 1;
			// 
			// lblMaxNumOfGuests
			// 
			this.lblMaxNumOfGuests.AutoSize = true;
			this.lblMaxNumOfGuests.Location = new System.Drawing.Point(6, 45);
			this.lblMaxNumOfGuests.Name = "lblMaxNumOfGuests";
			this.lblMaxNumOfGuests.Size = new System.Drawing.Size(205, 25);
			this.lblMaxNumOfGuests.TabIndex = 0;
			this.lblMaxNumOfGuests.Text = "Max number of guests";
			this.lblMaxNumOfGuests.Click += new System.EventHandler(this.label1_Click);
			// 
			// grpInvite
			// 
			this.grpInvite.Controls.Add(this.btnAdd);
			this.grpInvite.Controls.Add(this.txtLastName);
			this.grpInvite.Controls.Add(this.lblLastName);
			this.grpInvite.Controls.Add(this.txtFirstName);
			this.grpInvite.Controls.Add(this.lblFirstName);
			this.grpInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpInvite.Location = new System.Drawing.Point(12, 266);
			this.grpInvite.Name = "grpInvite";
			this.grpInvite.Size = new System.Drawing.Size(412, 198);
			this.grpInvite.TabIndex = 1;
			this.grpInvite.TabStop = false;
			this.grpInvite.Text = "Invite Guest";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(130, 143);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(141, 37);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(130, 95);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(210, 30);
			this.txtLastName.TabIndex = 3;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(11, 100);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(106, 25);
			this.lblLastName.TabIndex = 2;
			this.lblLastName.Text = "Last Name";
			this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(130, 48);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(210, 30);
			this.txtFirstName.TabIndex = 1;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(11, 48);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(106, 25);
			this.lblFirstName.TabIndex = 0;
			this.lblFirstName.Text = "First Name";
			this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
			// 
			// lblNumOfGuests
			// 
			this.lblNumOfGuests.AutoSize = true;
			this.lblNumOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumOfGuests.Location = new System.Drawing.Point(23, 484);
			this.lblNumOfGuests.Name = "lblNumOfGuests";
			this.lblNumOfGuests.Size = new System.Drawing.Size(174, 25);
			this.lblNumOfGuests.TabIndex = 2;
			this.lblNumOfGuests.Text = "Number Of Guests";
			this.lblNumOfGuests.Click += new System.EventHandler(this.lblNumOfGuests_Click);
			// 
			// lblTotalCost
			// 
			this.lblTotalCost.AutoSize = true;
			this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCost.Location = new System.Drawing.Point(23, 527);
			this.lblTotalCost.Name = "lblTotalCost";
			this.lblTotalCost.Size = new System.Drawing.Size(102, 25);
			this.lblTotalCost.TabIndex = 3;
			this.lblTotalCost.Text = "Total Cost";
			// 
			// lblTotalFees
			// 
			this.lblTotalFees.AutoSize = true;
			this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalFees.Location = new System.Drawing.Point(23, 561);
			this.lblTotalFees.Name = "lblTotalFees";
			this.lblTotalFees.Size = new System.Drawing.Size(105, 25);
			this.lblTotalFees.TabIndex = 4;
			this.lblTotalFees.Text = "Total Fees";
			// 
			// lblSurDef
			// 
			this.lblSurDef.AutoSize = true;
			this.lblSurDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSurDef.Location = new System.Drawing.Point(23, 603);
			this.lblSurDef.Name = "lblSurDef";
			this.lblSurDef.Size = new System.Drawing.Size(135, 25);
			this.lblSurDef.TabIndex = 5;
			this.lblSurDef.Text = "Surplus/deficit";
			// 
			// lblNumOfGuestsOut
			// 
			this.lblNumOfGuestsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumOfGuestsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumOfGuestsOut.Location = new System.Drawing.Point(276, 479);
			this.lblNumOfGuestsOut.Name = "lblNumOfGuestsOut";
			this.lblNumOfGuestsOut.Size = new System.Drawing.Size(148, 35);
			this.lblNumOfGuestsOut.TabIndex = 6;
			this.lblNumOfGuestsOut.Text = "label5";
			this.lblNumOfGuestsOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalCostOut
			// 
			this.lblTotalCostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotalCostOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCostOut.Location = new System.Drawing.Point(276, 527);
			this.lblTotalCostOut.Name = "lblTotalCostOut";
			this.lblTotalCostOut.Size = new System.Drawing.Size(148, 36);
			this.lblTotalCostOut.TabIndex = 7;
			this.lblTotalCostOut.Text = "label6";
			this.lblTotalCostOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblTotalCostOut.Click += new System.EventHandler(this.label6_Click);
			// 
			// lblTotalFeesOut
			// 
			this.lblTotalFeesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotalFeesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalFeesOut.Location = new System.Drawing.Point(276, 576);
			this.lblTotalFeesOut.Name = "lblTotalFeesOut";
			this.lblTotalFeesOut.Size = new System.Drawing.Size(148, 36);
			this.lblTotalFeesOut.TabIndex = 8;
			this.lblTotalFeesOut.Text = "label7";
			this.lblTotalFeesOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblTotalFeesOut.Click += new System.EventHandler(this.label7_Click);
			// 
			// lblSurDefOut
			// 
			this.lblSurDefOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSurDefOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSurDefOut.Location = new System.Drawing.Point(276, 624);
			this.lblSurDefOut.Name = "lblSurDefOut";
			this.lblSurDefOut.Size = new System.Drawing.Size(148, 35);
			this.lblSurDefOut.TabIndex = 9;
			this.lblSurDefOut.Text = "label8";
			this.lblSurDefOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblSurDefOut.Click += new System.EventHandler(this.lblSurDefOut_Click);
			// 
			// lstAllGuests
			// 
			this.lstAllGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstAllGuests.FormattingEnabled = true;
			this.lstAllGuests.ItemHeight = 25;
			this.lstAllGuests.Location = new System.Drawing.Point(451, 40);
			this.lstAllGuests.Name = "lstAllGuests";
			this.lstAllGuests.Size = new System.Drawing.Size(323, 479);
			this.lstAllGuests.TabIndex = 10;
			// 
			// lblGuestList
			// 
			this.lblGuestList.AutoSize = true;
			this.lblGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuestList.Location = new System.Drawing.Point(562, 12);
			this.lblGuestList.Name = "lblGuestList";
			this.lblGuestList.Size = new System.Drawing.Size(99, 25);
			this.lblGuestList.TabIndex = 11;
			this.lblGuestList.Text = "Guest List";
			this.lblGuestList.Click += new System.EventHandler(this.lblGuestList_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnDelete.Location = new System.Drawing.Point(631, 545);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(122, 41);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 679);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lblGuestList);
			this.Controls.Add(this.lstAllGuests);
			this.Controls.Add(this.lblSurDefOut);
			this.Controls.Add(this.lblTotalFeesOut);
			this.Controls.Add(this.lblTotalCostOut);
			this.Controls.Add(this.lblNumOfGuestsOut);
			this.Controls.Add(this.lblSurDef);
			this.Controls.Add(this.lblTotalFees);
			this.Controls.Add(this.lblTotalCost);
			this.Controls.Add(this.lblNumOfGuests);
			this.Controls.Add(this.grpInvite);
			this.Controls.Add(this.grpParty);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Party Organizer by Josefin Salomaa";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.grpParty.ResumeLayout(false);
			this.grpParty.PerformLayout();
			this.grpInvite.ResumeLayout(false);
			this.grpInvite.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpParty;
		private System.Windows.Forms.TextBox txtMaxNumOfGuests;
		private System.Windows.Forms.Label lblMaxNumOfGuests;
		private System.Windows.Forms.Label lblCostPerPerson;
		private System.Windows.Forms.TextBox txtFeePerPerson;
		private System.Windows.Forms.Label lblFeePerPerson;
		private System.Windows.Forms.TextBox txtCostPerPerson;
		private System.Windows.Forms.Button btnCreateList;
		private System.Windows.Forms.GroupBox grpInvite;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblNumOfGuests;
		private System.Windows.Forms.Label lblTotalCost;
		private System.Windows.Forms.Label lblTotalFees;
		private System.Windows.Forms.Label lblSurDef;
		private System.Windows.Forms.Label lblNumOfGuestsOut;
		private System.Windows.Forms.Label lblTotalCostOut;
		private System.Windows.Forms.Label lblTotalFeesOut;
		private System.Windows.Forms.Label lblSurDefOut;
		private System.Windows.Forms.ListBox lstAllGuests;
		private System.Windows.Forms.Label lblGuestList;
		private System.Windows.Forms.Button btnDelete;
	}
}

