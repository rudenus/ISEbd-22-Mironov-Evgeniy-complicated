using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
  

    class Steamer:Ship
    {
        private pipes dopEnum;
        private bool cabin;
        private bool windows;
        
        public Color DopColor { private set; get; }
        public int Wheel { set => dopEnum = (pipes)value; }
        private IDop idop = new RectanglePipes(2);
        public Steamer(int wheel,Color DopCol,bool cabin,bool window)
            :base(Color.LightGray, 6, 2)
        {
            this.cabin = cabin;
            this.windows = window;
            Wheel = wheel;
            DopColor = DopCol;
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
            idop.DrawDop(g, StartPosition, Color.LightGray);
        }
    }
}
