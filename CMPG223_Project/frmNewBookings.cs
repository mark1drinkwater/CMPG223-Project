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
    public partial class frmNewBookings : Form
    {
        
        private readonly string connectionString = ".....";//Connection string here please

        public frmNewBookings()
        {
            InitializeComponent();
            LoadComboBoxes();
            dtpMeal.Visible = lblMeal.Visible = false; //Hide Claimed date control if add meal ticket is not selected
        }

        private void ClearFormFields()
        {
            // Set date pickers to today
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today;
            dtpMeal.Value = DateTime.Today;

            // Set combo boxes to first item
            if (cbBeneficiary.Items.Count > 0) cbBeneficiary.SelectedIndex = 0;
            if (cbRoom.Items.Count > 0) cbRoom.SelectedIndex = 0;
            if (cbAdmin.Items.Count > 0) cbAdmin.SelectedIndex = 0;

            // Uncheck and hide meal ticket controls
            chkMealTicket.Checked = false;
            dtpMeal.Visible = false;
            lblMeal.Visible = false;
        }

        private void LoadComboBoxes()
        {
            // Populate Beneficiary ComboBox
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Ben_Id, Name FROM BENEFICIARY", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cbBeneficiary.DataSource = dt;
                    cbBeneficiary.DisplayMember = "Name";
                    cbBeneficiary.ValueMember = "Ben_Id";
                }
            }

            // Populate Room ComboBox
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Room_Id, Room_number FROM ROOM", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cbRoom.DataSource = dt;
                    cbRoom.DisplayMember = "Room_number";
                    cbRoom.ValueMember = "Room_Id";
                }
            }

            // Populate Admin ComboBox 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Admin_Id, Username FROM ADMIN_LOGIN", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cbAdmin.DataSource = dt;
                    cbAdmin.DisplayMember = "Username";
                    cbAdmin.ValueMember = "Admin_Id";
                }
            }
        }

        private void chkMealTicket_CheckedChanged(object sender, EventArgs e)
        {
            dtpMeal.Visible = lblMeal.Visible = chkMealTicket.Checked;
        }

      

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (cbBeneficiary.SelectedValue == null || cbRoom.SelectedValue == null || cbAdmin.SelectedValue == null)
            {
                MessageBox.Show("Please select a beneficiary, room, and admin.");
                return;
            }

            int benId = Convert.ToInt32(cbBeneficiary.SelectedValue);
            int roomId = Convert.ToInt32(cbRoom.SelectedValue);
            int adminId = Convert.ToInt32(cbAdmin.SelectedValue);
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;

            int bookingId = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Insert into BOOKING
                string insertBooking = "INSERT INTO BOOKING (Check_In, Check_Out, Ben_Id, Admin_Id, Room_Id) " +
                                       "OUTPUT INSERTED.Booking_Id " +
                                       "VALUES (@CheckIn, @CheckOut, @BenId, @AdminId, @RoomId)";
                using (SqlCommand cmd = new SqlCommand(insertBooking, conn))
                {
                    cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                    cmd.Parameters.AddWithValue("@CheckOut", checkOut);
                    cmd.Parameters.AddWithValue("@BenId", benId);
                    cmd.Parameters.AddWithValue("@AdminId", adminId);
                    cmd.Parameters.AddWithValue("@RoomId", roomId);

                    bookingId = (int)cmd.ExecuteScalar();
                }

                // If meal ticket is checked, insert into MEAL_TICKET
                if (chkMealTicket.Checked)
                {
                    DateTime claimedDate = dtpMeal.Value;
                    string insertMeal = "INSERT INTO MEAL_TICKET (Claimed_date, Booking_Id) VALUES (@ClaimedDate, @BookingId)";
                    using (SqlCommand cmd = new SqlCommand(insertMeal, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClaimedDate", claimedDate);
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Booking added successfully");
            ClearFormFields();
        }
    }
}