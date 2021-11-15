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
        private readonly ParkingCollection parkingCol;
        private Stack<ShipBasic> stack;
        public FormParking()
        {
            InitializeComponent();
            parkingCol = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            stack = new Stack<ShipBasic>();
            Draw();
        }
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCol.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCol.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
           listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
           listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCol[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void ParkingShipButton_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormConfig();
            formCarConfig.AddEvent(AddShip);
            formCarConfig.Show();
        }
        private void AddShip(Vessel car)
        {
            if (car != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCol[listBoxParkings.SelectedItem.ToString()]) + (car as ShipBasic))
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var ship = parkingCol[listBoxParkings.SelectedItem.ToString()] -
                    Convert.ToInt32(maskedTextBox.Text);
                stack.Push(ship);
            }
            Draw();
        }

        private void AddParkingButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewParking.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCol.AddParking(textBoxNewParking.Text);
            ReloadLevels();

        }

        private void RemoveParkingButton_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParkings.SelectedItem.ToString()}?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //parkingCol.DelParking(textBoxNewParking.Text);
                    parkingCol.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
            Draw();
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void putInStackButton_Click(object sender, EventArgs e)
        {
            if (stack.Count>0)
            {
                var ship = stack.Pop();
                if (ship != null)
                {
                    FormShip form = new FormShip();
                    Random rand = new Random();
                    ship.SetPosition(rand.Next(150), rand.Next(150), form.Size.Width, form.Size.Height);
                    form.SetShip(ship);
                    form.ShowDialog();
                }
            }
            Draw();
        }
    }

}