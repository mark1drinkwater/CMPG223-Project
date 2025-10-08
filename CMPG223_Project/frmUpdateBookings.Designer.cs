
namespace CMPG223_Project
{
    partial class frmUpdateBookings
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
			this.btnUpdateBooking = new System.Windows.Forms.Button();
			this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
			this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
			this.lblRoom = new System.Windows.Forms.Label();
			this.lblAdminID = new System.Windows.Forms.Label();
			this.lblBenID = new System.Windows.Forms.Label();
			this.lblCheckOut = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblCheckIn = new System.Windows.Forms.Label();
			this.lblBookingID = new System.Windows.Forms.Label();
			this.txtBookingID = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtBenID = new System.Windows.Forms.TextBox();
			this.tbAdmin = new System.Windows.Forms.TextBox();
			this.tbRoom = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnUpdateBooking
			// 
			this.btnUpdateBooking.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateBooking.Location = new System.Drawing.Point(175, 540);
			this.btnUpdateBooking.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdateBooking.Name = "btnUpdateBooking";
			this.btnUpdateBooking.Size = new System.Drawing.Size(250, 55);
			this.btnUpdateBooking.TabIndex = 8;
			this.btnUpdateBooking.Text = "Update Booking";
			this.btnUpdateBooking.UseVisualStyleBackColor = true;
			this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
			// 
			// dtpCheckOut
			// 
			this.dtpCheckOut.Location = new System.Drawing.Point(172, 265);
			this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
			this.dtpCheckOut.Name = "dtpCheckOut";
			this.dtpCheckOut.Size = new System.Drawing.Size(298, 27);
			this.dtpCheckOut.TabIndex = 4;
			// 
			// dtpCheckIn
			// 
			this.dtpCheckIn.Location = new System.Drawing.Point(172, 215);
			this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
			this.dtpCheckIn.Name = "dtpCheckIn";
			this.dtpCheckIn.Size = new System.Drawing.Size(298, 27);
			this.dtpCheckIn.TabIndex = 3;
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Location = new System.Drawing.Point(18, 421);
			this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(57, 19);
			this.lblRoom.TabIndex = 0;
			this.lblRoom.Text = "Room:";
			// 
			// lblAdminID
			// 
			this.lblAdminID.AutoSize = true;
			this.lblAdminID.Location = new System.Drawing.Point(18, 371);
			this.lblAdminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAdminID.Name = "lblAdminID";
			this.lblAdminID.Size = new System.Drawing.Size(62, 19);
			this.lblAdminID.TabIndex = 0;
			this.lblAdminID.Text = "Admin:";
			// 
			// lblBenID
			// 
			this.lblBenID.AutoSize = true;
			this.lblBenID.Location = new System.Drawing.Point(18, 321);
			this.lblBenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBenID.Name = "lblBenID";
			this.lblBenID.Size = new System.Drawing.Size(91, 19);
			this.lblBenID.TabIndex = 0;
			this.lblBenID.Text = "Beneficiary:";
			// 
			// lblCheckOut
			// 
			this.lblCheckOut.AutoSize = true;
			this.lblCheckOut.Location = new System.Drawing.Point(18, 271);
			this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCheckOut.Name = "lblCheckOut";
			this.lblCheckOut.Size = new System.Drawing.Size(123, 19);
			this.lblCheckOut.TabIndex = 0;
			this.lblCheckOut.Text = "Check-out Date:";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(231, 33);
			this.lblHeader.TabIndex = 8;
			this.lblHeader.Text = "Update Booking";
			// 
			// lblCheckIn
			// 
			this.lblCheckIn.AutoSize = true;
			this.lblCheckIn.Location = new System.Drawing.Point(18, 221);
			this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCheckIn.Name = "lblCheckIn";
			this.lblCheckIn.Size = new System.Drawing.Size(113, 19);
			this.lblCheckIn.TabIndex = 0;
			this.lblCheckIn.Text = "Check-in Date:";
			// 
			// lblBookingID
			// 
			this.lblBookingID.AutoSize = true;
			this.lblBookingID.Location = new System.Drawing.Point(18, 95);
			this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBookingID.Name = "lblBookingID";
			this.lblBookingID.Size = new System.Drawing.Size(146, 19);
			this.lblBookingID.TabIndex = 0;
			this.lblBookingID.Text = "Search Booking ID:";
			// 
			// txtBookingID
			// 
			this.txtBookingID.Location = new System.Drawing.Point(172, 92);
			this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
			this.txtBookingID.Name = "txtBookingID";
			this.txtBookingID.Size = new System.Drawing.Size(216, 27);
			this.txtBookingID.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(396, 86);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 37);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search booking";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtBenID
			// 
			this.txtBenID.Location = new System.Drawing.Point(172, 318);
			this.txtBenID.Margin = new System.Windows.Forms.Padding(4);
			this.txtBenID.Name = "txtBenID";
			this.txtBenID.Size = new System.Drawing.Size(298, 27);
			this.txtBenID.TabIndex = 5;
			// 
			// tbAdmin
			// 
			this.tbAdmin.Location = new System.Drawing.Point(172, 368);
			this.tbAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.tbAdmin.Name = "tbAdmin";
			this.tbAdmin.Size = new System.Drawing.Size(298, 27);
			this.tbAdmin.TabIndex = 6;
			// 
			// tbRoom
			// 
			this.tbRoom.Location = new System.Drawing.Point(172, 418);
			this.tbRoom.Margin = new System.Windows.Forms.Padding(4);
			this.tbRoom.Name = "tbRoom";
			this.tbRoom.Size = new System.Drawing.Size(298, 27);
			this.tbRoom.TabIndex = 7;
			// 
			// frmUpdateBookings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 611);
			this.Controls.Add(this.tbRoom);
			this.Controls.Add(this.tbAdmin);
			this.Controls.Add(this.txtBenID);
			this.Controls.Add(this.txtBookingID);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdateBooking);
			this.Controls.Add(this.dtpCheckOut);
			this.Controls.Add(this.dtpCheckIn);
			this.Controls.Add(this.lblRoom);
			this.Controls.Add(this.lblAdminID);
			this.Controls.Add(this.lblBookingID);
			this.Controls.Add(this.lblBenID);
			this.Controls.Add(this.lblCheckOut);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblCheckIn);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmUpdateBookings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Bookings";
			this.Load += new System.EventHandler(this.Update_Bookings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblBenID;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBenID;
        private System.Windows.Forms.TextBox tbAdmin;
        private System.Windows.Forms.TextBox tbRoom;
    }
}