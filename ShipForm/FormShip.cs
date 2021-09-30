using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipForm
{
	public partial class FormShip : Form
	{
		Ship motorShip;
		Direction direction;
		public FormShip()
		{
			InitializeComponent();
			comboBoxNumber.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxNumber.SelectedIndex = 2;
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width,pictureBoxShip.Height);
			Graphics g = Graphics.FromImage(bmp);
			motorShip.DrawShip(g);
			pictureBoxShip.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			motorShip = new Ship();
			motorShip.classDop.Wheel = comboBoxNumber.SelectedIndex;
			motorShip.SetPosition(rand.Next(150), rand.Next(150), pictureBoxShip.Width, pictureBoxShip.Height);
			motorShip.Init(Color.LightGray, Color.LightBlue,Color.Gray, 6, 2);
			Draw();
		}
        private void buttonRight_Click(object sender, EventArgs e)
        {
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					motorShip.Drive(Direction.Up);
					break;
				case "buttonDown":
					motorShip.Drive(Direction.Down);
					break;
				case "buttonLeft":
					motorShip.Drive(Direction.Left);
					break;
				case "buttonRight":
					motorShip.Drive(Direction.Right);
					break;
			}
			Draw();
		}
    }
}
