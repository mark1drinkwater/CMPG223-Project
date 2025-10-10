
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblHeader = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnExportCsv = new System.Windows.Forms.Button();
			this.lblStatusStatic = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.grpDistinctVisits = new System.Windows.Forms.GroupBox();
			this.lblPastYear = new System.Windows.Forms.Label();
			this.lblPastYearCount = new System.Windows.Forms.Label();
			this.lblPast6MonthsCount = new System.Windows.Forms.Label();
			this.lblPast6Months = new System.Windows.Forms.Label();
			this.lblPastMonthCount = new System.Windows.Forms.Label();
			this.lblPastMonth = new System.Windows.Forms.Label();
			this.grpMostVisited = new System.Windows.Forms.GroupBox();
			this.dgvTopTypes = new System.Windows.Forms.DataGridView();
			this.grpLeastVisited = new System.Windows.Forms.GroupBox();
			this.dgvLeastTypes = new System.Windows.Forms.DataGridView();
			this.grpZeroVisited = new System.Windows.Forms.GroupBox();
			this.dgvZeroTypes = new System.Windows.Forms.DataGridView();
			this.grpDistinctVisits.SuspendLayout();
			this.grpMostVisited.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTopTypes)).BeginInit();
			this.grpLeastVisited.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLeastTypes)).BeginInit();
			this.grpZeroVisited.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvZeroTypes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(360, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(227, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Shelter Reports";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(19, 65);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(165, 35);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Generate reports";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnExportCsv
			// 
			this.btnExportCsv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportCsv.Location = new System.Drawing.Point(200, 65);
			this.btnExportCsv.Name = "btnExportCsv";
			this.btnExportCsv.Size = new System.Drawing.Size(165, 35);
			this.btnExportCsv.TabIndex = 2;
			this.btnExportCsv.Text = "Export to CSV";
			this.btnExportCsv.UseVisualStyleBackColor = true;
			this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
			// 
			// lblStatusStatic
			// 
			this.lblStatusStatic.AutoSize = true;
			this.lblStatusStatic.Location = new System.Drawing.Point(625, 73);
			this.lblStatusStatic.Name = "lblStatusStatic";
			this.lblStatusStatic.Size = new System.Drawing.Size(63, 19);
			this.lblStatusStatic.TabIndex = 0;
			this.lblStatusStatic.Text = "Status: ";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(694, 73);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(67, 19);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Ready...";
			// 
			// grpDistinctVisits
			// 
			this.grpDistinctVisits.Controls.Add(this.lblPastMonthCount);
			this.grpDistinctVisits.Controls.Add(this.lblPastMonth);
			this.grpDistinctVisits.Controls.Add(this.lblPast6MonthsCount);
			this.grpDistinctVisits.Controls.Add(this.lblPast6Months);
			this.grpDistinctVisits.Controls.Add(this.lblPastYearCount);
			this.grpDistinctVisits.Controls.Add(this.lblPastYear);
			this.grpDistinctVisits.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpDistinctVisits.Location = new System.Drawing.Point(19, 120);
			this.grpDistinctVisits.Name = "grpDistinctVisits";
			this.grpDistinctVisits.Size = new System.Drawing.Size(953, 120);
			this.grpDistinctVisits.TabIndex = 0;
			this.grpDistinctVisits.TabStop = false;
			this.grpDistinctVisits.Text = "Total distinct benefiaries visits";
			// 
			// lblPastYear
			// 
			this.lblPastYear.AutoSize = true;
			this.lblPastYear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPastYear.Location = new System.Drawing.Point(67, 43);
			this.lblPastYear.Name = "lblPastYear";
			this.lblPastYear.Size = new System.Drawing.Size(150, 19);
			this.lblPastYear.TabIndex = 0;
			this.lblPastYear.Text = "Total (Past Year)";
			// 
			// lblPastYearCount
			// 
			this.lblPastYearCount.AutoSize = true;
			this.lblPastYearCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPastYearCount.Location = new System.Drawing.Point(67, 72);
			this.lblPastYearCount.Name = "lblPastYearCount";
			this.lblPastYearCount.Size = new System.Drawing.Size(128, 19);
			this.lblPastYearCount.TabIndex = 0;
			this.lblPastYearCount.Text = "Total (Past Year)";
			// 
			// lblPast6MonthsCount
			// 
			this.lblPast6MonthsCount.AutoSize = true;
			this.lblPast6MonthsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPast6MonthsCount.Location = new System.Drawing.Point(407, 72);
			this.lblPast6MonthsCount.Name = "lblPast6MonthsCount";
			this.lblPast6MonthsCount.Size = new System.Drawing.Size(161, 19);
			this.lblPast6MonthsCount.TabIndex = 0;
			this.lblPast6MonthsCount.Text = "Total (Past 6 Months)";
			// 
			// lblPast6Months
			// 
			this.lblPast6Months.AutoSize = true;
			this.lblPast6Months.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPast6Months.Location = new System.Drawing.Point(407, 43);
			this.lblPast6Months.Name = "lblPast6Months";
			this.lblPast6Months.Size = new System.Drawing.Size(186, 19);
			this.lblPast6Months.TabIndex = 0;
			this.lblPast6Months.Text = "Total (Past 6 Months)";
			// 
			// lblPastMonthCount
			// 
			this.lblPastMonthCount.AutoSize = true;
			this.lblPastMonthCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPastMonthCount.Location = new System.Drawing.Point(718, 72);
			this.lblPastMonthCount.Name = "lblPastMonthCount";
			this.lblPastMonthCount.Size = new System.Drawing.Size(140, 19);
			this.lblPastMonthCount.TabIndex = 0;
			this.lblPastMonthCount.Text = "Total (Past Month)";
			// 
			// lblPastMonth
			// 
			this.lblPastMonth.AutoSize = true;
			this.lblPastMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPastMonth.Location = new System.Drawing.Point(718, 43);
			this.lblPastMonth.Name = "lblPastMonth";
			this.lblPastMonth.Size = new System.Drawing.Size(163, 19);
			this.lblPastMonth.TabIndex = 0;
			this.lblPastMonth.Text = "Total (Past Month)";
			// 
			// grpMostVisited
			// 
			this.grpMostVisited.Controls.Add(this.dgvTopTypes);
			this.grpMostVisited.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpMostVisited.Location = new System.Drawing.Point(19, 255);
			this.grpMostVisited.Name = "grpMostVisited";
			this.grpMostVisited.Size = new System.Drawing.Size(953, 174);
			this.grpMostVisited.TabIndex = 0;
			this.grpMostVisited.TabStop = false;
			this.grpMostVisited.Text = "Most visited beneficiary types (past year)";
			// 
			// dgvTopTypes
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvTopTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTopTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTopTypes.Location = new System.Drawing.Point(7, 27);
			this.dgvTopTypes.Name = "dgvTopTypes";
			this.dgvTopTypes.Size = new System.Drawing.Size(940, 141);
			this.dgvTopTypes.TabIndex = 0;
			// 
			// grpLeastVisited
			// 
			this.grpLeastVisited.Controls.Add(this.dgvLeastTypes);
			this.grpLeastVisited.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpLeastVisited.Location = new System.Drawing.Point(19, 440);
			this.grpLeastVisited.Name = "grpLeastVisited";
			this.grpLeastVisited.Size = new System.Drawing.Size(953, 174);
			this.grpLeastVisited.TabIndex = 0;
			this.grpLeastVisited.TabStop = false;
			this.grpLeastVisited.Text = "Least visited beneficiary types (past year) (min 1 visit)";
			// 
			// dgvLeastTypes
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvLeastTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvLeastTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLeastTypes.Location = new System.Drawing.Point(7, 27);
			this.dgvLeastTypes.Name = "dgvLeastTypes";
			this.dgvLeastTypes.Size = new System.Drawing.Size(940, 141);
			this.dgvLeastTypes.TabIndex = 0;
			// 
			// grpZeroVisited
			// 
			this.grpZeroVisited.Controls.Add(this.dgvZeroTypes);
			this.grpZeroVisited.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpZeroVisited.Location = new System.Drawing.Point(19, 625);
			this.grpZeroVisited.Name = "grpZeroVisited";
			this.grpZeroVisited.Size = new System.Drawing.Size(953, 174);
			this.grpZeroVisited.TabIndex = 0;
			this.grpZeroVisited.TabStop = false;
			this.grpZeroVisited.Text = "Beneficiary types with ZERO visits (past year)";
			// 
			// dgvZeroTypes
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvZeroTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvZeroTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvZeroTypes.Location = new System.Drawing.Point(7, 27);
			this.dgvZeroTypes.Name = "dgvZeroTypes";
			this.dgvZeroTypes.Size = new System.Drawing.Size(940, 141);
			this.dgvZeroTypes.TabIndex = 0;
			// 
			// frmReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 811);
			this.Controls.Add(this.grpZeroVisited);
			this.Controls.Add(this.grpLeastVisited);
			this.Controls.Add(this.grpMostVisited);
			this.Controls.Add(this.grpDistinctVisits);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblStatusStatic);
			this.Controls.Add(this.btnExportCsv);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lblHeader);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmReports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.grpDistinctVisits.ResumeLayout(false);
			this.grpDistinctVisits.PerformLayout();
			this.grpMostVisited.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTopTypes)).EndInit();
			this.grpLeastVisited.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLeastTypes)).EndInit();
			this.grpZeroVisited.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvZeroTypes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnExportCsv;
		private System.Windows.Forms.Label lblStatusStatic;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.GroupBox grpDistinctVisits;
		private System.Windows.Forms.Label lblPast6MonthsCount;
		private System.Windows.Forms.Label lblPast6Months;
		private System.Windows.Forms.Label lblPastYearCount;
		private System.Windows.Forms.Label lblPastYear;
		private System.Windows.Forms.Label lblPastMonthCount;
		private System.Windows.Forms.Label lblPastMonth;
		private System.Windows.Forms.GroupBox grpMostVisited;
		private System.Windows.Forms.DataGridView dgvTopTypes;
		private System.Windows.Forms.GroupBox grpLeastVisited;
		private System.Windows.Forms.DataGridView dgvLeastTypes;
		private System.Windows.Forms.GroupBox grpZeroVisited;
		private System.Windows.Forms.DataGridView dgvZeroTypes;
	}
}