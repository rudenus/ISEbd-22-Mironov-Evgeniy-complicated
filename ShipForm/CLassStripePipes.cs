using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class CLassStripePipes : IDop
    {
        private pipes dopEnum;
        Color dopColor2;
        public int Wheel { set => dopEnum = (pipes)value; }
        public CLassStripePipes(int x,Color dopColor2)
        {
            Wheel = x;
            this.dopColor2 = dopColor2;
        }

        public void DrawDop(Graphics g, Point StartPosition, Color color)
        {
            Brush brush = new SolidBrush(color);
            Brush brushDop = new SolidBrush(Color.DarkGray);
            Pen pen = new Pen(Color.Black);
            Brush brushDop2 = new SolidBrush(dopColor2);
            g.DrawRectangle(pen, StartPosition.X + 45, StartPosition.Y + 40, 10, 30);
            g.DrawRectangle(pen, StartPosition.X + 30, StartPosition.Y + 40, 10, 30);
            g.FillRectangle(brush, StartPosition.X + 45, StartPosition.Y + 40, 10, 30);
            g.FillRectangle(brush, StartPosition.X + 30, StartPosition.Y + 40, 10, 30);
            g.DrawRectangle(pen, StartPosition.X + 29, StartPosition.Y + 32, 12, 8);
            g.FillRectangle(brushDop, StartPosition.X + 29, StartPosition.Y + 32, 12, 8);
            g.DrawRectangle(pen, StartPosition.X + 44, StartPosition.Y + 32, 12, 8);
            g.FillRectangle(brushDop, StartPosition.X + 44, StartPosition.Y + 32, 12, 8);
            g.DrawRectangle(pen, StartPosition.X + 30, StartPosition.Y + 63, 10, 7);
            g.FillRectangle(brushDop2, StartPosition.X + 30, StartPosition.Y + 63, 10, 7);
            g.DrawRectangle(pen, StartPosition.X + 30, StartPosition.Y + 48, 10, 7);
            g.FillRectangle(brushDop2, StartPosition.X + 30, StartPosition.Y + 48, 10, 7);
            g.DrawRectangle(pen, StartPosition.X + 45, StartPosition.Y + 63, 10, 7);
            g.FillRectangle(brushDop2, StartPosition.X + 45, StartPosition.Y + 63, 10, 7);
            g.DrawRectangle(pen, StartPosition.X + 45, StartPosition.Y + 48, 10, 7);
            g.FillRectangle(brushDop2, StartPosition.X + 45, StartPosition.Y + 48, 10, 7);
            if (dopEnum == pipes.four || dopEnum == pipes.six)
            {
                g.DrawRectangle(pen, StartPosition.X + 60, StartPosition.Y + 40, 10, 30);
                g.DrawRectangle(pen, StartPosition.X + 75, StartPosition.Y + 40, 10, 30);
                g.FillRectangle(brush, StartPosition.X + 60, StartPosition.Y + 40, 10, 30);
                g.FillRectangle(brush, StartPosition.X + 75, StartPosition.Y + 40, 10, 30);
                g.DrawRectangle(pen, StartPosition.X + 59, StartPosition.Y + 32, 12, 8);
                g.FillRectangle(brushDop, StartPosition.X + 59, StartPosition.Y + 32, 12, 8);
                g.DrawRectangle(pen, StartPosition.X + 74, StartPosition.Y + 32, 12, 8);
                g.FillRectangle(brushDop, StartPosition.X + 74, StartPosition.Y + 32, 12, 8);
                g.DrawRectangle(pen, StartPosition.X + 60, StartPosition.Y + 63, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 60, StartPosition.Y + 63, 10, 7);
                g.DrawRectangle(pen, StartPosition.X + 60, StartPosition.Y + 48, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 60, StartPosition.Y + 48, 10, 7);
                g.DrawRectangle(pen, StartPosition.X + 75, StartPosition.Y + 63, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 75, StartPosition.Y + 63, 10, 7);
                g.DrawRectangle(pen, StartPosition.X + 75, StartPosition.Y + 48, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 75, StartPosition.Y + 48, 10, 7);
            }
            if (dopEnum == pipes.six)
            {
                g.DrawRectangle(pen, StartPosition.X + 105, StartPosition.Y + 40, 10, 30);
                g.DrawRectangle(pen, StartPosition.X + 90, StartPosition.Y + 40, 10, 30);
                g.FillRectangle(brush, StartPosition.X + 105, StartPosition.Y + 40, 10, 30);
                g.FillRectangle(brush, StartPosition.X + 90, StartPosition.Y + 40, 10, 30);
                g.DrawRectangle(pen, StartPosition.X + 89, StartPosition.Y + 32, 12, 8);
                g.FillRectangle(brushDop, StartPosition.X + 89, StartPosition.Y + 32, 12, 8);
                g.DrawRectangle(pen, StartPosition.X + 104, StartPosition.Y + 32, 12, 8);
                g.FillRectangle(brushDop, StartPosition.X + 104, StartPosition.Y + 32, 12, 8);
                g.DrawRectangle(pen, StartPosition.X + 90, StartPosition.Y + 63, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 90, StartPosition.Y + 63, 10, 7);
                g.DrawRectangle(pen, StartPosition.X + 90, StartPosition.Y + 48, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 90, StartPosition.Y + 48, 10, 7);
                g.DrawRectangle(pen, StartPosition.X + 105, StartPosition.Y + 63, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 105, StartPosition.Y + 63, 10, 7);
                g.DrawRectangle(pen, StartPosition.X + 105, StartPosition.Y + 48, 10, 7);
                g.FillRectangle(brushDop2, StartPosition.X + 105, StartPosition.Y + 48, 10, 7);
            }
        }
    }
}
