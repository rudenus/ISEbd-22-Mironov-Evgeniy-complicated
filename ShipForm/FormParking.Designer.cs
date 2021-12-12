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
            this.AddParkingButton = new System.Windows.Forms.Button();
            this.RemoveParkingButton = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewParking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.putInStackButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveParkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadParkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1079, 601);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PickUpButton);
            this.groupBox1.Location = new System.Drawing.Point(1086, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(155, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick up ship";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(75, 46);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(41, 22);
            this.maskedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place";
            // 
            // PickUpButton
            // 
            this.PickUpButton.Location = new System.Drawing.Point(0, 84);
            this.PickUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(149, 25);
            this.PickUpButton.TabIndex = 0;
            this.PickUpButton.Text = "Pick Up From Stack";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // ParkingShipButton
            // 
            this.ParkingShipButton.Location = new System.Drawing.Point(1081, 290);
            this.ParkingShipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParkingShipButton.Name = "ParkingShipButton";
            this.ParkingShipButton.Size = new System.Drawing.Size(143, 46);
            this.ParkingShipButton.TabIndex = 2;
            this.ParkingShipButton.Text = "Park the Ship";
            this.ParkingShipButton.UseVisualStyleBackColor = true;
            this.ParkingShipButton.Click += new System.EventHandler(this.ParkingShipButton_Click);
            // 
            // AddParkingButton
            // 
            this.AddParkingButton.AutoSize = true;
            this.AddParkingButton.Location = new System.Drawing.Point(1085, 96);
            this.AddParkingButton.Name = "AddParkingButton";
            this.AddParkingButton.Size = new System.Drawing.Size(139, 27);
            this.AddParkingButton.TabIndex = 4;
            this.AddParkingButton.Text = "Add Parking";
            this.AddParkingButton.UseVisualStyleBackColor = true;
            this.AddParkingButton.Click += new System.EventHandler(this.AddParkingButton_Click);
            // 
            // RemoveParkingButton
            // 
            this.RemoveParkingButton.Location = new System.Drawing.Point(1086, 237);
            this.RemoveParkingButton.Name = "RemoveParkingButton";
            this.RemoveParkingButton.Size = new System.Drawing.Size(138, 30);
            this.RemoveParkingButton.TabIndex = 5;
            this.RemoveParkingButton.Text = "Remove Parking";
            this.RemoveParkingButton.UseVisualStyleBackColor = true;
            this.RemoveParkingButton.Click += new System.EventHandler(this.RemoveParkingButton_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(1086, 147);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(138, 84);
            this.listBoxParkings.TabIndex = 6;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewParking
            // 
            this.textBoxNewParking.Location = new System.Drawing.Point(1085, 68);
            this.textBoxNewParking.Name = "textBoxNewParking";
            this.textBoxNewParking.Size = new System.Drawing.Size(139, 22);
            this.textBoxNewParking.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parking Lots";
            // 
            // putInStackButton
            // 
            this.putInStackButton.Location = new System.Drawing.Point(1081, 404);
            this.putInStackButton.Name = "putInStackButton";
            this.putInStackButton.Size = new System.Drawing.Size(138, 35);
            this.putInStackButton.TabIndex = 9;
            this.putInStackButton.Text = "Put Into Stack";
            this.putInStackButton.UseVisualStyleBackColor = true;
            this.putInStackButton.Click += new System.EventHandler(this.putInStackButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveParkingToolStripMenuItem,
            this.loadParkingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.saveToolStripMenuItem.Text = "Save All";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.loadToolStripMenuItem.Text = "Load All";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveParkingToolStripMenuItem
            // 
            this.saveParkingToolStripMenuItem.Name = "saveParkingToolStripMenuItem";
            this.saveParkingToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.saveParkingToolStripMenuItem.Text = "Save Parking";
            this.saveParkingToolStripMenuItem.Click += new System.EventHandler(this.saveParkingToolStripMenuItem_Click);
            // 
            // loadParkingToolStripMenuItem
            // 
            this.loadParkingToolStripMenuItem.Name = "loadParkingToolStripMenuItem";
            this.loadParkingToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.loadParkingToolStripMenuItem.Text = "Load Parking";
            this.loadParkingToolStripMenuItem.Click += new System.EventHandler(this.loadParkingToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1081, 341);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(143, 47);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 629);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.putInStackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.RemoveParkingButton);
            this.Controls.Add(this.AddParkingButton);
            this.Controls.Add(this.ParkingShipButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormParking";
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PickUpButton;
        private System.Windows.Forms.Button ParkingShipButton;
        private System.Windows.Forms.Button AddParkingButton;
        private System.Windows.Forms.Button RemoveParkingButton;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewParking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button putInStackButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveParkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadParkingToolStripMenuItem;
        private System.Windows.Forms.Button buttonSort;
    }
}