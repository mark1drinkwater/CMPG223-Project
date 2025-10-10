namespace CMPG223_Project
{
	partial class frmNewRoom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewRoom));
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblRoom = new System.Windows.Forms.Label();
			this.txtRoom = new System.Windows.Forms.TextBox();
			this.lblBeds = new System.Windows.Forms.Label();
			this.txtBedCount = new System.Windows.Forms.TextBox();
			this.btnAddRoom = new System.Windows.Forms.Button();
			this.grpNamingConventions = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRoomTypeSuggestion = new System.Windows.Forms.Label();
			this.lblRoomType = new System.Windows.Forms.Label();
			this.lblNamingConventions = new System.Windows.Forms.Label();
			this.grpNamingConventions.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(12, 9);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(224, 33);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Add New Room";
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Location = new System.Drawing.Point(18, 100);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(117, 19);
			this.lblRoom.TabIndex = 0;
			this.lblRoom.Text = "Room number:";
			// 
			// txtRoom
			// 
			this.txtRoom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRoom.Location = new System.Drawing.Point(141, 97);
			this.txtRoom.Name = "txtRoom";
			this.txtRoom.Size = new System.Drawing.Size(199, 27);
			this.txtRoom.TabIndex = 1;
			// 
			// lblBeds
			// 
			this.lblBeds.AutoSize = true;
			this.lblBeds.Location = new System.Drawing.Point(18, 150);
			this.lblBeds.Name = "lblBeds";
			this.lblBeds.Size = new System.Drawing.Size(85, 19);
			this.lblBeds.TabIndex = 0;
			this.lblBeds.Text = "Bed count:";
			// 
			// txtBedCount
			// 
			this.txtBedCount.Location = new System.Drawing.Point(141, 147);
			this.txtBedCount.Name = "txtBedCount";
			this.txtBedCount.Size = new System.Drawing.Size(199, 27);
			this.txtBedCount.TabIndex = 2;
			// 
			// btnAddRoom
			// 
			this.btnAddRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRoom.Location = new System.Drawing.Point(359, 107);
			this.btnAddRoom.Name = "btnAddRoom";
			this.btnAddRoom.Size = new System.Drawing.Size(209, 55);
			this.btnAddRoom.TabIndex = 3;
			this.btnAddRoom.Text = "Add New Room";
			this.btnAddRoom.UseVisualStyleBackColor = true;
			// 
			// grpNamingConventions
			// 
			this.grpNamingConventions.Controls.Add(this.label1);
			this.grpNamingConventions.Controls.Add(this.lblRoomTypeSuggestion);
			this.grpNamingConventions.Controls.Add(this.lblRoomType);
			this.grpNamingConventions.Controls.Add(this.lblNamingConventions);
			this.grpNamingConventions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpNamingConventions.Location = new System.Drawing.Point(22, 225);
			this.grpNamingConventions.Name = "grpNamingConventions";
			this.grpNamingConventions.Size = new System.Drawing.Size(546, 373);
			this.grpNamingConventions.TabIndex = 0;
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
			// frmNewRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 615);
			this.Controls.Add(this.grpNamingConventions);
			this.Controls.Add(this.btnAddRoom);
			this.Controls.Add(this.txtBedCount);
			this.Controls.Add(this.lblBeds);
			this.Controls.Add(this.txtRoom);
			this.Controls.Add(this.lblRoom);
			this.Controls.Add(this.lblHeader);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmNewRoom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Room";
			this.grpNamingConventions.ResumeLayout(false);
			this.grpNamingConventions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Label lblRoom;
		private System.Windows.Forms.TextBox txtRoom;
		private System.Windows.Forms.Label lblBeds;
		private System.Windows.Forms.TextBox txtBedCount;
		private System.Windows.Forms.Button btnAddRoom;
		private System.Windows.Forms.GroupBox grpNamingConventions;
		private System.Windows.Forms.Label lblNamingConventions;
		private System.Windows.Forms.Label lblRoomTypeSuggestion;
		private System.Windows.Forms.Label lblRoomType;
		private System.Windows.Forms.Label label1;
	}
}