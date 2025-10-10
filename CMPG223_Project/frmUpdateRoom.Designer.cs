namespace CMPG223_Project
{
	partial class frmUpdateRoom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateRoom));
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblRoom = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblRoomID = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.lblBedCount = new System.Windows.Forms.Label();
			this.txtRoom = new System.Windows.Forms.TextBox();
			this.txtBedCount = new System.Windows.Forms.TextBox();
			this.grpNamingConventions = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRoomTypeSuggestion = new System.Windows.Forms.Label();
			this.lblRoomType = new System.Windows.Forms.Label();
			this.lblNamingConventions = new System.Windows.Forms.Label();
			this.grpNamingConventions.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(367, 99);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(186, 37);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Filter by Room ID";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(168, 282);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(250, 55);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Update Room Details";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Location = new System.Drawing.Point(18, 183);
			this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(117, 19);
			this.lblRoom.TabIndex = 0;
			this.lblRoom.Text = "Room number:";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 22);
			this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(301, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Update Room Details";
			// 
			// lblRoomID
			// 
			this.lblRoomID.AutoSize = true;
			this.lblRoomID.Location = new System.Drawing.Point(18, 108);
			this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRoomID.Name = "lblRoomID";
			this.lblRoomID.Size = new System.Drawing.Size(79, 19);
			this.lblRoomID.TabIndex = 0;
			this.lblRoomID.Text = "Room ID:";
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(143, 105);
			this.txtRoomID.Margin = new System.Windows.Forms.Padding(4);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(216, 27);
			this.txtRoomID.TabIndex = 1;
			// 
			// lblBedCount
			// 
			this.lblBedCount.AutoSize = true;
			this.lblBedCount.Location = new System.Drawing.Point(18, 233);
			this.lblBedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBedCount.Name = "lblBedCount";
			this.lblBedCount.Size = new System.Drawing.Size(85, 19);
			this.lblBedCount.TabIndex = 0;
			this.lblBedCount.Text = "Bed count:";
			// 
			// txtRoom
			// 
			this.txtRoom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRoom.Location = new System.Drawing.Point(143, 180);
			this.txtRoom.Margin = new System.Windows.Forms.Padding(4);
			this.txtRoom.Name = "txtRoom";
			this.txtRoom.Size = new System.Drawing.Size(304, 27);
			this.txtRoom.TabIndex = 3;
			// 
			// txtBedCount
			// 
			this.txtBedCount.Location = new System.Drawing.Point(143, 230);
			this.txtBedCount.Margin = new System.Windows.Forms.Padding(4);
			this.txtBedCount.Name = "txtBedCount";
			this.txtBedCount.Size = new System.Drawing.Size(304, 27);
			this.txtBedCount.TabIndex = 4;
			// 
			// grpNamingConventions
			// 
			this.grpNamingConventions.Controls.Add(this.label1);
			this.grpNamingConventions.Controls.Add(this.lblRoomTypeSuggestion);
			this.grpNamingConventions.Controls.Add(this.lblRoomType);
			this.grpNamingConventions.Controls.Add(this.lblNamingConventions);
			this.grpNamingConventions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpNamingConventions.Location = new System.Drawing.Point(19, 370);
			this.grpNamingConventions.Name = "grpNamingConventions";
			this.grpNamingConventions.Size = new System.Drawing.Size(546, 373);
			this.grpNamingConventions.TabIndex = 6;
			this.grpNamingConventions.TabStop = false;
			this.grpNamingConventions.Text = "Naming suggestions";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(301, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 209);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// lblRoomTypeSuggestion
			// 
			this.lblRoomTypeSuggestion.AutoSize = true;
			this.lblRoomTypeSuggestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomTypeSuggestion.Location = new System.Drawing.Point(241, 143);
			this.lblRoomTypeSuggestion.Name = "lblRoomTypeSuggestion";
			this.lblRoomTypeSuggestion.Size = new System.Drawing.Size(48, 209);
			this.lblRoomTypeSuggestion.TabIndex = 0;
			this.lblRoomTypeSuggestion.Text = ">>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>\r\n>>>";
			// 
			// lblRoomType
			// 
			this.lblRoomType.AutoSize = true;
			this.lblRoomType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomType.Location = new System.Drawing.Point(64, 143);
			this.lblRoomType.Name = "lblRoomType";
			this.lblRoomType.Size = new System.Drawing.Size(163, 209);
			this.lblRoomType.TabIndex = 0;
			this.lblRoomType.Text = resources.GetString("lblRoomType.Text");
			// 
			// lblNamingConventions
			// 
			this.lblNamingConventions.AutoSize = true;
			this.lblNamingConventions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNamingConventions.Location = new System.Drawing.Point(7, 43);
			this.lblNamingConventions.Name = "lblNamingConventions";
			this.lblNamingConventions.Size = new System.Drawing.Size(527, 76);
			this.lblNamingConventions.TabIndex = 0;
			this.lblNamingConventions.Text = "The following are suggestions for naming conventions of room numbers.\r\n\r\nThese su" +
    "ggestions can assist staff with assigning the appropriate rooms\r\nto the appropri" +
    "ate beneficiaries.";
			// 
			// frmUpdateRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 755);
			this.Controls.Add(this.grpNamingConventions);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblRoom);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.lblRoomID);
			this.Controls.Add(this.txtRoomID);
			this.Controls.Add(this.lblBedCount);
			this.Controls.Add(this.txtRoom);
			this.Controls.Add(this.txtBedCount);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmUpdateRoom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Room";
			this.grpNamingConventions.ResumeLayout(false);
			this.grpNamingConventions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblRoom;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Label lblRoomID;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label lblBedCount;
		private System.Windows.Forms.TextBox txtRoom;
		private System.Windows.Forms.TextBox txtBedCount;
		private System.Windows.Forms.GroupBox grpNamingConventions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblRoomTypeSuggestion;
		private System.Windows.Forms.Label lblRoomType;
		private System.Windows.Forms.Label lblNamingConventions;
	}
}