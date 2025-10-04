
namespace CMPG223_Project
{
    partial class frmReports
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
			this.lblHeader = new System.Windows.Forms.Label();
			this.rdoNumOfBen = new System.Windows.Forms.RadioButton();
			this.rdoNumOfBenTypes = new System.Windows.Forms.RadioButton();
			this.lstReport = new System.Windows.Forms.ListBox();
			this.btnReport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(397, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Pick report type to generate";
			// 
			// rdoNumOfBen
			// 
			this.rdoNumOfBen.AutoSize = true;
			this.rdoNumOfBen.Location = new System.Drawing.Point(18, 75);
			this.rdoNumOfBen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdoNumOfBen.Name = "rdoNumOfBen";
			this.rdoNumOfBen.Size = new System.Drawing.Size(245, 23);
			this.rdoNumOfBen.TabIndex = 1;
			this.rdoNumOfBen.TabStop = true;
			this.rdoNumOfBen.Text = "Number of beneficiaries visited";
			this.rdoNumOfBen.UseVisualStyleBackColor = true;
			this.rdoNumOfBen.CheckedChanged += new System.EventHandler(this.rbNumBeneficiaries_CheckedChanged);
			// 
			// rdoNumOfBenTypes
			// 
			this.rdoNumOfBenTypes.AutoSize = true;
			this.rdoNumOfBenTypes.Location = new System.Drawing.Point(18, 110);
			this.rdoNumOfBenTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdoNumOfBenTypes.Name = "rdoNumOfBenTypes";
			this.rdoNumOfBenTypes.Size = new System.Drawing.Size(276, 23);
			this.rdoNumOfBenTypes.TabIndex = 2;
			this.rdoNumOfBenTypes.TabStop = true;
			this.rdoNumOfBenTypes.Text = "Number of beneficiary types visited";
			this.rdoNumOfBenTypes.UseVisualStyleBackColor = true;
			this.rdoNumOfBenTypes.CheckedChanged += new System.EventHandler(this.rbNumBeneficiaries_CheckedChanged);
			// 
			// lstReport
			// 
			this.lstReport.FormattingEnabled = true;
			this.lstReport.ItemHeight = 19;
			this.lstReport.Location = new System.Drawing.Point(13, 150);
			this.lstReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lstReport.Name = "lstReport";
			this.lstReport.Size = new System.Drawing.Size(558, 593);
			this.lstReport.TabIndex = 4;
			// 
			// btnReport
			// 
			this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport.Location = new System.Drawing.Point(321, 78);
			this.btnReport.Margin = new System.Windows.Forms.Padding(4);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(250, 55);
			this.btnReport.TabIndex = 3;
			this.btnReport.Text = "Generate Report";
			this.btnReport.UseVisualStyleBackColor = true;
			// 
			// frmReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 761);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.lstReport);
			this.Controls.Add(this.rdoNumOfBenTypes);
			this.Controls.Add(this.rdoNumOfBen);
			this.Controls.Add(this.lblHeader);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmReports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton rdoNumOfBen;
        private System.Windows.Forms.RadioButton rdoNumOfBenTypes;
        private System.Windows.Forms.ListBox lstReport;
		private System.Windows.Forms.Button btnReport;
	}
}