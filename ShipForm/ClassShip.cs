using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
	class Ship:AbstractClass
	{
		private readonly int carWidth = 160;
		private readonly int carHeight = 155;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public  Ship(Color mainColor,  int speed, int weight)
        {
			MaxSpeed = speed;
			MainColor = mainColor;
			Weight = weight;
		}
        public override void DrawTransport(Graphics g)
        {
			Pen pen = Pens.Black;
			Brush brush = new SolidBrush(MainColor);
			g.DrawLine(pen, StartPosition.X, StartPosition.Y + 100, StartPosition.X + 150, StartPosition.Y + 100);
			g.DrawLine(pen, StartPosition.X + 30, StartPosition.Y + 150, StartPosition.X + 120, StartPosition.Y + 150);
			g.DrawLine(pen, StartPosition.X, StartPosition.Y + 100, StartPosition.X + 30, StartPosition.Y + 150);
			g.DrawLine(pen, StartPosition.X + 150, StartPosition.Y + 100, StartPosition.X + 120, StartPosition.Y + 150);
			g.DrawRectangle(pen, StartPosition.X + 19, StartPosition.Y + 69, 122, 30);
			g.FillRectangle(brush, StartPosition.X + 20, StartPosition.Y + 70, 120, 30);
            g.DrawLine(pen, StartPosition.X + 20, StartPosition.Y + 105, StartPosition.X + 20, StartPosition.Y + 120);
            g.DrawLine(pen, StartPosition.X + 15, StartPosition.Y + 110, StartPosition.X + 25, StartPosition.Y + 110);
            g.DrawLine(pen, StartPosition.X + 17, StartPosition.Y + 120, StartPosition.X + 23, StartPosition.Y + 120);
            g.DrawLine(pen, StartPosition.X + 120, StartPosition.Y + 102, StartPosition.X + 120, StartPosition.Y + 145);
            g.DrawLine(pen, StartPosition.X + 110, StartPosition.Y + 102, StartPosition.X + 110, StartPosition.Y + 145);
            g.DrawLine(pen, StartPosition.X + 110, StartPosition.Y + 110, StartPosition.X + 120, StartPosition.Y + 110);
            g.DrawLine(pen, StartPosition.X + 110, StartPosition.Y + 120, StartPosition.X + 120, StartPosition.Y + 120);
            g.DrawLine(pen, StartPosition.X + 110, StartPosition.Y + 130, StartPosition.X + 120, StartPosition.Y + 130);
            g.DrawLine(pen, StartPosition.X + 110, StartPosition.Y + 140, StartPosition.X + 120, StartPosition.Y + 140);
		}

        public override void MoveTransport(Direction direction)
        {
			int step = (int)Math.Round(MaxSpeed * 10 / Weight);
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (StartPosition.X + step < pictureWidth - carWidth)
					{
						StartPosition.X += step;
					}
					break;
				//влево
				case Direction.Left:
					if (StartPosition.X - step >= 0)
					{
						StartPosition.X -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (StartPosition.Y - step >= 0)
					{
						StartPosition.Y -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (StartPosition.Y + step < pictureHeight - carHeight)
					{
						StartPosition.Y += step;
					}
					break;
			}
		}
    }
}
