using System;
using System.Data.SqlClient;
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

			if (!int.TryParse(txtBookingID.Text, out int bookingId))
			{
				MessageBox.Show("Booking ID must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				// Join with Beneficiary to get Name + Surname
				string query = @"
					SELECT b.Check_In, b.Check_Out, b.Ben_Id, ben.Name, ben.Surname
					FROM BOOKING b
					LEFT JOIN Beneficiary ben ON b.Ben_Id = ben.Ben_Id
					WHERE b.Booking_Id = @BookingId";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.Add("@BookingId", System.Data.SqlDbType.Int).Value = bookingId;
					conn.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							// Dates (guard against NULL)
							if (!reader.IsDBNull(0))
								dtpCheckIn.Value = reader.GetDateTime(0);
							else
								dtpCheckIn.Value = DateTime.Today;

							if (!reader.IsDBNull(1))
								dtpCheckOut.Value = reader.GetDateTime(1);
							else
								dtpCheckOut.Value = DateTime.Today;

							// Ben_Id (may be bigint in DB) - store in Tag for later use
							long? benId = reader.IsDBNull(2) ? (long?)null : reader.GetInt64(2);
							txtBenID.Tag = benId;

							// Name and surname columns
							string firstName = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
							string lastName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

							// If we have names, show "Name Surname"; otherwise fallback to the ID (or empty)
							string display;
							if (!string.IsNullOrWhiteSpace(firstName) || !string.IsNullOrWhiteSpace(lastName))
							{
								display = $"{firstName} {lastName}".Trim();
							}
							else
							{
								display = benId.HasValue ? benId.Value.ToString() : string.Empty;
							}

							txtBenID.Text = display;
						}
						else
						{
							MessageBox.Show("Booking not found.", "No booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			// Parse Booking ID
			if (!int.TryParse(txtBookingID.Text, out int bookingId))
			{
				MessageBox.Show("Booking ID must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DateTime checkIn = dtpCheckIn.Value.Date;
			DateTime checkOut = dtpCheckOut.Value.Date;

			if (checkOut < checkIn)
			{
				MessageBox.Show("Check-out date cannot be earlier than check-in date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string updateQuery = @"
					UPDATE BOOKING
                    SET Check_In = @CheckIn, Check_Out = @CheckOut
                    WHERE Booking_Id = @BookingId";

				using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
				{					
					cmd.Parameters.Add("@CheckIn", System.Data.SqlDbType.DateTime).Value = checkIn;
					cmd.Parameters.Add("@CheckOut", System.Data.SqlDbType.DateTime).Value = checkOut;				
					cmd.Parameters.Add("@BookingId", System.Data.SqlDbType.Int).Value = bookingId;				

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
			txtBenID.Tag = null;
		}
	}
}