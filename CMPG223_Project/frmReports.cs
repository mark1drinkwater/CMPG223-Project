using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void rbNumBeneficiaries_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();


            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                if (rdoNumOfBen.Checked)
                {
                    string sql = "SELECT COUNT(*) AS Count FROM Beneficiary";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string beneficiaryCount = reader["Count"].ToString();

                                lstReport.Items.Add($"Number of beneficiaries: {beneficiaryCount}");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rdoNumOfBenTypes.Checked)
                {
                    string sql = "  SELECT bt.Description, COUNT(*) AS Count FROM Beneficiary b INNER JOIN Beneficiary_Type bt ON b.Ben_Type_Id = bt.Ben_Type_Id GROUP BY bt.Description;";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string description = reader["Description"].ToString();
                                string count = reader["Count"].ToString();

                                lstReport.Items.Add($"Beneficiary Type: {description} with Count: {count}");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
