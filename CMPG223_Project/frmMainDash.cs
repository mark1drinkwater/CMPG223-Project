using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CMPG223_Project
{
    public partial class frmMainDash : Form
    {
        public frmMainDash()
        {
            InitializeComponent();
            this.Activated += frmMainDash_Activated;
			this.FormClosing += frmMainDash_FormClosing;
		}

        private void frmMainDash_Load(object sender, EventArgs e)
        {
            LoadBookings();
			
		}

		private void frmMainDash_Activated(object sender, EventArgs e)
		{
			LoadBookings();
		}

		private void LoadBookings()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
				{
					conn.Open();

					string query = @"
						SELECT b.Booking_Id, b.Check_In, b.Check_Out, b.Ben_Id, b.Admin_Id, 
							   b.Room_Id, (ben.Name + ' ' + ben.Surname) AS BeneficiaryFullName, 
							   a.Username AS AdminUsername,
							   r.Room_Number AS RoomNumber
						FROM Booking b
						LEFT JOIN Beneficiary ben ON b.Ben_Id = ben.Ben_Id
						LEFT JOIN Admin_Login a ON b.Admin_Id = a.Admin_Id
						LEFT JOIN Room r ON b.Room_Id = r.Room_Id
						ORDER BY b.Booking_Id ASC;";

					SqlDataAdapter da = new SqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					// Ensure DataView is sorted by Booking_Id
					dt.DefaultView.Sort = "Booking_Id ASC";
										
					dgvBookings.DataSource = dt.DefaultView;
					dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

					// Row selection settings
					dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					dgvBookings.MultiSelect = false;
					dgvBookings.ReadOnly = true;

					// Headers & formatting
					if (dgvBookings.Columns.Contains("Booking_Id"))
					{
						var col = dgvBookings.Columns["Booking_Id"];
						col.HeaderText = "Booking ID";
						col.SortMode = DataGridViewColumnSortMode.Automatic; // allow user clicks to re-sort
					}
					if (dgvBookings.Columns.Contains("Check_In"))
					{
						dgvBookings.Columns["Check_In"].HeaderText = "Check-In";
						dgvBookings.Columns["Check_In"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
					}
					if (dgvBookings.Columns.Contains("Check_Out"))
					{
						dgvBookings.Columns["Check_Out"].HeaderText = "Check-Out";
						dgvBookings.Columns["Check_Out"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
					}
					if (dgvBookings.Columns.Contains("BeneficiaryFullName")) dgvBookings.Columns["BeneficiaryFullName"].HeaderText = "Beneficiary";
					if (dgvBookings.Columns.Contains("AdminUsername")) dgvBookings.Columns["AdminUsername"].HeaderText = "Admin";
					if (dgvBookings.Columns.Contains("RoomNumber")) dgvBookings.Columns["RoomNumber"].HeaderText = "Room";

					// Hide raw FK columns if you don't want them visible
					if (dgvBookings.Columns.Contains("Ben_Id")) dgvBookings.Columns["Ben_Id"].Visible = false;
					if (dgvBookings.Columns.Contains("Admin_Id")) dgvBookings.Columns["Admin_Id"].Visible = false;
					if (dgvBookings.Columns.Contains("Room_Id")) dgvBookings.Columns["Room_Id"].Visible = false;

					// Enforce sort (so UI reflects Booking_Id ordering)
					if (dgvBookings.Columns.Contains("Booking_Id"))
					{
						dgvBookings.Sort(dgvBookings.Columns["Booking_Id"], ListSortDirection.Ascending);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading bookings: " + ex.Message,
								"Database Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}

		private void newAdminTSMI_Click(object sender, EventArgs e)
		{
			frmNewAdmin mainForm = new frmNewAdmin();
			mainForm.Show();
		}
				
		private void removeAdminTSMI_Click(object sender, EventArgs e)
		{
			frmRemoveAdmin mainForm = new frmRemoveAdmin();
			mainForm.Show();
		}

		private void updateAdminTSMI_Click(object sender, EventArgs e)
		{
			frmUpdateAdmin mainForm = new frmUpdateAdmin();
			mainForm.Show();
		}

		private void newBeneficiaryTSMI_Click(object sender, EventArgs e)
		{
			frmNewBeneficiaries mainForm = new frmNewBeneficiaries();
			mainForm.Show();
		}	

		private void removeBeneficiaryTSMI_Click(object sender, EventArgs e)
		{
			frmRemoveBeneficiaries mainForm = new frmRemoveBeneficiaries();
			mainForm.Show();
		}

		private void updateBeneficiariesTSMI_Click(object sender, EventArgs e)
		{
			frmUpdateBeneficiaries mainForm = new frmUpdateBeneficiaries();
			mainForm.Show();
		}

		private void newRoomTSMI_Click(object sender, EventArgs e)
		{
			frmNewRoom mainForm = new frmNewRoom();
			mainForm.Show();
		}

		private void removeRoomTSMI_Click(object sender, EventArgs e)
		{
			frmRemoveRoom mainForm = new frmRemoveRoom();
			mainForm.Show();
		}

		private void updateRoomTSMI_Click(object sender, EventArgs e)
		{
			frmUpdateRoom mainForm = new frmUpdateRoom();
			mainForm.Show();
		}
		
		private void newBookingsTSMI_Click(object sender, EventArgs e)
		{			
			frmNewBookings mainForm = new frmNewBookings();
			mainForm.Show();
		}

		private void updateBookingsTSMI_Click(object sender, EventArgs e)
		{		
			frmUpdateBookings mainForm = new frmUpdateBookings();
			mainForm.Show();
		}				

		private void generateReportsTSMI_Click(object sender, EventArgs e)
		{			
			frmReports mainForm = new frmReports();
			mainForm.Show();
		}

		private void exitTSMI_Click(object sender, EventArgs e)
		{
            var confirm = MessageBox.Show("Are you sure you want to exit the application?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
                Application.Exit();
        }

		private void btnFilter_Click(object sender, EventArgs e)
		{
			string filterCriteria = txtFilter.Text.Trim();

			if (string.IsNullOrEmpty(filterCriteria))
			{
				MessageBox.Show("Please enter a keyword or Booking ID to filter bookings.",
								"Filter Warning",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
				{
					conn.Open();
					DataTable dt = new DataTable();

					// If user typed a number — treat it as Booking_Id
					if (long.TryParse(filterCriteria, out long parsedId))
					{
						string query = @"
                            SELECT b.Booking_Id, b.Check_In, b.Check_Out, b.Ben_Id, b.Admin_Id, b.Room_Id,
                                   ben.Name AS BeneficiaryName, ben.Surname AS BeneficiarySurname
                            FROM Booking b
                            LEFT JOIN Beneficiary ben ON b.Ben_Id = ben.Ben_Id
                            WHERE b.Booking_Id = @id";
						using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
						{
							da.SelectCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = parsedId;
							da.Fill(dt);
						}
					}
					else
					{
						// Text search on beneficiary name (or full name)
						string query = @"
                            SELECT b.Booking_Id, b.Check_In, b.Check_Out, b.Ben_Id, b.Admin_Id, b.Room_Id,
                                   ben.Name AS BeneficiaryName, ben.Surname AS BeneficiarySurname
                            FROM Booking b
                            LEFT JOIN Beneficiary ben ON b.Ben_Id = ben.Ben_Id
                            WHERE ben.Name LIKE @criteria
                               OR ben.Surname LIKE @criteria
                               OR (ben.Name + ' ' + ben.Surname) LIKE @criteria";
						using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
						{
							da.SelectCommand.Parameters.Add("@criteria", SqlDbType.NVarChar, 400).Value = "%" + filterCriteria + "%";
							da.Fill(dt);
						}
					}

					if (dt.Rows.Count == 0)
					{
						MessageBox.Show("No bookings found matching your search.",
										"No Results",
										MessageBoxButtons.OK,
										MessageBoxIcon.Information);
					}

					dgvBookings.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering bookings: " + ex.Message,
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}

		private void btnDeleteBooking_Click(object sender, EventArgs e)
		{
			// Attempt to get a selected row (fall back to CurrentRow)
			DataGridViewRow row = null;
			if (dgvBookings.SelectedRows != null && dgvBookings.SelectedRows.Count > 0)
				row = dgvBookings.SelectedRows[0];
			else if (dgvBookings.CurrentRow != null)
				row = dgvBookings.CurrentRow;

			if (row == null)
			{
				MessageBox.Show("Please select a booking to delete.",
								"No Selection",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
				return;
			}

			// Try to find the Booking_Id value robustly
			object val = null;
			if (dgvBookings.Columns.Contains("Booking_Id"))
				val = row.Cells["Booking_Id"].Value;
			else if (dgvBookings.Columns.Contains("BookingID"))
				val = row.Cells["BookingID"].Value;
			else if (row.Cells.Count > 0)
				val = row.Cells[0].Value; // fallback: first cell

			if (val == null || val == DBNull.Value)
			{
				MessageBox.Show("Could not retrieve Booking ID from the selected row.",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				return;
			}

			if (!long.TryParse(val.ToString(), out long bookingId))
			{
				MessageBox.Show("Booking ID is not a valid number.",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				return;
			}

			DialogResult confirm = MessageBox.Show(
				"Are you sure you want to delete this booking? This will also remove any meal tickets for this booking.",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
				{
					conn.Open();
					using (SqlTransaction tran = conn.BeginTransaction())
					{
						try
						{
							// 1) Delete meal tickets for this booking (if any)
							using (SqlCommand cmd = new SqlCommand("DELETE FROM Meal_Ticket WHERE Booking_Id = @id", conn, tran))
							{
								cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = bookingId;
								cmd.ExecuteNonQuery();
							}

							// 2) Delete the booking
							int rowsAffected;
							using (SqlCommand cmd = new SqlCommand("DELETE FROM Booking WHERE Booking_Id = @id", conn, tran))
							{
								cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = bookingId;
								rowsAffected = cmd.ExecuteNonQuery();
							}

							if (rowsAffected > 0)
							{
								tran.Commit();
								MessageBox.Show("Booking deleted successfully!",
												"Success",
												MessageBoxButtons.OK,
												MessageBoxIcon.Information);
								LoadBookings(); // refresh grid
							}
							else
							{
								tran.Rollback();
								MessageBox.Show("No booking found with that ID.",
												"Not Found",
												MessageBoxButtons.OK,
												MessageBoxIcon.Warning);
							}
						}
						catch (SqlException sqlEx)
						{
							tran.Rollback();
							MessageBox.Show("Error deleting booking: " + sqlEx.Message,
											"Database Error",
											MessageBoxButtons.OK,
											MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting booking: " + ex.Message,
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			LoadBookings();
            txtFilter.Clear();
		}

		private void frmMainDash_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Only prompt when the user manually requested close
			if (e.CloseReason != CloseReason.UserClosing)
				return;

			// Ask user to confirm
			if (MessageBox.Show("Are you sure you want to exit the application?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.No)
			{
				e.Cancel = true;
				return;
			}

			Application.Exit();
		}
	}
}
