using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class frmUpdateAdmin : Form
    {
        public frmUpdateAdmin()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminID.Text))
            {
				MessageBox.Show("Please enter an Admin ID to search.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long adminId;
            if (!long.TryParse(txtAdminID.Text, out adminId))
            {
				MessageBox.Show("Admin ID must be a number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string query = "SELECT Username, Password, Role FROM Admin_Login WHERE Admin_Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", adminId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtUsername.Text = reader["Username"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        cmbRole.Text = reader["Role"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No user found with that Admin ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        cmbRole.SelectedIndex = -1;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminID.Text))
            {
				MessageBox.Show("Please enter an Admin ID to update.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

            long adminId;
            if (!long.TryParse(txtAdminID.Text, out adminId))
            {
				MessageBox.Show("Admin ID must be a number.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string query = "UPDATE Admin_Login SET Username = @Username, Password = @Password, Role = @Role WHERE Admin_Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbRole.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", adminId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with that Admin ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
