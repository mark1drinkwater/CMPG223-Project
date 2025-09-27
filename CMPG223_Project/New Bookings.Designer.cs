
namespace CMPG223_Project
{
    partial class frmNewBookings
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
			this.lblCheckIn = new System.Windows.Forms.Label();
			this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
			this.lblCheckOut = new System.Windows.Forms.Label();
			this.lblBenID = new System.Windows.Forms.Label();
			this.lblAdminID = new System.Windows.Forms.Label();
			this.lblRoom = new System.Windows.Forms.Label();
			this.cbRoom = new System.Windows.Forms.ComboBox();
			this.cbAdmin = new System.Windows.Forms.ComboBox();
			this.cbBeneficiary = new System.Windows.Forms.ComboBox();
			this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
			this.btnAddBooking = new System.Windows.Forms.Button();
			this.lblHeader = new System.Windows.Forms.Label();
			this.chkMealTicket = new System.Windows.Forms.CheckBox();
			this.lblMeal = new System.Windows.Forms.Label();
			this.dtpMeal = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// lblCheckIn
			// 
			this.lblCheckIn.AutoSize = true;
			this.lblCheckIn.Location = new System.Drawing.Point(18, 95);
			this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCheckIn.Name = "lblCheckIn";
			this.lblCheckIn.Size = new System.Drawing.Size(113, 19);
			this.lblCheckIn.TabIndex = 0;
			this.lblCheckIn.Text = "Check-in Date:";
			// 
			// dtpCheckIn
			// 
			this.dtpCheckIn.Location = new System.Drawing.Point(161, 89);
			this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
			this.dtpCheckIn.Name = "dtpCheckIn";
			this.dtpCheckIn.Size = new System.Drawing.Size(298, 27);
			this.dtpCheckIn.TabIndex = 1;
			// 
			// lblCheckOut
			// 
			this.lblCheckOut.AutoSize = true;
			this.lblCheckOut.Location = new System.Drawing.Point(18, 145);
			this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCheckOut.Name = "lblCheckOut";
			this.lblCheckOut.Size = new System.Drawing.Size(123, 19);
			this.lblCheckOut.TabIndex = 0;
			this.lblCheckOut.Text = "Check-out Date:";
			// 
			// lblBenID
			// 
			this.lblBenID.AutoSize = true;
			this.lblBenID.Location = new System.Drawing.Point(18, 195);
			this.lblBenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBenID.Name = "lblBenID";
			this.lblBenID.Size = new System.Drawing.Size(91, 19);
			this.lblBenID.TabIndex = 0;
			this.lblBenID.Text = "Beneficiary:";
			// 
			// lblAdminID
			// 
			this.lblAdminID.AutoSize = true;
			this.lblAdminID.Location = new System.Drawing.Point(18, 245);
			this.lblAdminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAdminID.Name = "lblAdminID";
			this.lblAdminID.Size = new System.Drawing.Size(62, 19);
			this.lblAdminID.TabIndex = 0;
			this.lblAdminID.Text = "Admin:";
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Location = new System.Drawing.Point(18, 295);
			this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(57, 19);
			this.lblRoom.TabIndex = 0;
			this.lblRoom.Text = "Room:";
			// 
			// cbRoom
			// 
			this.cbRoom.FormattingEnabled = true;
			this.cbRoom.Location = new System.Drawing.Point(161, 292);
			this.cbRoom.Margin = new System.Windows.Forms.Padding(4);
			this.cbRoom.Name = "cbRoom";
			this.cbRoom.Size = new System.Drawing.Size(298, 27);
			this.cbRoom.TabIndex = 5;
			// 
			// cbAdmin
			// 
			this.cbAdmin.FormattingEnabled = true;
			this.cbAdmin.Location = new System.Drawing.Point(161, 242);
			this.cbAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.cbAdmin.Name = "cbAdmin";
			this.cbAdmin.Size = new System.Drawing.Size(298, 27);
			this.cbAdmin.TabIndex = 4;
			// 
			// cbBeneficiary
			// 
			this.cbBeneficiary.FormattingEnabled = true;
			this.cbBeneficiary.Location = new System.Drawing.Point(161, 192);
			this.cbBeneficiary.Margin = new System.Windows.Forms.Padding(4);
			this.cbBeneficiary.Name = "cbBeneficiary";
			this.cbBeneficiary.Size = new System.Drawing.Size(298, 27);
			this.cbBeneficiary.TabIndex = 3;
			// 
			// dtpCheckOut
			// 
			this.dtpCheckOut.Location = new System.Drawing.Point(161, 139);
			this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
			this.dtpCheckOut.Name = "dtpCheckOut";
			this.dtpCheckOut.Size = new System.Drawing.Size(298, 27);
			this.dtpCheckOut.TabIndex = 2;
			// 
			// btnAddBooking
			// 
			this.btnAddBooking.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddBooking.Location = new System.Drawing.Point(175, 540);
			this.btnAddBooking.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddBooking.Name = "btnAddBooking";
			this.btnAddBooking.Size = new System.Drawing.Size(250, 55);
			this.btnAddBooking.TabIndex = 8;
			this.btnAddBooking.Text = "Add New Booking";
			this.btnAddBooking.UseVisualStyleBackColor = true;
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(195, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "New Booking";
			// 
			// chkMealTicket
			// 
			this.chkMealTicket.AutoSize = true;
			this.chkMealTicket.Location = new System.Drawing.Point(22, 375);
			this.chkMealTicket.Margin = new System.Windows.Forms.Padding(4);
			this.chkMealTicket.Name = "chkMealTicket";
			this.chkMealTicket.Size = new System.Drawing.Size(141, 23);
			this.chkMealTicket.TabIndex = 6;
			this.chkMealTicket.Text = "Add Meal Ticket";
			this.chkMealTicket.UseVisualStyleBackColor = true;
			// 
			// lblMeal
			// 
			this.lblMeal.AutoSize = true;
			this.lblMeal.Location = new System.Drawing.Point(18, 425);
			this.lblMeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMeal.Name = "lblMeal";
			this.lblMeal.Size = new System.Drawing.Size(109, 19);
			this.lblMeal.TabIndex = 0;
			this.lblMeal.Text = "Claimed Date:";
			// 
			// dtpMeal
			// 
			this.dtpMeal.Location = new System.Drawing.Point(161, 419);
			this.dtpMeal.Margin = new System.Windows.Forms.Padding(4);
			this.dtpMeal.Name = "dtpMeal";
			this.dtpMeal.Size = new System.Drawing.Size(298, 27);
			this.dtpMeal.TabIndex = 7;
			// 
			// frmNewBookings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 611);
			this.Controls.Add(this.chkMealTicket);
			this.Controls.Add(this.btnAddBooking);
			this.Controls.Add(this.cbBeneficiary);
			this.Controls.Add(this.cbAdmin);
			this.Controls.Add(this.cbRoom);
			this.Controls.Add(this.dtpMeal);
			this.Controls.Add(this.dtpCheckOut);
			this.Controls.Add(this.dtpCheckIn);
			this.Controls.Add(this.lblRoom);
			this.Controls.Add(this.lblAdminID);
			this.Controls.Add(this.lblMeal);
			this.Controls.Add(this.lblBenID);
			this.Controls.Add(this.lblCheckOut);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblCheckIn);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmNewBookings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Bookings";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblBenID;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox cbAdmin;
        private System.Windows.Forms.ComboBox cbBeneficiary;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.CheckBox chkMealTicket;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.DateTimePicker dtpMeal;
    }
}