
namespace CMPG223_Project
{
    partial class frmRemoveBeneficiaries
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
			this.dgvBenificiaries = new System.Windows.Forms.DataGridView();
			this.btnFilter = new System.Windows.Forms.Button();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblBenID = new System.Windows.Forms.Label();
			this.txtBenID = new System.Windows.Forms.TextBox();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBenificiaries)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBenificiaries
			// 
			this.dgvBenificiaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBenificiaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBenificiaries.Location = new System.Drawing.Point(18, 70);
			this.dgvBenificiaries.Margin = new System.Windows.Forms.Padding(4);
			this.dgvBenificiaries.Name = "dgvBenificiaries";
			this.dgvBenificiaries.Size = new System.Drawing.Size(1053, 374);
			this.dgvBenificiaries.TabIndex = 0;
			// 
			// btnFilter
			// 
			this.btnFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.Location = new System.Drawing.Point(674, 463);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(175, 37);
			this.btnFilter.TabIndex = 2;
			this.btnFilter.Text = "Filter beneficiary";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(18, 13);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(359, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Remove Main Beneficiary";
			// 
			// lblBenID
			// 
			this.lblBenID.AutoSize = true;
			this.lblBenID.Location = new System.Drawing.Point(226, 477);
			this.lblBenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBenID.Name = "lblBenID";
			this.lblBenID.Size = new System.Drawing.Size(113, 19);
			this.lblBenID.TabIndex = 0;
			this.lblBenID.Text = "Beneficiary ID:";
			// 
			// txtBenID
			// 
			this.txtBenID.Location = new System.Drawing.Point(388, 469);
			this.txtBenID.Margin = new System.Windows.Forms.Padding(4);
			this.txtBenID.Name = "txtBenID";
			this.txtBenID.Size = new System.Drawing.Size(247, 27);
			this.txtBenID.TabIndex = 1;
			// 
			// btnShowAll
			// 
			this.btnShowAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(230, 534);
			this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(250, 55);
			this.btnShowAll.TabIndex = 3;
			this.btnShowAll.Text = "Show All Beneficiaries";
			this.btnShowAll.UseVisualStyleBackColor = true;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(599, 534);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(250, 55);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete Beneficiary";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmRemoveBeneficiaries
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 611);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblBenID);
			this.Controls.Add(this.txtBenID);
			this.Controls.Add(this.dgvBenificiaries);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmRemoveBeneficiaries";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remove Beneficiaries";
			((System.ComponentModel.ISupportInitialize)(this.dgvBenificiaries)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBenificiaries;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBenID;
        private System.Windows.Forms.TextBox txtBenID;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
    }
}