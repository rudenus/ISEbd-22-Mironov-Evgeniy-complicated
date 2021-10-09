namespace ShipForm
{
	partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PickUpButton = new System.Windows.Forms.Button();
			this.ParkingShipButton = new System.Windows.Forms.Button();
			this.ParkingSteamerButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(809, 511);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.PickUpButton);
			this.groupBox1.Location = new System.Drawing.Point(813, 170);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(116, 92);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pick up ship";
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(56, 37);
			this.maskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(32, 20);
			this.maskedTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Place";
			// 
			// PickUpButton
			// 
			this.PickUpButton.Location = new System.Drawing.Point(30, 68);
			this.PickUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PickUpButton.Name = "PickUpButton";
			this.PickUpButton.Size = new System.Drawing.Size(56, 19);
			this.PickUpButton.TabIndex = 0;
			this.PickUpButton.Text = "Pick Up";
			this.PickUpButton.UseVisualStyleBackColor = true;
			this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
			// 
			// ParkingShipButton
			// 
			this.ParkingShipButton.Location = new System.Drawing.Point(813, 56);
			this.ParkingShipButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ParkingShipButton.Name = "ParkingShipButton";
			this.ParkingShipButton.Size = new System.Drawing.Size(107, 31);
			this.ParkingShipButton.TabIndex = 2;
			this.ParkingShipButton.Text = "Parking Ship";
			this.ParkingShipButton.UseVisualStyleBackColor = true;
			this.ParkingShipButton.Click += new System.EventHandler(this.ParkingShipButton_Click);
			// 
			// ParkingSteamerButton
			// 
			this.ParkingSteamerButton.Location = new System.Drawing.Point(813, 116);
			this.ParkingSteamerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ParkingSteamerButton.Name = "ParkingSteamerButton";
			this.ParkingSteamerButton.Size = new System.Drawing.Size(107, 31);
			this.ParkingSteamerButton.TabIndex = 3;
			this.ParkingSteamerButton.Text = "Parking Steamer";
			this.ParkingSteamerButton.UseVisualStyleBackColor = true;
			this.ParkingSteamerButton.Click += new System.EventHandler(this.ParkingSteamerButton_Click);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 511);
			this.Controls.Add(this.ParkingSteamerButton);
			this.Controls.Add(this.ParkingShipButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxParking);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormParking";
			this.Text = "Parking";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button PickUpButton;
		private System.Windows.Forms.Button ParkingShipButton;
		private System.Windows.Forms.Button ParkingSteamerButton;
	}
}