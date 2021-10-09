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
    public partial class FormParking : Form
    {
        private readonly Parking<ShipBasic,IDop> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ShipBasic,IDop>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void ParkingShipButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog(); if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new ShipBasic(dialog.Color, 10, 2);
                if (parking + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void ParkingSteamerButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new ShipChild(dialog.Color, dialogDop.Color, true, true,2,2);
                    if (parking + ship)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = parking - Convert.ToInt32(maskedTextBox.Text);
                Random rand = new Random();

                if (ship != null)
                {
                    FormShip form = new FormShip();
                    ship.SetPosition(rand.Next(150), rand.Next(150), form.Size.Width, form.Size.Height);
                    form.SetShip(ship);
                    form.ShowDialog();


                }
                Draw();
            }
        }
    }

}