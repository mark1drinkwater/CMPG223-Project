using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class frmUpdateBookings : Form
    {
        public frmUpdateBookings()
        {
            InitializeComponent();
        }

        private void Update_Bookings_Load(object sender, EventArgs e)
        {         
            ClearFields();
        }

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtBookingID.Text))
			{
				MessageBox.Show("Please enter a Booking ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int bookingId;
			if (!int.TryParse(txtBookingID.Text, out bookingId))
			{				
				MessageBox.Show("Booking ID must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string query = "SELECT Check_In, Check_Out, Ben_Id, Admin_Id, Room_Id FROM BOOKING WHERE Booking_Id = @BookingId";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@BookingId", bookingId);
					conn.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							dtpCheckIn.Value = reader.GetDateTime(0);
							dtpCheckOut.Value = reader.GetDateTime(1);
							txtBenID.Text = reader.GetInt32(2).ToString();
							tbAdmin.Text = reader.GetInt32(3).ToString();
							tbRoom.Text = reader.GetInt32(4).ToString();
						}
						else
						{
							MessageBox.Show("Booking not found.");
							ClearFields();
						}
					}
				}
			}
		}

		private void btnUpdateBooking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtBookingID.Text))
			{
				MessageBox.Show("Please enter a Booking ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int bookingId, benId, adminId, roomId;
			if (!int.TryParse(txtBookingID.Text, out bookingId) ||
				!int.TryParse(txtBenID.Text, out benId) ||
				!int.TryParse(tbAdmin.Text, out adminId) ||
				!int.TryParse(tbRoom.Text, out roomId))
			{
				MessageBox.Show("Booking ID, Beneficiary ID, Admin ID, and Room ID must be numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DateTime checkIn = dtpCheckIn.Value;
			DateTime checkOut = dtpCheckOut.Value;

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string updateQuery = @"UPDATE BOOKING
                                       SET Check_In = @CheckIn,
                                           Check_Out = @CheckOut,
                                           Ben_Id = @BenId,
                                           Admin_Id = @AdminId,
                                           Room_Id = @RoomId
                                       WHERE Booking_Id = @BookingId";
				using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
				{
					cmd.Parameters.AddWithValue("@CheckIn", checkIn);
					cmd.Parameters.AddWithValue("@CheckOut", checkOut);
					cmd.Parameters.AddWithValue("@BenId", benId);
					cmd.Parameters.AddWithValue("@AdminId", adminId);
					cmd.Parameters.AddWithValue("@RoomId", roomId);
					cmd.Parameters.AddWithValue("@BookingId", bookingId);

					conn.Open();
					int rows = cmd.ExecuteNonQuery();
					if (rows > 0)
					{
						MessageBox.Show("Booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ClearFields();
					}
					else
					{
						MessageBox.Show("Update failed. Booking not found.", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void ClearFields()
        {
            txtBookingID.Clear();
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today;
            txtBenID.Clear();
            tbAdmin.Clear();
            tbRoom.Clear();
        }		
	}
}