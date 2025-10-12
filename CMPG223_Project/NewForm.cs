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
    public partial class frmRemoveAdmin : Form
    {
        public frmRemoveAdmin()
        {
            InitializeComponent();
            LoadAllAdmins();
        }

        private void LoadAllAdmins()
        {
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
                string query = "SELECT Admin_Id, Username, Role FROM ADMIN_LOGIN";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAdmin.DataSource = dt;
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllAdmins();
            txtAdminID.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminID.Text))
            {
				MessageBox.Show("Please enter an Admin ID to filter.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

            int adminId;
            if (!int.TryParse(txtAdminID.Text, out adminId))
            {
				MessageBox.Show("Admin ID must be a number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
                string query = "SELECT Admin_Id, Username, Role FROM ADMIN_LOGIN WHERE Admin_Id = @AdminId";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@AdminId", adminId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAdmin.DataSource = dt;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminID.Text))
            {                
				MessageBox.Show("Please enter an Admin ID to delete.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

            int adminId;
            if (!int.TryParse(txtAdminID.Text, out adminId))
            {
				MessageBox.Show("Admin ID must be a number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
                string query = "DELETE FROM ADMIN_LOGIN WHERE Admin_Id = @AdminId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminId", adminId);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAdmins();
                    }
                    else
                    {
                        MessageBox.Show("No user found with that ID.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
                }
            }

            txtAdminID.Clear();
        }

        // Wire up events in constructor or designer if not already done
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            btnShowAll.Click += btnShowAll_Click;
            btnFilter.Click += btnFilter_Click;
            btnDelete.Click += btnDelete_Click;
        }
    }
}