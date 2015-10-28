namespace ePlan.TileCalculator.UI
{
	partial class Form1
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
			this.cmbPattern = new System.Windows.Forms.ComboBox();
			this.lblPattern = new System.Windows.Forms.Label();
			this.lblRoomWidth = new System.Windows.Forms.Label();
			this.txtRoomWidth = new System.Windows.Forms.TextBox();
			this.txtRoomLength = new System.Windows.Forms.TextBox();
			this.lblRoomLength = new System.Windows.Forms.Label();
			this.lblTileWidth = new System.Windows.Forms.Label();
			this.txtTileWidth = new System.Windows.Forms.TextBox();
			this.txtTileLength = new System.Windows.Forms.TextBox();
			this.lblTileLength = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblTotalTilesUsed = new System.Windows.Forms.Label();
			this.lblTotalCuts = new System.Windows.Forms.Label();
			this.lblWaste = new System.Windows.Forms.Label();
			this.txtTotalTilesUsed = new System.Windows.Forms.TextBox();
			this.txtTotalCuts = new System.Windows.Forms.TextBox();
			this.txtWaste = new System.Windows.Forms.TextBox();
			this.lblGroutThickness = new System.Windows.Forms.Label();
			this.txtGroutThickness = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmbPattern
			// 
			this.cmbPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPattern.FormattingEnabled = true;
			this.cmbPattern.Location = new System.Drawing.Point(12, 25);
			this.cmbPattern.Name = "cmbPattern";
			this.cmbPattern.Size = new System.Drawing.Size(214, 21);
			this.cmbPattern.TabIndex = 0;
			// 
			// lblPattern
			// 
			this.lblPattern.AutoSize = true;
			this.lblPattern.Location = new System.Drawing.Point(9, 9);
			this.lblPattern.Name = "lblPattern";
			this.lblPattern.Size = new System.Drawing.Size(41, 13);
			this.lblPattern.TabIndex = 1;
			this.lblPattern.Text = "Pattern";
			// 
			// lblRoomWidth
			// 
			this.lblRoomWidth.AutoSize = true;
			this.lblRoomWidth.Location = new System.Drawing.Point(9, 49);
			this.lblRoomWidth.Name = "lblRoomWidth";
			this.lblRoomWidth.Size = new System.Drawing.Size(66, 13);
			this.lblRoomWidth.TabIndex = 2;
			this.lblRoomWidth.Text = "Room Width";
			// 
			// txtRoomWidth
			// 
			this.txtRoomWidth.Location = new System.Drawing.Point(12, 65);
			this.txtRoomWidth.Name = "txtRoomWidth";
			this.txtRoomWidth.Size = new System.Drawing.Size(100, 20);
			this.txtRoomWidth.TabIndex = 3;
			// 
			// txtRoomLength
			// 
			this.txtRoomLength.Location = new System.Drawing.Point(126, 65);
			this.txtRoomLength.Name = "txtRoomLength";
			this.txtRoomLength.Size = new System.Drawing.Size(100, 20);
			this.txtRoomLength.TabIndex = 4;
			// 
			// lblRoomLength
			// 
			this.lblRoomLength.AutoSize = true;
			this.lblRoomLength.Location = new System.Drawing.Point(123, 49);
			this.lblRoomLength.Name = "lblRoomLength";
			this.lblRoomLength.Size = new System.Drawing.Size(71, 13);
			this.lblRoomLength.TabIndex = 5;
			this.lblRoomLength.Text = "Room Length";
			// 
			// lblTileWidth
			// 
			this.lblTileWidth.AutoSize = true;
			this.lblTileWidth.Location = new System.Drawing.Point(9, 88);
			this.lblTileWidth.Name = "lblTileWidth";
			this.lblTileWidth.Size = new System.Drawing.Size(55, 13);
			this.lblTileWidth.TabIndex = 6;
			this.lblTileWidth.Text = "Tile Width";
			// 
			// txtTileWidth
			// 
			this.txtTileWidth.Location = new System.Drawing.Point(12, 104);
			this.txtTileWidth.Name = "txtTileWidth";
			this.txtTileWidth.Size = new System.Drawing.Size(100, 20);
			this.txtTileWidth.TabIndex = 7;
			// 
			// txtTileLength
			// 
			this.txtTileLength.Location = new System.Drawing.Point(126, 104);
			this.txtTileLength.Name = "txtTileLength";
			this.txtTileLength.Size = new System.Drawing.Size(100, 20);
			this.txtTileLength.TabIndex = 8;
			// 
			// lblTileLength
			// 
			this.lblTileLength.AutoSize = true;
			this.lblTileLength.Location = new System.Drawing.Point(123, 88);
			this.lblTileLength.Name = "lblTileLength";
			this.lblTileLength.Size = new System.Drawing.Size(60, 13);
			this.lblTileLength.TabIndex = 9;
			this.lblTileLength.Text = "Tile Length";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(151, 168);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 10;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblTotalTilesUsed
			// 
			this.lblTotalTilesUsed.AutoSize = true;
			this.lblTotalTilesUsed.Location = new System.Drawing.Point(9, 215);
			this.lblTotalTilesUsed.Name = "lblTotalTilesUsed";
			this.lblTotalTilesUsed.Size = new System.Drawing.Size(128, 13);
			this.lblTotalTilesUsed.TabIndex = 11;
			this.lblTotalTilesUsed.Text = "Total number of tiles used";
			// 
			// lblTotalCuts
			// 
			this.lblTotalCuts.AutoSize = true;
			this.lblTotalCuts.Location = new System.Drawing.Point(9, 254);
			this.lblTotalCuts.Name = "lblTotalCuts";
			this.lblTotalCuts.Size = new System.Drawing.Size(133, 13);
			this.lblTotalCuts.TabIndex = 12;
			this.lblTotalCuts.Text = "Total number of cuts made";
			// 
			// lblWaste
			// 
			this.lblWaste.AutoSize = true;
			this.lblWaste.Location = new System.Drawing.Point(9, 293);
			this.lblWaste.Name = "lblWaste";
			this.lblWaste.Size = new System.Drawing.Size(96, 13);
			this.lblWaste.TabIndex = 13;
			this.lblWaste.Text = "Waste Percentage";
			// 
			// txtTotalTilesUsed
			// 
			this.txtTotalTilesUsed.Location = new System.Drawing.Point(12, 231);
			this.txtTotalTilesUsed.Name = "txtTotalTilesUsed";
			this.txtTotalTilesUsed.Size = new System.Drawing.Size(214, 20);
			this.txtTotalTilesUsed.TabIndex = 14;
			// 
			// txtTotalCuts
			// 
			this.txtTotalCuts.Location = new System.Drawing.Point(12, 270);
			this.txtTotalCuts.Name = "txtTotalCuts";
			this.txtTotalCuts.Size = new System.Drawing.Size(214, 20);
			this.txtTotalCuts.TabIndex = 15;
			// 
			// txtWaste
			// 
			this.txtWaste.Location = new System.Drawing.Point(12, 309);
			this.txtWaste.Name = "txtWaste";
			this.txtWaste.Size = new System.Drawing.Size(214, 20);
			this.txtWaste.TabIndex = 16;
			// 
			// lblGroutThickness
			// 
			this.lblGroutThickness.AutoSize = true;
			this.lblGroutThickness.Location = new System.Drawing.Point(9, 127);
			this.lblGroutThickness.Name = "lblGroutThickness";
			this.lblGroutThickness.Size = new System.Drawing.Size(85, 13);
			this.lblGroutThickness.TabIndex = 17;
			this.lblGroutThickness.Text = "Grout Thickness";
			// 
			// txtGroutThickness
			// 
			this.txtGroutThickness.Location = new System.Drawing.Point(12, 143);
			this.txtGroutThickness.Name = "txtGroutThickness";
			this.txtGroutThickness.Size = new System.Drawing.Size(214, 20);
			this.txtGroutThickness.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 361);
			this.Controls.Add(this.txtGroutThickness);
			this.Controls.Add(this.lblGroutThickness);
			this.Controls.Add(this.txtWaste);
			this.Controls.Add(this.txtTotalCuts);
			this.Controls.Add(this.txtTotalTilesUsed);
			this.Controls.Add(this.lblWaste);
			this.Controls.Add(this.lblTotalCuts);
			this.Controls.Add(this.lblTotalTilesUsed);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.lblTileLength);
			this.Controls.Add(this.txtTileLength);
			this.Controls.Add(this.txtTileWidth);
			this.Controls.Add(this.lblTileWidth);
			this.Controls.Add(this.lblRoomLength);
			this.Controls.Add(this.txtRoomLength);
			this.Controls.Add(this.txtRoomWidth);
			this.Controls.Add(this.lblRoomWidth);
			this.Controls.Add(this.lblPattern);
			this.Controls.Add(this.cmbPattern);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbPattern;
		private System.Windows.Forms.Label lblPattern;
		private System.Windows.Forms.Label lblRoomWidth;
		private System.Windows.Forms.TextBox txtRoomWidth;
		private System.Windows.Forms.TextBox txtRoomLength;
		private System.Windows.Forms.Label lblRoomLength;
		private System.Windows.Forms.Label lblTileWidth;
		private System.Windows.Forms.TextBox txtTileWidth;
		private System.Windows.Forms.TextBox txtTileLength;
		private System.Windows.Forms.Label lblTileLength;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label lblTotalTilesUsed;
		private System.Windows.Forms.Label lblTotalCuts;
		private System.Windows.Forms.Label lblWaste;
		private System.Windows.Forms.TextBox txtTotalTilesUsed;
		private System.Windows.Forms.TextBox txtTotalCuts;
		private System.Windows.Forms.TextBox txtWaste;
		private System.Windows.Forms.Label lblGroutThickness;
		private System.Windows.Forms.TextBox txtGroutThickness;
	}
}

