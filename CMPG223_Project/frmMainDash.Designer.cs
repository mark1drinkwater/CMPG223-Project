
namespace CMPG223_Project
{
    partial class frmMainDash
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
			this.dgvBookings = new System.Windows.Forms.DataGridView();
			this.mnsOptions = new System.Windows.Forms.MenuStrip();
			this.beneficiaryTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.newBeneficiaryTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.updateBeneficiariesTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.removeBeneficiaryTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.bookingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.newBookingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.updateBookingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.adminTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.newAdminTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.updateAdminTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.removeAdminTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.generateReportsTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.lblFilter = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnDeleteBooking = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
			this.mnsOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvBookings
			// 
			this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBookings.Location = new System.Drawing.Point(12, 31);
			this.dgvBookings.Name = "dgvBookings";
			this.dgvBookings.RowHeadersWidth = 62;
			this.dgvBookings.Size = new System.Drawing.Size(1060, 563);
			this.dgvBookings.TabIndex = 0;
			// 
			// mnsOptions
			// 
			this.mnsOptions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnsOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mnsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminTSMI,
            this.beneficiaryTSMI,
            this.bookingsTSMI,
            this.reportsTSMI,
            this.exitTSMI});
			this.mnsOptions.Location = new System.Drawing.Point(0, 0);
			this.mnsOptions.Name = "mnsOptions";
			this.mnsOptions.Size = new System.Drawing.Size(1084, 27);
			this.mnsOptions.TabIndex = 0;
			this.mnsOptions.Text = "menuStrip1";
			// 
			// beneficiaryTSMI
			// 
			this.beneficiaryTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBeneficiaryTSMI,
            this.removeBeneficiaryTSMI,
            this.updateBeneficiariesTSMI});
			this.beneficiaryTSMI.Name = "beneficiaryTSMI";
			this.beneficiaryTSMI.Size = new System.Drawing.Size(108, 23);
			this.beneficiaryTSMI.Text = "Beneficiaries";
			// 
			// newBeneficiaryTSMI
			// 
			this.newBeneficiaryTSMI.Name = "newBeneficiaryTSMI";
			this.newBeneficiaryTSMI.Size = new System.Drawing.Size(220, 24);
			this.newBeneficiaryTSMI.Text = "New Beneficiary";
			this.newBeneficiaryTSMI.Click += new System.EventHandler(this.newBeneficiaryTSMI_Click);
			// 
			// updateBeneficiariesTSMI
			// 
			this.updateBeneficiariesTSMI.Name = "updateBeneficiariesTSMI";
			this.updateBeneficiariesTSMI.Size = new System.Drawing.Size(220, 24);
			this.updateBeneficiariesTSMI.Text = "Update Beneficiaries";
			this.updateBeneficiariesTSMI.Click += new System.EventHandler(this.updateBeneficiariesTSMI_Click);
			// 
			// removeBeneficiaryTSMI
			// 
			this.removeBeneficiaryTSMI.Name = "removeBeneficiaryTSMI";
			this.removeBeneficiaryTSMI.Size = new System.Drawing.Size(220, 24);
			this.removeBeneficiaryTSMI.Text = "Remove Beneficiary";
			this.removeBeneficiaryTSMI.Click += new System.EventHandler(this.removeBeneficiaryTSMI_Click);
			// 
			// bookingsTSMI
			// 
			this.bookingsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookingsTSMI,
            this.updateBookingsTSMI});
			this.bookingsTSMI.Name = "bookingsTSMI";
			this.bookingsTSMI.Size = new System.Drawing.Size(85, 23);
			this.bookingsTSMI.Text = "Bookings";
			// 
			// newBookingsTSMI
			// 
			this.newBookingsTSMI.Name = "newBookingsTSMI";
			this.newBookingsTSMI.Size = new System.Drawing.Size(197, 24);
			this.newBookingsTSMI.Text = "New Bookings";
			this.newBookingsTSMI.Click += new System.EventHandler(this.newBookingsTSMI_Click);
			// 
			// updateBookingsTSMI
			// 
			this.updateBookingsTSMI.Name = "updateBookingsTSMI";
			this.updateBookingsTSMI.Size = new System.Drawing.Size(197, 24);
			this.updateBookingsTSMI.Text = "Update Bookings";
			this.updateBookingsTSMI.Click += new System.EventHandler(this.updateBookingsTSMI_Click);
			// 
			// adminTSMI
			// 
			this.adminTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdminTSMI,
            this.removeAdminTSMI,
            this.updateAdminTSMI});
			this.adminTSMI.Name = "adminTSMI";
			this.adminTSMI.Size = new System.Drawing.Size(68, 23);
			this.adminTSMI.Text = "Admin";
			// 
			// newAdminTSMI
			// 
			this.newAdminTSMI.Name = "newAdminTSMI";
			this.newAdminTSMI.Size = new System.Drawing.Size(187, 24);
			this.newAdminTSMI.Text = "New Admin";
			this.newAdminTSMI.Click += new System.EventHandler(this.newAdminTSMI_Click);
			// 
			// updateAdminTSMI
			// 
			this.updateAdminTSMI.Name = "updateAdminTSMI";
			this.updateAdminTSMI.Size = new System.Drawing.Size(187, 24);
			this.updateAdminTSMI.Text = "Update Admin";
			this.updateAdminTSMI.Click += new System.EventHandler(this.updateAdminTSMI_Click);
			// 
			// removeAdminTSMI
			// 
			this.removeAdminTSMI.Name = "removeAdminTSMI";
			this.removeAdminTSMI.Size = new System.Drawing.Size(187, 24);
			this.removeAdminTSMI.Text = "Remove Admin";
			this.removeAdminTSMI.Click += new System.EventHandler(this.removeAdminTSMI_Click);
			// 
			// reportsTSMI
			// 
			this.reportsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsTSMI});
			this.reportsTSMI.Name = "reportsTSMI";
			this.reportsTSMI.Size = new System.Drawing.Size(75, 23);
			this.reportsTSMI.Text = "Reports";
			// 
			// generateReportsTSMI
			// 
			this.generateReportsTSMI.Name = "generateReportsTSMI";
			this.generateReportsTSMI.Size = new System.Drawing.Size(196, 24);
			this.generateReportsTSMI.Text = "Generate reports";
			this.generateReportsTSMI.Click += new System.EventHandler(this.generateReportsTSMI_Click);
			// 
			// exitTSMI
			// 
			this.exitTSMI.Name = "exitTSMI";
			this.exitTSMI.Size = new System.Drawing.Size(47, 23);
			this.exitTSMI.Text = "Exit";
			this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
			// 
			// lblFilter
			// 
			this.lblFilter.AutoSize = true;
			this.lblFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFilter.Location = new System.Drawing.Point(12, 619);
			this.lblFilter.Name = "lblFilter";
			this.lblFilter.Size = new System.Drawing.Size(119, 19);
			this.lblFilter.TabIndex = 0;
			this.lblFilter.Text = "Filter bookings:";
			// 
			// txtFilter
			// 
			this.txtFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilter.Location = new System.Drawing.Point(137, 616);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(254, 27);
			this.txtFilter.TabIndex = 1;
			// 
			// btnFilter
			// 
			this.btnFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.Location = new System.Drawing.Point(465, 610);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(175, 37);
			this.btnFilter.TabIndex = 2;
			this.btnFilter.Text = "Filter booking";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnDeleteBooking
			// 
			this.btnDeleteBooking.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteBooking.Location = new System.Drawing.Point(820, 610);
			this.btnDeleteBooking.Name = "btnDeleteBooking";
			this.btnDeleteBooking.Size = new System.Drawing.Size(175, 37);
			this.btnDeleteBooking.TabIndex = 3;
			this.btnDeleteBooking.Text = "Delete booking";
			this.btnDeleteBooking.UseVisualStyleBackColor = true;
			this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
			// 
			// frmMainDash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 661);
			this.Controls.Add(this.btnDeleteBooking);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lblFilter);
			this.Controls.Add(this.dgvBookings);
			this.Controls.Add(this.mnsOptions);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.mnsOptions;
			this.Name = "frmMainDash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bookings Dashboard";
			this.Load += new System.EventHandler(this.frmMainDash_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
			this.mnsOptions.ResumeLayout(false);
			this.mnsOptions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.MenuStrip mnsOptions;
        private System.Windows.Forms.ToolStripMenuItem beneficiaryTSMI;
        private System.Windows.Forms.ToolStripMenuItem newBeneficiaryTSMI;
        private System.Windows.Forms.ToolStripMenuItem adminTSMI;
        private System.Windows.Forms.ToolStripMenuItem newAdminTSMI;
        private System.Windows.Forms.ToolStripMenuItem reportsTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripMenuItem bookingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem newBookingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem updateBookingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem updateBeneficiariesTSMI;
        private System.Windows.Forms.ToolStripMenuItem updateAdminTSMI;
        private System.Windows.Forms.ToolStripMenuItem generateReportsTSMI;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ToolStripMenuItem removeBeneficiaryTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeAdminTSMI;
		private System.Windows.Forms.Button btnDeleteBooking;
	}
}