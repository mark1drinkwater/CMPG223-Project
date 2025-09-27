using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
			Application.Exit();
		}
	}
}
