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
	public partial class frmRemoveRoom : Form
	{
		public frmRemoveRoom()
		{
			InitializeComponent();
			LoadAllRooms();
		}

		private void LoadAllRooms()
		{
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string query = "SELECT Room_Id, Room_Number, Bed_Count FROM Room";
				using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
				{
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					dgvRooms.DataSource = dt;
				}
			}
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			LoadAllRooms();
			txtRoomID.Clear();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtRoomID.Text))
			{
				MessageBox.Show("Please enter a Room ID to filter.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!long.TryParse(txtRoomID.Text.Trim(), out long roomId))
			{
				MessageBox.Show("Room ID must be a number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string query = "SELECT Room_Id, Room_Number, Bed_Count FROM Room WHERE Room_Id = @RoomId";
				using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
				{
					adapter.SelectCommand.Parameters.Add("@RoomId", System.Data.SqlDbType.BigInt).Value = roomId;
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					dgvRooms.DataSource = dt;
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtRoomID.Text))
			{
				MessageBox.Show("Please enter a Room ID to delete.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!long.TryParse(txtRoomID.Text.Trim(), out long roomId))
			{
				MessageBox.Show("Room ID must be a number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var confirm = MessageBox.Show("Are you sure you want to delete this room? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (confirm != DialogResult.Yes)
				return;

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string query = "DELETE FROM Room WHERE Room_Id = @RoomId";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.Add("@RoomId", System.Data.SqlDbType.BigInt).Value = roomId;
					try
					{
						conn.Open();
						int rows = cmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadAllRooms();
						}
						else
						{
							MessageBox.Show("No room found with that ID.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (SqlException ex) when (ex.Number == 547)
					{
						// Foreign key violation (e.g., Booking references this Room)
						MessageBox.Show("Cannot delete this room because it is referenced by other records (e.g., bookings). Remove or reassign those bookings first.", "Delete Failed - FK Constraint", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (SqlException ex)
					{
						MessageBox.Show($"Database error while deleting room: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			txtRoomID.Clear();
		}
	}
}
