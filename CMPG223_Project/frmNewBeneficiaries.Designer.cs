
namespace CMPG223_Project
{
    partial class frmNewBeneficiaries
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.lblCellNum = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtCell = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.grpBenType = new System.Windows.Forms.GroupBox();
			this.cmbBenType = new System.Windows.Forms.ComboBox();
			this.lblType = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblNotes = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.grpBenDetails = new System.Windows.Forms.GroupBox();
			this.lblInstructHeading = new System.Windows.Forms.Label();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.grpBenType.SuspendLayout();
			this.grpBenDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(144, 237);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(318, 27);
			this.txtEmail.TabIndex = 5;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(20, 40);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(56, 19);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSurname.Location = new System.Drawing.Point(20, 90);
			this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(78, 19);
			this.lblSurname.TabIndex = 0;
			this.lblSurname.Text = "Surname:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(20, 140);
			this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(94, 19);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID Number:";
			// 
			// lblCellNum
			// 
			this.lblCellNum.AutoSize = true;
			this.lblCellNum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCellNum.Location = new System.Drawing.Point(20, 190);
			this.lblCellNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCellNum.Name = "lblCellNum";
			this.lblCellNum.Size = new System.Drawing.Size(103, 19);
			this.lblCellNum.TabIndex = 0;
			this.lblCellNum.Text = "Cell Number:";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(296, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Add New Beneficiary";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(20, 240);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(116, 19);
			this.lblEmail.TabIndex = 0;
			this.lblEmail.Text = "Email Address:";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(588, 367);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(250, 55);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add New Beneficiary";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtCell
			// 
			this.txtCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCell.Location = new System.Drawing.Point(144, 187);
			this.txtCell.Margin = new System.Windows.Forms.Padding(4);
			this.txtCell.MaxLength = 10;
			this.txtCell.Name = "txtCell";
			this.txtCell.Size = new System.Drawing.Size(318, 27);
			this.txtCell.TabIndex = 4;
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSurname.Location = new System.Drawing.Point(144, 87);
			this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(318, 27);
			this.txtSurname.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(144, 37);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(318, 27);
			this.txtName.TabIndex = 1;
			// 
			// grpBenType
			// 
			this.grpBenType.Controls.Add(this.lblInstructions);
			this.grpBenType.Controls.Add(this.lblInstructHeading);
			this.grpBenType.Controls.Add(this.cmbBenType);
			this.grpBenType.Controls.Add(this.lblType);
			this.grpBenType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBenType.Location = new System.Drawing.Point(512, 95);
			this.grpBenType.Margin = new System.Windows.Forms.Padding(4);
			this.grpBenType.Name = "grpBenType";
			this.grpBenType.Padding = new System.Windows.Forms.Padding(4);
			this.grpBenType.Size = new System.Drawing.Size(409, 232);
			this.grpBenType.TabIndex = 0;
			this.grpBenType.TabStop = false;
			this.grpBenType.Text = "Beneficiary Type (based on main beneficiary)";
			// 
			// cmbBenType
			// 
			this.cmbBenType.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbBenType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbBenType.FormattingEnabled = true;
			this.cmbBenType.Items.AddRange(new object[] {
            "Select Beneficiary Type",
            "Single Adult",
            "Family with Children",
            "Single Parent",
            "Couple",
            "Youth (18-24)",
            "Senior (65+)",
            "Person with Disability"});
			this.cmbBenType.Location = new System.Drawing.Point(76, 147);
			this.cmbBenType.Name = "cmbBenType";
			this.cmbBenType.Size = new System.Drawing.Size(318, 27);
			this.cmbBenType.TabIndex = 7;
			this.cmbBenType.Text = "Select Beneficiary Type";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.Location = new System.Drawing.Point(20, 150);
			this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(50, 19);
			this.lblType.TabIndex = 0;
			this.lblType.Text = "Type:";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(144, 287);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(318, 27);
			this.txtDescription.TabIndex = 6;
			// 
			// lblNotes
			// 
			this.lblNotes.AutoSize = true;
			this.lblNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNotes.Location = new System.Drawing.Point(20, 290);
			this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(60, 19);
			this.lblNotes.TabIndex = 0;
			this.lblNotes.Text = "Notes: ";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(144, 137);
			this.txtID.Margin = new System.Windows.Forms.Padding(4);
			this.txtID.MaxLength = 13;
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(318, 27);
			this.txtID.TabIndex = 3;
			// 
			// grpBenDetails
			// 
			this.grpBenDetails.Controls.Add(this.lblName);
			this.grpBenDetails.Controls.Add(this.txtEmail);
			this.grpBenDetails.Controls.Add(this.txtCell);
			this.grpBenDetails.Controls.Add(this.lblEmail);
			this.grpBenDetails.Controls.Add(this.txtID);
			this.grpBenDetails.Controls.Add(this.txtDescription);
			this.grpBenDetails.Controls.Add(this.lblCellNum);
			this.grpBenDetails.Controls.Add(this.txtSurname);
			this.grpBenDetails.Controls.Add(this.lblID);
			this.grpBenDetails.Controls.Add(this.lblNotes);
			this.grpBenDetails.Controls.Add(this.txtName);
			this.grpBenDetails.Controls.Add(this.lblSurname);
			this.grpBenDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBenDetails.Location = new System.Drawing.Point(18, 95);
			this.grpBenDetails.Margin = new System.Windows.Forms.Padding(4);
			this.grpBenDetails.Name = "grpBenDetails";
			this.grpBenDetails.Padding = new System.Windows.Forms.Padding(4);
			this.grpBenDetails.Size = new System.Drawing.Size(474, 344);
			this.grpBenDetails.TabIndex = 0;
			this.grpBenDetails.TabStop = false;
			this.grpBenDetails.Text = "Main Beneficiary Info";
			// 
			// lblInstructHeading
			// 
			this.lblInstructHeading.AutoSize = true;
			this.lblInstructHeading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstructHeading.Location = new System.Drawing.Point(20, 40);
			this.lblInstructHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstructHeading.Name = "lblInstructHeading";
			this.lblInstructHeading.Size = new System.Drawing.Size(112, 19);
			this.lblInstructHeading.TabIndex = 0;
			this.lblInstructHeading.Text = "Instructions:";
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstructions.Location = new System.Drawing.Point(20, 69);
			this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(351, 38);
			this.lblInstructions.TabIndex = 8;
			this.lblInstructions.Text = "Choose the beneficiary type based on the info of\r\nthe main beneficiary\'s informat" +
    "ion.\r\n";
			// 
			// frmNewBeneficiaries
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 466);
			this.Controls.Add(this.grpBenDetails);
			this.Controls.Add(this.grpBenType);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblHeader);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmNewBeneficiaries";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Beneficiary";
			this.grpBenType.ResumeLayout(false);
			this.grpBenType.PerformLayout();
			this.grpBenDetails.ResumeLayout(false);
			this.grpBenDetails.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCellNum;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpBenType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.GroupBox grpBenDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbBenType;
		private System.Windows.Forms.Label lblInstructHeading;
		private System.Windows.Forms.Label lblInstructions;
	}
}