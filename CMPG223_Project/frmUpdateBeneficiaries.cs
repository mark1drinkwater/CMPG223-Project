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
using System.Xml.Linq;

namespace CMPG223_Project
{
	public partial class frmUpdateBeneficiaries : Form
	{
		public frmUpdateBeneficiaries()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!long.TryParse(tbBenId.Text.Trim(), out long benId))
			{
				MessageBox.Show("Please enter a valid Beneficiary ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string sql = @"SELECT Name, Surname, Id_Number, Cell_Number, Email_Address
                               FROM Beneficiary
                               WHERE Ben_Id = @BenId";
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.Add("@BenId", SqlDbType.BigInt).Value = benId;

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
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (!long.TryParse(tbBenId.Text.Trim(), out long benId))
			{
				MessageBox.Show("Please enter a valid Beneficiary ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbSurname.Text))
			{
				MessageBox.Show("Please fill in required fields (Name and Surname).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				string updateSql = @"UPDATE Beneficiary
                                     SET Name = @Name,
                                         Surname = @Surname,
                                         Id_Number = @IdNumber,
                                         Cell_Number = @CellNumber,
                                         Email_Address = @Email
                                     WHERE Ben_Id = @BenId";
				using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
				{
					updateCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = tbName.Text.Trim();
					updateCmd.Parameters.Add("@Surname", SqlDbType.NVarChar, 50).Value = tbSurname.Text.Trim();
					updateCmd.Parameters.Add("@IdNumber", SqlDbType.NVarChar, 13).Value = tbID.Text.Trim();
					updateCmd.Parameters.Add("@CellNumber", SqlDbType.VarChar, 10).Value = tbCell.Text.Trim();
					updateCmd.Parameters.Add("@Email", SqlDbType.NVarChar, 200).Value = tbEmail.Text.Trim();
					updateCmd.Parameters.Add("@BenId", SqlDbType.BigInt).Value = benId;

					try
					{
						conn.Open();
						int rowsAffected = updateCmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Beneficiary personal details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		}

		private void ClearForm()
		{
			tbBenId.Clear();
			tbName.Clear();
			tbSurname.Clear();
			tbID.Clear();
			tbCell.Clear();
			tbEmail.Clear();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
	}
}
