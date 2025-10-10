
namespace CMPG223_Project
{
    partial class frmRemoveAdmin
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
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblAminID = new System.Windows.Forms.Label();
			this.txtAdminID = new System.Windows.Forms.TextBox();
			this.dgvAdmin = new System.Windows.Forms.DataGridView();
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(317, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Remove Staff Member";
			// 
			// lblAminID
			// 
			this.lblAminID.AutoSize = true;
			this.lblAminID.Location = new System.Drawing.Point(20, 481);
			this.lblAminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAminID.Name = "lblAminID";
			this.lblAminID.Size = new System.Drawing.Size(69, 19);
			this.lblAminID.TabIndex = 0;
			this.lblAminID.Text = "Staff ID:";
			// 
			// txtAdminID
			// 
			this.txtAdminID.Location = new System.Drawing.Point(112, 478);
			this.txtAdminID.Margin = new System.Windows.Forms.Padding(4);
			this.txtAdminID.Name = "txtAdminID";
			this.txtAdminID.Size = new System.Drawing.Size(276, 27);
			this.txtAdminID.TabIndex = 1;
			// 
			// dgvAdmin
			// 
			this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdmin.Location = new System.Drawing.Point(18, 70);
			this.dgvAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.dgvAdmin.Name = "dgvAdmin";
			this.dgvAdmin.Size = new System.Drawing.Size(553, 374);
			this.dgvAdmin.TabIndex = 0;
			// 
			// btnFilter
			// 
			this.btnFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.Location = new System.Drawing.Point(396, 472);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(175, 37);
			this.btnFilter.TabIndex = 2;
			this.btnFilter.Text = "Filter staff";
			this.btnFilter.UseVisualStyleBackColor = true;
			// 
			// btnShowAll
			// 
			this.btnShowAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(18, 540);
			this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(250, 55);
			this.btnShowAll.TabIndex = 3;
			this.btnShowAll.Text = "Show All Staff";
			this.btnShowAll.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(321, 540);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(250, 55);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete Staff Member";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// frmRemoveAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 611);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblAminID);
			this.Controls.Add(this.txtAdminID);
			this.Controls.Add(this.dgvAdmin);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmRemoveAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remove Staff";
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAminID;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.DataGridView dgvAdmin;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.Button btnDelete;
	}
}