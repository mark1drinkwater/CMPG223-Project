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
    public partial class frmMainDash : Form
    {
        public frmMainDash()
        {
            InitializeComponent();
        }

        private void frmMainDash_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Booking";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No bookings found in the system.",
                                        "No Data",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }

                    dgvBookings.DataSource = dt;
                    dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void newBookingsTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmNewBookings mainForm = new frmNewBookings();
			mainForm.Show();
		}

		private void updateBookingsTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmUpdateBookings mainForm = new frmUpdateBookings();
			mainForm.Show();
		}

		private void newBeneficiaryTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmNewBeneficiaries mainForm = new frmNewBeneficiaries();
			mainForm.Show();
		}

		private void updateBeneficiariesTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmUpdateBeneficiaries mainForm = new frmUpdateBeneficiaries();
			mainForm.Show();
		}

		private void removeBeneficiaryTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmRemoveBeneficiaries mainForm = new frmRemoveBeneficiaries();
			mainForm.Show();
		}

		private void newAdminTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmNewAdmin mainForm = new frmNewAdmin();
			mainForm.Show();
		}

		private void updateAdminTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmUpdateAdmin mainForm = new frmUpdateAdmin();
			mainForm.Show();
		}

		private void removeAdminTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmRemoveAdmin mainForm = new frmRemoveAdmin();
			mainForm.Show();
		}

		private void generateReportsTSMI_Click(object sender, EventArgs e)
		{
			//Change as necessary (used to check UI flow)
			frmReports mainForm = new frmReports();
			mainForm.Show();
		}

		private void exitTSMI_Click(object sender, EventArgs e)
		{
            var confirm = MessageBox.Show("Are you sure you want to exit?",
                                          "Exit Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
                Application.Exit();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterCriteria = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterCriteria))
            {
                MessageBox.Show("Please enter a keyword to filter bookings.",
                                "Filter Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
                {
                    conn.Open();

                    string query = @"SELECT * FROM Booking 
                                     WHERE BookingName LIKE @criteria 
                                     OR BeneficiaryName LIKE @criteria
                                     OR CAST(BookingID AS NVARCHAR) LIKE @criteria";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@criteria", "%" + filterCriteria + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No bookings found matching your search.",
                                        "No Results",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }

                    dgvBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering bookings: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int bookingId;
            try
            {
                bookingId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
            }
            catch
            {
                MessageBox.Show("Could not retrieve Booking ID. Please check your grid columns.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this booking?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Booking WHERE BookingID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", bookingId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Booking deleted successfully!",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            LoadBookings(); // refresh grid
                        }
                        else
                        {
                            MessageBox.Show("No booking found with that ID.",
                                            "Not Found",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting booking: " + ex.Message,
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
