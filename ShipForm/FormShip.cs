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
		ITransport iship;
		Direction direction;
		public FormShip()
		{
			InitializeComponent();
			comboBoxNumber.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxNumber.SelectedIndex = 2;
			comboBoxType.SelectedIndex = 0;
		}
		public void SetShip(ITransport iship)
		{
			this.iship = iship;
			Draw();

		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width,pictureBoxShip.Height);
			Graphics g = Graphics.FromImage(bmp);
			iship.DrawTransport(g);
			pictureBoxShip.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			iship = new ShipChild(Color.LightGray, Color.LightBlue, true, true,comboBoxType.SelectedIndex,comboBoxNumber.SelectedIndex);

			//motorShip.classDop.Wheel = comboBoxNumber.SelectedIndex;
			iship.SetPosition(rand.Next(150), rand.Next(150), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}
        private void buttonRight_Click(object sender, EventArgs e)
        {
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					iship.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					iship.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					iship.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					iship.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
    }
}
