
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCellNum = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCell = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpBenType = new System.Windows.Forms.GroupBox();
            this.nudMaxAge = new System.Windows.Forms.NumericUpDown();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.grpBenDetails = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbBenType = new System.Windows.Forms.ComboBox();
            this.grpBenType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).BeginInit();
            this.grpBenDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 237);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(250, 27);
            this.tbEmail.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
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
            this.btnAdd.Location = new System.Drawing.Point(592, 335);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 55);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New Beneficiary";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(144, 187);
            this.tbCell.Margin = new System.Windows.Forms.Padding(4);
            this.tbCell.MaxLength = 10;
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(250, 27);
            this.tbCell.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(144, 87);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(250, 27);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpBenType
            // 
            this.grpBenType.Controls.Add(this.cmbBenType);
            this.grpBenType.Controls.Add(this.lblType);
            this.grpBenType.Controls.Add(this.nudMaxAge);
            this.grpBenType.Controls.Add(this.rdoMale);
            this.grpBenType.Controls.Add(this.rdoFemale);
            this.grpBenType.Controls.Add(this.tbDescription);
            this.grpBenType.Controls.Add(this.lblMaxAge);
            this.grpBenType.Controls.Add(this.lblGender);
            this.grpBenType.Controls.Add(this.lblDescription);
            this.grpBenType.Location = new System.Drawing.Point(512, 95);
            this.grpBenType.Margin = new System.Windows.Forms.Padding(4);
            this.grpBenType.Name = "grpBenType";
            this.grpBenType.Padding = new System.Windows.Forms.Padding(4);
            this.grpBenType.Size = new System.Drawing.Size(409, 232);
            this.grpBenType.TabIndex = 0;
            this.grpBenType.TabStop = false;
            this.grpBenType.Text = "Beneficiary Type";
            // 
            // nudMaxAge
            // 
            this.nudMaxAge.Location = new System.Drawing.Point(145, 187);
            this.nudMaxAge.Margin = new System.Windows.Forms.Padding(4);
            this.nudMaxAge.Name = "nudMaxAge";
            this.nudMaxAge.Size = new System.Drawing.Size(77, 27);
            this.nudMaxAge.TabIndex = 9;
            this.nudMaxAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(245, 133);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(59, 23);
            this.rdoMale.TabIndex = 8;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(145, 133);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(77, 23);
            this.rdoFemale.TabIndex = 7;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(145, 82);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(250, 27);
            this.tbDescription.TabIndex = 6;
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.AutoSize = true;
            this.lblMaxAge.Location = new System.Drawing.Point(20, 190);
            this.lblMaxAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(117, 19);
            this.lblMaxAge.TabIndex = 0;
            this.lblMaxAge.Text = "Maximum Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 137);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 19);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 87);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 19);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description: ";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(144, 137);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.MaxLength = 13;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(250, 27);
            this.tbID.TabIndex = 3;
            // 
            // grpBenDetails
            // 
            this.grpBenDetails.Controls.Add(this.lblName);
            this.grpBenDetails.Controls.Add(this.tbEmail);
            this.grpBenDetails.Controls.Add(this.tbCell);
            this.grpBenDetails.Controls.Add(this.lblEmail);
            this.grpBenDetails.Controls.Add(this.tbID);
            this.grpBenDetails.Controls.Add(this.lblCellNum);
            this.grpBenDetails.Controls.Add(this.txtSurname);
            this.grpBenDetails.Controls.Add(this.lblID);
            this.grpBenDetails.Controls.Add(this.txtName);
            this.grpBenDetails.Controls.Add(this.lblSurname);
            this.grpBenDetails.Location = new System.Drawing.Point(18, 95);
            this.grpBenDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpBenDetails.Name = "grpBenDetails";
            this.grpBenDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpBenDetails.Size = new System.Drawing.Size(446, 289);
            this.grpBenDetails.TabIndex = 0;
            this.grpBenDetails.TabStop = false;
            this.grpBenDetails.Text = "Beneficiary Type";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 37);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 19);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
            // 
            // cmbBenType
            // 
            this.cmbBenType.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.cmbBenType.Location = new System.Drawing.Point(145, 34);
            this.cmbBenType.Name = "cmbBenType";
            this.cmbBenType.Size = new System.Drawing.Size(202, 27);
            this.cmbBenType.TabIndex = 13;
            this.cmbBenType.Text = "Select Beneficiary Type";
            // 
            // frmNewBeneficiaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 434);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).EndInit();
            this.grpBenDetails.ResumeLayout(false);
            this.grpBenDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCellNum;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpBenType;
        private System.Windows.Forms.NumericUpDown nudMaxAge;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblMaxAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbID;
		private System.Windows.Forms.GroupBox grpBenDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbBenType;
    }
}