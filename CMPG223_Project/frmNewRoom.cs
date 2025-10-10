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
	public partial class frmNewRoom : Form
	{
		public frmNewRoom()
		{
			InitializeComponent();
						
			txtBedCount.KeyPress += TxtBedCount_KeyPress;
			btnAddRoom.Click += BtnAddRoom_Click;
		}

		// Only digits and control keys allowed in txtBedCount
		private void TxtBedCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow control keys (backspace), and digits
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void BtnAddRoom_Click(object sender, EventArgs e)
		{
			// Trim inputs
			string roomNumber = txtRoom.Text.Trim().ToUpper();
			string bedCountText = txtBedCount.Text.Trim();

			// Basic validation
			if (string.IsNullOrWhiteSpace(roomNumber))
			{
				MessageBox.Show("Please enter a room number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtRoom.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(bedCountText))
			{
				MessageBox.Show("Please enter the bed count.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtBedCount.Focus();
				return;
			}

			if (!int.TryParse(bedCountText, out int bedCount) || bedCount <= 0)
			{
				MessageBox.Show("Bed count must be a positive whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtBedCount.Focus();
				return;
			}

			if (roomNumber.Length > 50)
			{
				MessageBox.Show("Room number must be 50 characters or fewer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtRoom.Focus();
				return;
			}

			// Insert into DB — check duplicates first
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				const string checkSql = "SELECT COUNT(1) FROM Room WHERE Room_Number = @RoomNumber";
				const string insertSql = "INSERT INTO Room (Room_Number, Bed_Count) VALUES (@RoomNumber, @BedCount)";

				using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
				using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
				{
					checkCmd.Parameters.Add("@RoomNumber", SqlDbType.NVarChar, 50).Value = roomNumber;
					insertCmd.Parameters.Add("@RoomNumber", SqlDbType.NVarChar, 50).Value = roomNumber;
					insertCmd.Parameters.Add("@BedCount", SqlDbType.Int).Value = bedCount;

					try
					{
						conn.Open();

						int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
						if (existing > 0)
						{
							MessageBox.Show("A room with that number already exists. Please choose a different room number.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtRoom.Focus();
							return;
						}

						int rows = insertCmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();
						}
						else
						{
							MessageBox.Show("Room could not be added. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (SqlException ex)
					{
						MessageBox.Show($"Database error while adding room: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void ClearForm()
		{
			txtRoom.Clear();
			txtBedCount.Clear();
			txtRoom.Focus();
		}
	}
}