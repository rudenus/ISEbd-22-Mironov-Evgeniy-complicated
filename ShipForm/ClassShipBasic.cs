using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
	public class ShipBasic: Vessel, IEquatable<ShipBasic>,IComparable
	{
		private readonly int carWidth = 170;
		private readonly int carHeight = 195;
		protected readonly char separator = ';';
		public ShipBasic(Color mainColor,  int speed, int weight)
        {
			MaxSpeed = speed;
			MainColor = mainColor;
			Weight = weight;
		}
		public ShipBasic(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
			}
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
		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.ToArgb()}";
		}
		public bool Equals(ShipBasic other)
		{
			if (other == null)
			{
				return false;
			}
			if (GetType().Name != other.GetType().Name)
			{
				return false;
			}
			if (MaxSpeed != other.MaxSpeed)
			{
				return false;
			}
			if (Weight != other.Weight)
			{
				return false;
			}
			if (MainColor != other.MainColor)
			{
				return false;
			}
			return true;
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is ShipBasic carObj))
			{
				return false;
			}
			else
			{
				return Equals(carObj);
			}
		}

		public int CompareTo(Object obj)
		{
			if (obj == null)
			{
				return -1;
			}
			if (!(obj is ShipBasic carObj))
			{
				return -1;
			}
			else
			{
				return CompareTo(carObj);
			}
		}
		public int CompareTo(ShipBasic obj)
        {
			if (MaxSpeed != obj.MaxSpeed)
			{
				return MaxSpeed.CompareTo(obj.MaxSpeed);
			}
			if (Weight != obj.Weight)
			{
				return Weight.CompareTo(obj.Weight);
			}
			if (MainColor != obj.MainColor)
			{
				return MainColor.Name.CompareTo(obj.MainColor.Name);
			}
			return 0;
		}
		private void printProp()
        {
			foreach(var str in this.ToString().Split(separator))
            {
				Console.WriteLine(str);
            }
        }
    }
}
