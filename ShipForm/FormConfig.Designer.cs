namespace ShipForm
{
    partial class FormConfig
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
            this.groupBoxShipOrSteamer = new System.Windows.Forms.GroupBox();
            this.CreateSteamerLabel = new System.Windows.Forms.Label();
            this.CreateShipLabel = new System.Windows.Forms.Label();
            this.pictureBoxForCreate = new System.Windows.Forms.PictureBox();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxWindow = new System.Windows.Forms.CheckBox();
            this.checkBoxCabin = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelMColor = new System.Windows.Forms.Label();
            this.labelDColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSimplePipes = new System.Windows.Forms.Label();
            this.labelRectanglePipes = new System.Windows.Forms.Label();
            this.labelPremiumPipes = new System.Windows.Forms.Label();
            this.groupBoxShipOrSteamer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCreate)).BeginInit();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.panelDraw.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShipOrSteamer
            // 
            this.groupBoxShipOrSteamer.Controls.Add(this.CreateSteamerLabel);
            this.groupBoxShipOrSteamer.Controls.Add(this.CreateShipLabel);
            this.groupBoxShipOrSteamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxShipOrSteamer.Location = new System.Drawing.Point(12, 57);
            this.groupBoxShipOrSteamer.Name = "groupBoxShipOrSteamer";
            this.groupBoxShipOrSteamer.Size = new System.Drawing.Size(214, 166);
            this.groupBoxShipOrSteamer.TabIndex = 0;
            this.groupBoxShipOrSteamer.TabStop = false;
            this.groupBoxShipOrSteamer.Text = "Body type";
            // 
            // CreateSteamerLabel
            // 
            this.CreateSteamerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSteamerLabel.Location = new System.Drawing.Point(24, 108);
            this.CreateSteamerLabel.Name = "CreateSteamerLabel";
            this.CreateSteamerLabel.Size = new System.Drawing.Size(146, 46);
            this.CreateSteamerLabel.TabIndex = 1;
            this.CreateSteamerLabel.Text = "Steamer";
            this.CreateSteamerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateSteamerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateSteamerLabel_MouseDown);
            // 
            // CreateShipLabel
            // 
            this.CreateShipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateShipLabel.Location = new System.Drawing.Point(24, 45);
            this.CreateShipLabel.Name = "CreateShipLabel";
            this.CreateShipLabel.Size = new System.Drawing.Size(146, 46);
            this.CreateShipLabel.TabIndex = 0;
            this.CreateShipLabel.Text = "Ship";
            this.CreateShipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateShipLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateShipLabel_MouseDown);
            // 
            // pictureBoxForCreate
            // 
            this.pictureBoxForCreate.Location = new System.Drawing.Point(37, 0);
            this.pictureBoxForCreate.Name = "pictureBoxForCreate";
            this.pictureBoxForCreate.Size = new System.Drawing.Size(229, 227);
            this.pictureBoxForCreate.TabIndex = 1;
            this.pictureBoxForCreate.TabStop = false;
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBoxWindow);
            this.groupBoxParametrs.Controls.Add(this.checkBoxCabin);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParametrs.Controls.Add(this.label4);
            this.groupBoxParametrs.Controls.Add(this.label3);
            this.groupBoxParametrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxParametrs.Location = new System.Drawing.Point(178, 291);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(390, 165);
            this.groupBoxParametrs.TabIndex = 2;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Parametrs";
            // 
            // checkBoxWindow
            // 
            this.checkBoxWindow.AutoSize = true;
            this.checkBoxWindow.Location = new System.Drawing.Point(285, 87);
            this.checkBoxWindow.Name = "checkBoxWindow";
            this.checkBoxWindow.Size = new System.Drawing.Size(105, 29);
            this.checkBoxWindow.TabIndex = 5;
            this.checkBoxWindow.Text = "Window";
            this.checkBoxWindow.UseVisualStyleBackColor = true;
            // 
            // checkBoxCabin
            // 
            this.checkBoxCabin.AutoSize = true;
            this.checkBoxCabin.Location = new System.Drawing.Point(285, 42);
            this.checkBoxCabin.Name = "checkBoxCabin";
            this.checkBoxCabin.Size = new System.Drawing.Size(86, 29);
            this.checkBoxCabin.TabIndex = 4;
            this.checkBoxCabin.Text = "Cabin";
            this.checkBoxCabin.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(54, 111);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(91, 30);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(54, 54);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(92, 30);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Speed:";
            // 
            // panelDraw
            // 
            this.panelDraw.AllowDrop = true;
            this.panelDraw.Controls.Add(this.pictureBoxForCreate);
            this.panelDraw.Location = new System.Drawing.Point(243, 57);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(300, 227);
            this.panelDraw.TabIndex = 3;
            this.panelDraw.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panelDraw.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panelColor);
            this.groupBox1.Controls.Add(this.labelMColor);
            this.groupBox1.Controls.Add(this.labelDColor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(574, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(264, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 58);
            this.panel5.TabIndex = 4;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(181, 234);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(62, 58);
            this.panel8.TabIndex = 4;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(181, 157);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(62, 58);
            this.panel9.TabIndex = 4;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(104, 234);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(62, 58);
            this.panel10.TabIndex = 4;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(104, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(62, 58);
            this.panel7.TabIndex = 4;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(19, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 58);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(264, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 58);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Red;
            this.panelColor.Location = new System.Drawing.Point(19, 157);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(62, 58);
            this.panelColor.TabIndex = 3;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelMColor
            // 
            this.labelMColor.AllowDrop = true;
            this.labelMColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMColor.Location = new System.Drawing.Point(6, 55);
            this.labelMColor.Name = "labelMColor";
            this.labelMColor.Size = new System.Drawing.Size(146, 46);
            this.labelMColor.TabIndex = 2;
            this.labelMColor.Text = "Main Color";
            this.labelMColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMColor_DragDrop);
            this.labelMColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMColor_DragEnter);
            // 
            // labelDColor
            // 
            this.labelDColor.AllowDrop = true;
            this.labelDColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDColor.Location = new System.Drawing.Point(194, 55);
            this.labelDColor.Name = "labelDColor";
            this.labelDColor.Size = new System.Drawing.Size(146, 46);
            this.labelDColor.TabIndex = 1;
            this.labelDColor.Text = "DopColor";
            this.labelDColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDColor_DragDrop);
            this.labelDColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(825, 381);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 35);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClose.Location = new System.Drawing.Point(825, 427);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(89, 35);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPremiumPipes);
            this.groupBox2.Controls.Add(this.labelRectanglePipes);
            this.groupBox2.Controls.Add(this.labelSimplePipes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variants Pipes";
            // 
            // labelSimplePipes
            // 
            this.labelSimplePipes.AllowDrop = true;
            this.labelSimplePipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSimplePipes.Location = new System.Drawing.Point(6, 42);
            this.labelSimplePipes.Name = "labelSimplePipes";
            this.labelSimplePipes.Padding = new System.Windows.Forms.Padding(5);
            this.labelSimplePipes.Size = new System.Drawing.Size(143, 32);
            this.labelSimplePipes.TabIndex = 8;
            this.labelSimplePipes.Text = "Simple Pipes";
            this.labelSimplePipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSimplePipes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSimplePipes_MouseDown);
            // 
            // labelRectanglePipes
            // 
            this.labelRectanglePipes.AllowDrop = true;
            this.labelRectanglePipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRectanglePipes.Location = new System.Drawing.Point(6, 94);
            this.labelRectanglePipes.Name = "labelRectanglePipes";
            this.labelRectanglePipes.Padding = new System.Windows.Forms.Padding(5);
            this.labelRectanglePipes.Size = new System.Drawing.Size(143, 32);
            this.labelRectanglePipes.TabIndex = 9;
            this.labelRectanglePipes.Text = "Rectangle Pipes";
            this.labelRectanglePipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRectanglePipes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRectanglePipes_MouseDown);
            // 
            // labelPremiumPipes
            // 
            this.labelPremiumPipes.AllowDrop = true;
            this.labelPremiumPipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPremiumPipes.Location = new System.Drawing.Point(6, 141);
            this.labelPremiumPipes.Name = "labelPremiumPipes";
            this.labelPremiumPipes.Padding = new System.Windows.Forms.Padding(5);
            this.labelPremiumPipes.Size = new System.Drawing.Size(143, 32);
            this.labelPremiumPipes.TabIndex = 10;
            this.labelPremiumPipes.Text = "Premium Pipes";
            this.labelPremiumPipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPremiumPipes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPremiumPipes_MouseDown);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.groupBoxShipOrSteamer);
            this.Name = "FormConfig";
            this.Text = "Form1";
            this.groupBoxShipOrSteamer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCreate)).EndInit();
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.panelDraw.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShipOrSteamer;
        private System.Windows.Forms.Label CreateShipLabel;
        private System.Windows.Forms.PictureBox pictureBoxForCreate;
        private System.Windows.Forms.Label CreateSteamerLabel;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.CheckBox checkBoxWindow;
        private System.Windows.Forms.CheckBox checkBoxCabin;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelMColor;
        private System.Windows.Forms.Label labelDColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPremiumPipes;
        private System.Windows.Forms.Label labelRectanglePipes;
        private System.Windows.Forms.Label labelSimplePipes;
    }
}