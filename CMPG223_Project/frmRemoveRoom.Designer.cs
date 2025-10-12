namespace CMPG223_Project
{
	partial class frmRemoveRoom
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
			this.dgvRooms = new System.Windows.Forms.DataGridView();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnFilter = new System.Windows.Forms.Button();
			this.lblRoomID = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 9);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(214, 33);
			this.lblHeader.TabIndex = 1;
			this.lblHeader.Text = "Remove Room";
			// 
			// dgvRooms
			// 
			this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRooms.Location = new System.Drawing.Point(18, 70);
			this.dgvRooms.Margin = new System.Windows.Forms.Padding(4);
			this.dgvRooms.Name = "dgvRooms";
			this.dgvRooms.Size = new System.Drawing.Size(553, 374);
			this.dgvRooms.TabIndex = 2;
			// 
			// btnShowAll
			// 
			this.btnShowAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(13, 536);
			this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(250, 55);
			this.btnShowAll.TabIndex = 8;
			this.btnShowAll.Text = "Show All Rooms";
			this.btnShowAll.UseVisualStyleBackColor = true;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(316, 536);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(250, 55);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete Room";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilter.Location = new System.Drawing.Point(355, 468);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(211, 37);
			this.btnFilter.TabIndex = 7;
			this.btnFilter.Text = "Filter by Room ID";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// lblRoomID
			// 
			this.lblRoomID.AutoSize = true;
			this.lblRoomID.Location = new System.Drawing.Point(15, 477);
			this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRoomID.Name = "lblRoomID";
			this.lblRoomID.Size = new System.Drawing.Size(77, 20);
			this.lblRoomID.TabIndex = 5;
			this.lblRoomID.Text = "Room ID:";
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(107, 474);
			this.txtRoomID.Margin = new System.Windows.Forms.Padding(4);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(240, 26);
			this.txtRoomID.TabIndex = 6;
			// 
			// frmRemoveRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 611);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.lblRoomID);
			this.Controls.Add(this.txtRoomID);
			this.Controls.Add(this.dgvRooms);
			this.Controls.Add(this.lblHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmRemoveRoom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remove Room";
			((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.DataGridView dgvRooms;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Label lblRoomID;
		private System.Windows.Forms.TextBox txtRoomID;
	}
}