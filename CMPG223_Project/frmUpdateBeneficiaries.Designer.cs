
namespace CMPG223_Project
{
    partial class frmUpdateBeneficiaries
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCellNum = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbID = new System.Windows.Forms.TextBox();
			this.tbCell = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbBenId = new System.Windows.Forms.TextBox();
			this.lblBenID = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(298, 413);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(200, 55);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update Beneficiary";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(18, 345);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(116, 19);
			this.lblEmail.TabIndex = 0;
			this.lblEmail.Text = "Email Address:";
			// 
			// lblCellNum
			// 
			this.lblCellNum.AutoSize = true;
			this.lblCellNum.Location = new System.Drawing.Point(18, 295);
			this.lblCellNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCellNum.Name = "lblCellNum";
			this.lblCellNum.Size = new System.Drawing.Size(103, 19);
			this.lblCellNum.TabIndex = 0;
			this.lblCellNum.Text = "Cell Number:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(18, 245);
			this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(94, 19);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID Number:";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Location = new System.Drawing.Point(18, 195);
			this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(78, 19);
			this.lblSurname.TabIndex = 0;
			this.lblSurname.Text = "Surname:";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(410, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Update Main Beneficiary Info";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(18, 145);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(56, 19);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(162, 142);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(309, 27);
			this.tbName.TabIndex = 3;
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(162, 192);
			this.tbSurname.Margin = new System.Windows.Forms.Padding(4);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(309, 27);
			this.tbSurname.TabIndex = 4;
			// 
			// tbID
			// 
			this.tbID.Location = new System.Drawing.Point(162, 242);
			this.tbID.Margin = new System.Windows.Forms.Padding(4);
			this.tbID.Name = "tbID";
			this.tbID.Size = new System.Drawing.Size(309, 27);
			this.tbID.TabIndex = 5;
			// 
			// tbCell
			// 
			this.tbCell.Location = new System.Drawing.Point(162, 292);
			this.tbCell.Margin = new System.Windows.Forms.Padding(4);
			this.tbCell.Name = "tbCell";
			this.tbCell.Size = new System.Drawing.Size(309, 27);
			this.tbCell.TabIndex = 6;
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(162, 342);
			this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(309, 27);
			this.tbEmail.TabIndex = 7;
			// 
			// tbBenId
			// 
			this.tbBenId.Location = new System.Drawing.Point(162, 92);
			this.tbBenId.Margin = new System.Windows.Forms.Padding(4);
			this.tbBenId.Name = "tbBenId";
			this.tbBenId.Size = new System.Drawing.Size(126, 27);
			this.tbBenId.TabIndex = 1;
			// 
			// lblBenID
			// 
			this.lblBenID.AutoSize = true;
			this.lblBenID.Location = new System.Drawing.Point(18, 95);
			this.lblBenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBenID.Name = "lblBenID";
			this.lblBenID.Size = new System.Drawing.Size(113, 19);
			this.lblBenID.TabIndex = 0;
			this.lblBenID.Text = "Beneficiary ID:";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(296, 86);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 37);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search beneficiary";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(43, 413);
			this.btnClear.Margin = new System.Windows.Forms.Padding(4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(200, 55);
			this.btnClear.TabIndex = 14;
			this.btnClear.Text = "Clear Form";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmUpdateBeneficiaries
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 507);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblCellNum);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.lblSurname);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblBenID);
			this.Controls.Add(this.tbBenId);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbID);
			this.Controls.Add(this.tbCell);
			this.Controls.Add(this.tbEmail);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmUpdateBeneficiaries";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Beneficiaries";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellNum;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBenId;
        private System.Windows.Forms.Label lblBenID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
	}
}