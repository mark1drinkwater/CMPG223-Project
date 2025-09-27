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
    public partial class frmEntryLogin : Form
    {
        public frmEntryLogin()
        {
            InitializeComponent();
        }

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			//Change as necessary for validating login details etc.
			this.Hide();
			frmMainDash mainForm = new frmMainDash();
			mainForm.Show();
		}
	}
}
