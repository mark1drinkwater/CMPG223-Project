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
        private readonly string connectionString = "........";

        public frmRemoveAdmin()
        {
            InitializeComponent();
            LoadAllAdmins();
        }

        private void LoadAllAdmins()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminID.Text))
            {
                MessageBox.Show("Please enter an Admin ID to filter.");
                return;
            }

            int adminId;
            if (!int.TryParse(txtAdminID.Text, out adminId))
            {
                MessageBox.Show("Admin ID must be a number.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
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
                MessageBox.Show("Please enter an Admin ID to delete.");
                return;
            }

            int adminId;
            if (!int.TryParse(txtAdminID.Text, out adminId))
            {
                MessageBox.Show("Admin ID must be a number.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ADMIN_LOGIN WHERE Admin_Id = @AdminId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminId", adminId);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Admin deleted successfully.");
                        LoadAllAdmins();
                    }
                    else
                    {
                        MessageBox.Show("No admin found with that ID.");
                    }
                }
            }
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