using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_Project
{
    public partial class frmNewAdmin : Form
    {
        public frmNewAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input
            // Check for empty
            // Password -> tbSurname

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check for password length and spaces

            if (txtSurname.Text.Length < 7)
            {
                MessageBox.Show("Password must be at least 7 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSurname.Text.Contains(" "))
            {
                MessageBox.Show("Password cannot contain spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // cmbRole validation   
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Consider checking for duplicate names, but it's hard. Maybe later. "SELECT COUNT(*) FROM ADMIN_LOGIN WHERE Username = @Username"

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string sql = "INSERT INTO ADMIN_LOGIN (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtSurname.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New admin added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clear fields

                    txtName.Clear();
                    txtSurname.Clear();
                    cmbRole.SelectedIndex = -1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while adding the new admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }
    }
}
