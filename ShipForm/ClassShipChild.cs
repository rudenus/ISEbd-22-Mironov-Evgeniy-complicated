using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
  

    class ShipChild: ShipBasic
    {
        private pipes dopEnum;
        private bool cabin;
        private bool windows;

        public Color DopColor { private set; get; }
        public int Wheel { set => dopEnum = (pipes)value; }
        private IDop idop;
        public ShipChild(Color MainColor, Color DopCol, bool cabin,bool window,int speed, int weight, int shipState, int numPipes)
            :base(MainColor, speed, weight)
        {
            this.cabin = cabin;
            this.windows = window;
            Wheel = numPipes;
            DopColor = DopCol;
            switch (shipState)
            {
                case 0:
                        idop = new SimplePipes(numPipes);
                        break;
                case 1:
                        idop = new RectanglePipes(numPipes);
                        break;
                case 2:
                        idop = new ClassStripePipes(numPipes);
                        break;
            }
        }
        public ShipChild(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
                DopColor = Color.FromArgb(Convert.ToInt32(strs[3]));
                cabin = Convert.ToBoolean(strs[4]);
                windows = Convert.ToBoolean(strs[5]);
                if(strs[6] == "RectanglePipes")
                {
                    idop = new RectanglePipes(2);
                }
                else if(strs[6] == "SimplePipes")
                {
                    idop = new SimplePipes(2);
                }
                else if(strs[6]== "ClassStripePipes")
                {
                    idop = new ClassStripePipes(2);
                }
            }
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = Pens.Black;
            Brush brushDop = new SolidBrush(DopColor);
            if (windows)
            {
                g.DrawEllipse(pen, StartPosition.X + 30, StartPosition.Y + 120, 10, 10);
                g.DrawEllipse(pen, StartPosition.X + 45, StartPosition.Y + 120, 10, 10);
                g.DrawEllipse(pen, StartPosition.X + 60, StartPosition.Y + 120, 10, 10);
                g.DrawEllipse(pen, StartPosition.X + 75, StartPosition.Y + 120, 10, 10);
                g.DrawEllipse(pen, StartPosition.X + 90, StartPosition.Y + 120, 10, 10);
                g.FillEllipse(brushDop, StartPosition.X + 90, StartPosition.Y + 120, 10, 10);
                g.FillEllipse(brushDop, StartPosition.X + 75, StartPosition.Y + 120, 10, 10);
                g.FillEllipse(brushDop, StartPosition.X + 60, StartPosition.Y + 120, 10, 10);
                g.FillEllipse(brushDop, StartPosition.X + 45, StartPosition.Y + 120, 10, 10);
                g.FillEllipse(brushDop, StartPosition.X + 30, StartPosition.Y + 120, 10, 10);
            }
            if (cabin)
            {
                g.DrawRectangle(pen, StartPosition.X + 5, StartPosition.Y + 85, 14, 15);
                g.DrawRectangle(pen, StartPosition.X + 7, StartPosition.Y + 88, 6, 8);
                g.FillRectangle(brushDop, StartPosition.X + 8, StartPosition.Y + 89, 5, 7);
                g.DrawLine(pen, StartPosition.X + 10, StartPosition.Y + 88, StartPosition.X + 10, StartPosition.Y + 96);
                g.DrawLine(pen, StartPosition.X + 7, StartPosition.Y + 92, StartPosition.X + 13, StartPosition.Y + 92);
            }
            idop.DrawDop(g, StartPosition, DopColor);
        }
        public void SetIDop(IDop idop)
        {
            this.idop = idop;
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.ToArgb()}{separator}{cabin}{separator}{windows}{separator}{idop.GetType().Name}";
        }
    }
}
