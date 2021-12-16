using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    public abstract class Vessel:ITransport
    {
        protected Point StartPosition;
        protected int pictureWidth;
        protected int pictureHeight;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int wi, int he)
        {
            StartPosition.X = x;
            StartPosition.Y = y;
            pictureHeight = he;
            pictureWidth = wi;

        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
    }
}
