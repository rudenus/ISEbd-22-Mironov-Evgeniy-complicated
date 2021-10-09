namespace ShipForm
{
	partial class FormShip
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonCreate = new System.Windows.Forms.Button();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(534, 17);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 28);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(1253, 629);
            this.pictureBoxShip.TabIndex = 8;
            this.pictureBoxShip.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::ShipForm.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(998, 497);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(77, 79);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::ShipForm.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(1081, 412);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(77, 79);
            this.buttonUp.TabIndex = 10;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::ShipForm.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1081, 497);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(77, 79);
            this.buttonDown.TabIndex = 11;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::ShipForm.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(1164, 497);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(77, 79);
            this.buttonRight.TabIndex = 12;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.comboBoxNumber.Location = new System.Drawing.Point(466, 17);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(49, 24);
            this.comboBoxNumber.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(303, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "number of pipes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "type of ship";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Ship",
            "Steamer",
            "Premium Steamer"});
            this.comboBoxType.Location = new System.Drawing.Point(151, 16);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(146, 24);
            this.comboBoxType.TabIndex = 16;
            // 
            // FormShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 629);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNumber);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxShip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormShip";
            this.Text = "ShipForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}

