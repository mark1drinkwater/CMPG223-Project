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
    public partial class frmRemoveBeneficiaries : Form
    {
        // TODO: Update connection string for final deployment
        private string connString = @"Data Source=HAHLOLWE;Initial Catalog=Shelter;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public frmRemoveBeneficiaries()
        {
            InitializeComponent();
            LoadAllBeneficiaries();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBenID.Text))
            {
                MessageBox.Show("Please enter a Beneficiary ID to filter.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string sql = @"SELECT b.Ben_Id, b.Name, b.Surname, b.Id_Number, b.Cell_Number, 
                                      b.Email_Address, bt.Description as Beneficiary_Type
                               FROM Beneficiary b 
                               LEFT JOIN Beneficiary_Type bt ON b.Ben_Type_Id = bt.Ben_Type_Id 
                               WHERE b.Ben_Id = @BenId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BenId", txtBenID.Text.Trim());

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBenificiaries.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No beneficiary found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllBeneficiaries();
            txtBenID.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBenificiaries.SelectedRows.Count == 0) // Check if a row is selected in the dgv
            {
                MessageBox.Show("Please select a beneficiary to delete from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected beneficiary ID 
            DataGridViewRow selectedRow = dgvBenificiaries.SelectedRows[0];
            string beneficiaryId = selectedRow.Cells["Ben_Id"].Value.ToString();
            string beneficiaryName = selectedRow.Cells["Name"].Value.ToString();
            string beneficiarySurname = selectedRow.Cells["Surname"].Value.ToString();

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete beneficiary: {beneficiaryName} {beneficiarySurname}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteBeneficiary(beneficiaryId);
            }
        }

        private void DeleteBeneficiary(string beneficiaryId)
        {
            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string sql = "DELETE FROM Beneficiary WHERE Ben_Id = @BenId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BenId", beneficiaryId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Beneficiary deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBeneficiaries();
                    }
                    else
                    {
                        MessageBox.Show("No beneficiary was deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while deleting the beneficiary: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAllBeneficiaries()
        {
            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string sql = @"SELECT b.Ben_Id, b.Name, b.Surname, b.Id_Number, b.Cell_Number, 
                                      b.Email_Address, bt.Description as Beneficiary_Type
                               FROM Beneficiary b 
                               LEFT JOIN Beneficiary_Type bt ON b.Ben_Type_Id = bt.Ben_Type_Id 
                               ORDER BY b.Ben_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBenificiaries.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
