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
    public partial class frmUpdateAdmin : Form
    {
        public frmUpdateAdmin()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminID.Text))
            {
                MessageBox.Show("Please enter an Admin ID to search.");
                return;
            }

            long adminId;
            if (!long.TryParse(txtAdminID.Text, out adminId))
            {
                MessageBox.Show("Admin ID must be a number.");
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
                        tbUsername.Text = reader["Username"].ToString();
                        tbPassword.Text = reader["Password"].ToString();
                        cmbRole.Text = reader["Role"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No admin found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbUsername.Clear();
                        tbPassword.Clear();
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
                MessageBox.Show("Please enter the Admin ID to update.");
                return;
            }

            long adminId;
            if (!long.TryParse(txtAdminID.Text, out adminId))
            {
                MessageBox.Show("Admin ID must be numeric.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string query = "UPDATE Admin_Login SET Username = @Username, Password = @Password, Role = @Role WHERE Admin_Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbRole.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", adminId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with that ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error updating admin: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
