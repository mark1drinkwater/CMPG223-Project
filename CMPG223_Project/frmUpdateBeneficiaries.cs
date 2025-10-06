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
    public partial class frmUpdateBeneficiaries : Form
    {
        // TODO: Update connection string for final deployment
        private string connString = @"Data Source=HAHLOLWE;Initial Catalog=Shelter;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public frmUpdateBeneficiaries()
        {
            InitializeComponent();
        }

        private void Update_Beneficiary_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBenId.Text))
            {
                MessageBox.Show("Please enter a Beneficiary ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = @"SELECT b.*, bt.Ben_Type_Id, bt.Description as Ben_Type_Description,
                                      bt.Gender, bt.Max_Age
                              FROM Beneficiary b 
                              LEFT JOIN Beneficiary_Type bt ON b.Ben_Type_Id = bt.Ben_Type_Id 
                              WHERE b.Ben_Id = @BenId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BenId", tbBenId.Text.Trim());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbName.Text = reader["Name"].ToString();
                            tbSurname.Text = reader["Surname"].ToString();
                            tbID.Text = reader["Id_Number"].ToString();
                            tbCell.Text = reader["Cell_Number"].ToString();
                            tbEmail.Text = reader["Email_Address"].ToString();

                            if (reader["Gender"] != DBNull.Value)
                            {
                                string gender = reader["Gender"].ToString().ToLower();
                                if (gender == "male")
                                {
                                    rdoMale.Checked = true;
                                    rdoFemale.Checked = false;
                                }
                                else if (gender == "female")
                                {
                                    rdoFemale.Checked = true;
                                    rdoMale.Checked = false;
                                }
                                else
                                {
                                    rdoMale.Checked = false;
                                    rdoFemale.Checked = false;
                                }
                            }

                            if (reader["Max_Age"] != DBNull.Value)
                            {
                                int maxAge = Convert.ToInt32(reader["Max_Age"]);
                                nudMaxAge.Value = maxAge;
                            }
                            else
                            {
                                nudMaxAge.Value = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Beneficiary not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBenId.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbSurname.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate beneficiary type selection
            if (cmbBenType.SelectedIndex <= 0) 
            {
                MessageBox.Show("Please select a beneficiary type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string getTypeIdSql = "SELECT Ben_Type_Id FROM Beneficiary_Type WHERE Description = @Description";
                SqlCommand getTypeIdCmd = new SqlCommand(getTypeIdSql, conn);
                getTypeIdCmd.Parameters.AddWithValue("@Description", cmbBenType.SelectedItem.ToString());

                string updateSql = @"UPDATE Beneficiary 
                              SET Name = @Name, Surname = @Surname, Id_Number = @IdNumber, 
                                  Cell_Number = @CellNumber, Email_Address = @Email, 
                                  Ben_Type_Id = @BenTypeId 
                              WHERE Ben_Id = @BenId";
                SqlCommand updateCmd = new SqlCommand(updateSql, conn);

                try
                {
                    conn.Open();

                    // Get the beneficiary type
                    object result = getTypeIdCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Please select beneficiary type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int benTypeId = Convert.ToInt32(result);

                    updateCmd.Parameters.AddWithValue("@Name", tbName.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@Surname", tbSurname.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@IdNumber", tbID.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@CellNumber", tbCell.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@BenTypeId", benTypeId);
                    updateCmd.Parameters.AddWithValue("@BenId", tbBenId.Text.Trim());

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update the beneficiary type details
                        UpdateBeneficiaryTypeDetails(benTypeId);

                        MessageBox.Show("Beneficiary updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("No beneficiary was updated. Please check the Beneficiary ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while updating the beneficiary: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBeneficiaryTypeDetails(int benTypeId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string gender = "";
                if (rdoMale.Checked)
                    gender = "Male";
                else if (rdoFemale.Checked)
                    gender = "Female";
                else
                    gender = "Any";

                string updateTypeSql = @"UPDATE Beneficiary_Type 
                                SET Description = @Description, Gender = @Gender, Max_Age = @MaxAge 
                                WHERE Ben_Type_Id = @BenTypeId";
                SqlCommand updateTypeCmd = new SqlCommand(updateTypeSql, conn);

                updateTypeCmd.Parameters.AddWithValue("@Description", tbDescription.Text.Trim());
                updateTypeCmd.Parameters.AddWithValue("@Gender", gender);
                updateTypeCmd.Parameters.AddWithValue("@MaxAge", nudMaxAge.Value);
                updateTypeCmd.Parameters.AddWithValue("@BenTypeId", benTypeId);

                try
                {
                    conn.Open();
                    updateTypeCmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Beneficiary updated but could not update type details: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ClearForm()
        {
            tbBenId.Clear();
            tbName.Clear();
            tbSurname.Clear();
            tbID.Clear();
            tbCell.Clear();
            tbEmail.Clear();
            tbDescription.Clear();
            cmbBenType.SelectedIndex = 0;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            nudMaxAge.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

    }
}
