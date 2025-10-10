
namespace CMPG223_Project
{
    partial class frmNewAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.lblRole = new System.Windows.Forms.Label();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(90, 312);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(250, 55);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add New User";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(18, 145);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(82, 19);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Password:";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(327, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Add New Staff Member";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(18, 95);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(86, 19);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(140, 92);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(255, 27);
			this.txtName.TabIndex = 1;
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(140, 142);
			this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.ShortcutsEnabled = false;
			this.txtSurname.Size = new System.Drawing.Size(255, 27);
			this.txtSurname.TabIndex = 2;
			// 
			// lblRole
			// 
			this.lblRole.AutoSize = true;
			this.lblRole.Location = new System.Drawing.Point(18, 220);
			this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(46, 19);
			this.lblRole.TabIndex = 0;
			this.lblRole.Text = "Role:";
			// 
			// cmbRole
			// 
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Items.AddRange(new object[] {
            "System Owner",
            "Receptionist"});
			this.cmbRole.Location = new System.Drawing.Point(140, 217);
			this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(255, 27);
			this.cmbRole.TabIndex = 3;
			this.cmbRole.Text = "Select role";
			// 
			// frmNewAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 421);
			this.Controls.Add(this.cmbRole);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtSurname);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmNewAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Staff";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}