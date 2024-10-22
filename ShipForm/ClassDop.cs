﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class ClassDop
    {
        private pipes dopEnum;
        public int Wheel;
        public void drawDop(Graphics g, Point StartPosition, Color color)
        {
            dopEnum = (pipes)Wheel;
            Brush brush = new SolidBrush(color);
            g.DrawRectangle(Pens.Black, StartPosition.X + 45, StartPosition.Y + 30, 10, 40);
            g.DrawRectangle(Pens.Black, StartPosition.X + 30, StartPosition.Y + 30, 10, 40);
            g.FillRectangle(brush, StartPosition.X + 45, StartPosition.Y + 30, 10, 40);
            g.FillRectangle(brush, StartPosition.X + 30, StartPosition.Y + 30, 10, 40);
            if (dopEnum == pipes.four|| dopEnum == pipes.six)
            {
                g.DrawRectangle(Pens.Black, StartPosition.X + 60, StartPosition.Y + 30, 10, 40);
                g.DrawRectangle(Pens.Black, StartPosition.X + 75, StartPosition.Y + 30, 10, 40);
                g.FillRectangle(brush, StartPosition.X + 60, StartPosition.Y + 30, 10, 40);
                g.FillRectangle(brush, StartPosition.X + 75, StartPosition.Y + 30, 10, 40);
            }
            if(dopEnum == pipes.six)
            {
                g.DrawRectangle(Pens.Black, StartPosition.X + 105, StartPosition.Y + 30, 10, 40);
                g.DrawRectangle(Pens.Black, StartPosition.X + 90, StartPosition.Y + 30, 10, 40);
                g.FillRectangle(brush, StartPosition.X + 105, StartPosition.Y + 30, 10, 40);
                g.FillRectangle(brush, StartPosition.X + 90, StartPosition.Y + 30, 10, 40);
            }
        }
    }
}
