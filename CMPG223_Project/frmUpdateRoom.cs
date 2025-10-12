using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Project
{
	public partial class frmUpdateRoom : Form
	{		
		private string originalRoomNumber = null;

		public frmUpdateRoom()
		{
			InitializeComponent();
		}		

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtRoomID.Text))
			{
				MessageBox.Show("Please enter a Room ID to search.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!long.TryParse(txtRoomID.Text.Trim(), out long roomId))
			{
				MessageBox.Show("Room ID must be a number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			using (SqlCommand cmd = new SqlCommand("SELECT Room_Number, Bed_Count FROM Room WHERE Room_Id = @Id", conn))
			{
				cmd.Parameters.Add("@Id", SqlDbType.BigInt).Value = roomId;

				try
				{
					conn.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string roomNumber = reader["Room_Number"]?.ToString() ?? string.Empty;
							txtRoom.Text = roomNumber;
							txtBedCount.Text = reader["Bed_Count"]?.ToString() ?? string.Empty;

							// store original (uppercase for consistent comparisons)
							originalRoomNumber = roomNumber?.ToUpperInvariant();
							btnUpdate.Enabled = true;
						}
						else
						{
							MessageBox.Show("No room found with that Room ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							ClearFormFields();
						}
					}
				}
				catch (SqlException ex)
				{
					MessageBox.Show($"Database error while searching: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Unexpected error while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtRoomID.Text))
			{
				MessageBox.Show("Please enter a Room ID to update.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!long.TryParse(txtRoomID.Text.Trim(), out long roomId))
			{
				MessageBox.Show("Room ID must be a number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string newRoomNumber = txtRoom.Text.Trim().ToUpperInvariant(); // defensive uppercase
			if (string.IsNullOrWhiteSpace(newRoomNumber))
			{
				MessageBox.Show("Please enter a room number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtRoom.Focus();
				return;
			}

			if (newRoomNumber.Length > 50)
			{
				MessageBox.Show("Room number must be 50 characters or fewer.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtRoom.Focus();
				return;
			}

			if (!int.TryParse(txtBedCount.Text.Trim(), out int bedCount) || bedCount <= 0)
			{
				MessageBox.Show("Bed count must be a positive whole number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBedCount.Focus();
				return;
			}

			bool roomNumberChanged = !string.Equals(originalRoomNumber ?? string.Empty, newRoomNumber, StringComparison.OrdinalIgnoreCase);

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				try
				{
					conn.Open();

					// If the room number changed, check for duplicates first (exclude current Room_Id)
					if (roomNumberChanged)
					{
						using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM Room WHERE UPPER(Room_Number) = @RoomNumber AND Room_Id <> @Id", conn))
						{
							checkCmd.Parameters.Add("@RoomNumber", SqlDbType.NVarChar, 50).Value = newRoomNumber;
							checkCmd.Parameters.Add("@Id", SqlDbType.BigInt).Value = roomId;

							int dupCount = Convert.ToInt32(checkCmd.ExecuteScalar());
							if (dupCount > 0)
							{
								MessageBox.Show("Another room with that room number already exists. Please choose a different room number.", "Duplicate Room Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								txtRoom.Focus();
								return;
							}
						}
					}

					// Update depending on whether Room_Number changed
					string updateSql;
					if (roomNumberChanged)
					{
						updateSql = "UPDATE Room SET Room_Number = @RoomNumber, Bed_Count = @BedCount WHERE Room_Id = @Id";
					}
					else
					{
						updateSql = "UPDATE Room SET Bed_Count = @BedCount WHERE Room_Id = @Id";
					}

					using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
					{
						if (roomNumberChanged)
							updateCmd.Parameters.Add("@RoomNumber", SqlDbType.NVarChar, 50).Value = newRoomNumber;

						updateCmd.Parameters.Add("@BedCount", SqlDbType.Int).Value = bedCount;
						updateCmd.Parameters.Add("@Id", SqlDbType.BigInt).Value = roomId;

						int rowsAffected = updateCmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							// update saved original value to new value
							originalRoomNumber = newRoomNumber;
						}
						else
						{
							MessageBox.Show("No room found with that Room ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
				{
					// Unique constraint violation caught as a fallback against race conditions
					MessageBox.Show("Update failed: another room with that room number already exists (detected by the database).", "Duplicate Room Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtRoom.Focus();
				}
				catch (SqlException ex)
				{
					MessageBox.Show($"Database error while updating: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Unexpected error while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ClearFormFields()
		{
			txtRoom.Clear();
			txtBedCount.Clear();
			originalRoomNumber = null;
			btnUpdate.Enabled = false;
		}
	}
}
