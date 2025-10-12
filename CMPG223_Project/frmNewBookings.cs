using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class frmNewBookings : Form
    {
        public frmNewBookings()
        {
            InitializeComponent();
            LoadComboBoxes();
            dtpMeal.Visible = lblMeal.Visible = false; // Hide Claimed date control if add meal ticket is not selected
        }

        private void ClearFormFields()
        {
            // Set date pickers to today
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today;
            dtpMeal.Value = DateTime.Today;

            // Set combo boxes to first item
            if (cbBeneficiary.Items.Count > 0) cbBeneficiary.SelectedIndex = 0;
            if (cbRoom.Items.Count > 0) cbRoom.SelectedIndex = 0;
            if (cbAdmin.Items.Count > 0) cbAdmin.SelectedIndex = 0;

            // Uncheck and hide meal ticket controls
            chkMealTicket.Checked = false;
            dtpMeal.Visible = false;
            lblMeal.Visible = false;
        }

		private void LoadComboBoxes()
		{
			// Populate Beneficiary ComboBox (Name + Surname as FullName)
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				conn.Open();				
				string sqlBen = @"
                    SELECT Ben_Id, LTRIM(RTRIM(ISNULL(Name, '') + ' ' + ISNULL(Surname, ''))) AS FullName
                    FROM BENEFICIARY";
				using (SqlCommand cmd = new SqlCommand(sqlBen, conn))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					DataTable dt = new DataTable();
					dt.Load(reader);
					cbBeneficiary.DataSource = dt;
					cbBeneficiary.DisplayMember = "FullName";
					cbBeneficiary.ValueMember = "Ben_Id";
				}
			}

			// Populate Room ComboBox
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT Room_Id, Room_number FROM ROOM", conn))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					DataTable dt = new DataTable();
					dt.Load(reader);
					cbRoom.DataSource = dt;
					cbRoom.DisplayMember = "Room_number";
					cbRoom.ValueMember = "Room_Id";
				}
			}

			// Populate Admin ComboBox 
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT Admin_Id, Username FROM ADMIN_LOGIN", conn))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					DataTable dt = new DataTable();
					dt.Load(reader);
					cbAdmin.DataSource = dt;
					cbAdmin.DisplayMember = "Username";
					cbAdmin.ValueMember = "Admin_Id";
				}
			}
		}

		private void chkMealTicket_CheckedChanged(object sender, EventArgs e)
        {
            dtpMeal.Visible = lblMeal.Visible = chkMealTicket.Checked;
        }

		private void btnAddBooking_Click(object sender, EventArgs e)
		{
			if (cbBeneficiary.SelectedValue == null || cbRoom.SelectedValue == null || cbAdmin.SelectedValue == null)
			{
				MessageBox.Show("Please select a beneficiary, admin, and room.");
				return;
			}

			int benId = Convert.ToInt32(cbBeneficiary.SelectedValue);
			int roomId = Convert.ToInt32(cbRoom.SelectedValue);
			int adminId = Convert.ToInt32(cbAdmin.SelectedValue);
			
			DateTime checkIn = dtpCheckIn.Value;
			DateTime checkOut = dtpCheckOut.Value;

			int bookingId = -1;
			int? ticketId = null;

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				conn.Open();
				using (SqlTransaction tran = conn.BeginTransaction())
				{
					try
					{
						// Insert into BOOKING and get Booking_Id
						string insertBooking = @"
							INSERT INTO BOOKING (Check_In, Check_Out, Ben_Id, Admin_Id, Room_Id)
							OUTPUT INSERTED.Booking_Id
							VALUES (@CheckIn, @CheckOut, @BenId, @AdminId, @RoomId)";

						using (SqlCommand cmd = new SqlCommand(insertBooking, conn, tran))
						{
							cmd.Parameters.AddWithValue("@CheckIn", checkIn);
							cmd.Parameters.AddWithValue("@CheckOut", checkOut);
							cmd.Parameters.AddWithValue("@BenId", benId);
							cmd.Parameters.AddWithValue("@AdminId", adminId);
							cmd.Parameters.AddWithValue("@RoomId", roomId);

							object result = cmd.ExecuteScalar();
							if (result == null || result == DBNull.Value)
								throw new Exception("Insert failed: no Booking_Id returned.");

							bookingId = Convert.ToInt32(result);
						}

						// If meal ticket is checked, insert into MEAL_TICKET and capture Ticket_Id
						if (chkMealTicket.Checked)
						{
							DateTime claimedDate = dtpMeal.Value;
							string insertMeal = @"
								INSERT INTO MEAL_TICKET (Claimed_date, Booking_Id)
								OUTPUT INSERTED.Ticket_Id
								VALUES (@ClaimedDate, @BookingId)";

							using (SqlCommand cmd = new SqlCommand(insertMeal, conn, tran))
							{
								cmd.Parameters.AddWithValue("@ClaimedDate", claimedDate);
								cmd.Parameters.AddWithValue("@BookingId", bookingId);

								object mealResult = cmd.ExecuteScalar();
								if (mealResult == null || mealResult == DBNull.Value)
									throw new Exception("Meal ticket insert failed: no Ticket_Id returned.");

								ticketId = Convert.ToInt32(mealResult);
							}
						}

						// Commit both inserts
						tran.Commit();

						// Show appropriate message
						if (ticketId.HasValue)
						{
							MessageBox.Show($"Booking added successfully. Meal ticket #{ticketId.Value} issued with booking.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Booking added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						ClearFormFields();
					}
					catch (Exception ex)
					{
						try { tran.Rollback(); } catch { /* ignore rollback errors */ }
						MessageBox.Show("Error adding booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}