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
    public partial class FormConfig : Form
    {
        Vessel ship = null;
        public Action<Vessel> eventAddShip;
        public FormConfig()
        {
            InitializeComponent();
            buttonClose.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawShip()
        {
            if (ship != null)
            {

                Bitmap bmp = new Bitmap(pictureBoxForCreate.Width, pictureBoxForCreate.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxForCreate.Width, pictureBoxForCreate.Height);
                ship.DrawTransport(gr);
                pictureBoxForCreate.Image = bmp;
            }
        }

        public void AddEvent(Action<Vessel> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vessel>(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        private void CreateShipLabel_MouseDown(object sender, MouseEventArgs e)
        {
            CreateShipLabel.DoDragDrop(CreateShipLabel.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void CreateSteamerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            CreateSteamerLabel.DoDragDrop(CreateSteamerLabel.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Ship":
                    ship = new ShipBasic(Color.White,(int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value) ;
                    break;
                case "Steamer":
                    ship = new ShipChild( Color.White, Color.Black, checkBoxCabin.Checked, checkBoxWindow.Checked,
                        (int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value,2,2);
                    break;
            }
            else if (ship is ShipChild)
            {
                (ship as ShipChild).SetIDop((IDop)e.Data.GetData(e.Data.GetFormats()[0]));
            }
            DrawShip();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || 
                typeof(IDop).IsAssignableFrom(Type.GetType(e.Data.GetFormats()[0])))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Panel temp = sender as Panel;
            CreateSteamerLabel.DoDragDrop(temp.BackColor, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelMColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                var temp = sender as Panel;
                if (ship is ShipChild)
                {
                    (ship as ShipChild).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();

                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();

        }

        private void labelSimplePipes_MouseDown(object sender, MouseEventArgs e)
        {
            IDop temp = new SimplePipes(2);
            CreateSteamerLabel.DoDragDrop(temp, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelRectanglePipes_MouseDown(object sender, MouseEventArgs e)
        {
            IDop temp = new RectanglePipes(2);
            CreateSteamerLabel.DoDragDrop(temp, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelPremiumPipes_MouseDown(object sender, MouseEventArgs e)
        {
            IDop temp = new ClassStripePipes(2);
            CreateSteamerLabel.DoDragDrop(temp, DragDropEffects.Move |
DragDropEffects.Copy);
        }

    }
}