using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_Project
{
    public partial class frmEntryLogin : Form
    {
        public frmEntryLogin()
        {
            InitializeComponent();
			this.FormClosing += frmEntryLogin_FormClosing;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string sql = "SELECT Username FROM ADMIN_LOGIN WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            string user = reader["Username"].ToString();

                            MessageBox.Show($"Login Success! Welcome {user}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmMainDash dashboard = new frmMainDash();
                            dashboard.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtUsername.Clear();
                            txtUsername.Focus();
                        }
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

		private void frmEntryLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Only prompt when the user manually requested close
			if (e.CloseReason != CloseReason.UserClosing)
				return;

			// User to confirm
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
