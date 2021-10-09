using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    public class Parking<T,W> 
        where T : class, ITransport
        where W : IDop
    {
        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 160;
        public int index = -1;
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        public static bool operator +(Parking<T,W> p, T ship)
        {
            int changeHeight = 10;
            int width = p.pictureWidth / p._placeSizeWidth;

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = ship;
                    p._places[i].SetPosition(i % width * p._placeSizeWidth + changeHeight,
                    i / width * p._placeSizeHeight + changeHeight, p.pictureWidth,
                    p.pictureHeight);
                    return true;
                }
            }
            return false;
        }
        public static T operator -(Parking<T,W> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T vehicle = p._places[index];
                p._places[index] = null;
                return vehicle;
            }
            return null;
        }
        public static bool operator >(Parking<T, W> p, Parking<T, W> p2)
        {
            int x = -1;
            int y = -1;

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i) && x!=-1)
                {
                    x = i;
                }
                if (p2.CheckFreePlace(i) && y != -1)
                {
                    y = i;
                }
            }
            if (x > y) return true;
            return false;
        }
        public static bool operator <(Parking<T, W> p, Parking<T, W> p2)
        {
            int x = -1;
            int y = -1;

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i) && x != -1)
                {
                    x = i;
                }
                if (p2.CheckFreePlace(i) && y != -1)
                {
                    y = i;
                }
            }
            if (y > x) return true;
            return false;
        }
        private bool CheckFreePlace(int indexPlace)
        {
            return _places[indexPlace] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места            
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
