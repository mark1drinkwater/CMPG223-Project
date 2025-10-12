using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Project
{
    public partial class frmNewBeneficiaries : Form
    {
        public frmNewBeneficiaries()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtCell.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields: Name, Surname, ID Number, Cell Number, Email, and Beneficiary Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate ID before inserting
            if (CheckDuplicateId(txtID.Text.Trim()))
            {
                MessageBox.Show("A beneficiary with this ID number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                txtID.SelectAll();
                return;
            }

            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string getTypeIdSql = "SELECT Ben_Type_Id FROM Beneficiary_Type WHERE Description = @Description";
                SqlCommand getTypeIdCmd = new SqlCommand(getTypeIdSql, conn);
                getTypeIdCmd.Parameters.AddWithValue("@Description", cmbBenType.SelectedItem.ToString());

                string insertSql = "INSERT INTO Beneficiary (Name, Surname, Id_Number, Cell_Number, Email_Address, Ben_Type_Id) VALUES (@Name, @Surname, @IdNumber, @CellNumber, @Email, @BenTypeId)";
                SqlCommand cmd = new SqlCommand(insertSql, conn);

                try
                {
                    conn.Open();

                    object result = getTypeIdCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Invalid beneficiary type selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int benTypeId = Convert.ToInt32(result);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdNumber", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@CellNumber", txtCell.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
					cmd.Parameters.AddWithValue("@BenTypeId", benTypeId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Beneficiary added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear fields automatically after successful add
                    ClearForm();
                }
                catch (SqlException ex)
                {
                    // Backup duplicate check in case the first one failed
                    if (CheckDuplicateId(txtID.Text.Trim()))
                    {
                        MessageBox.Show("A beneficiary with this ID number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Contains("foreign key") || ex.Message.Contains("Ben_Type_Id"))
                    {
                        MessageBox.Show("Invalid beneficiary type selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Check for duplicate ID numbers
        private bool CheckDuplicateId(string idNumber)
        {
            using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
            {
                string sql = "SELECT COUNT(*) FROM Beneficiary WHERE Id_Number = @IdNumber";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdNumber", idNumber);

                try
                {
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception)
                {
                    return false; 
                }
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtID.Clear();
            txtCell.Clear();
            txtEmail.Clear();
            cmbBenType.SelectedIndex = 0; 
        }
    }
}
