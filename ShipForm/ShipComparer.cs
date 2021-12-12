using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class ShipComparer : IComparer<Vessel>
    {
        public int Compare(Vessel x, Vessel y)
        {
            if (x is ShipBasic && y is ShipBasic)
            {
                return ComparerShip(x as ShipBasic, y as ShipBasic);
            }
            if (x is ShipChild && y is ShipChild)
            {
                return ComparerSteamer(x as ShipChild, y as ShipChild);
            }
            if (x is ShipChild && y is ShipBasic)
            {
                return -1;
            }
            if (x is ShipBasic && y is ShipChild)
            {
                return 1;
            }
            return 0;
        }
        private int ComparerShip(ShipBasic x, ShipBasic y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerSteamer(ShipChild x, ShipChild y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.cabin != y.cabin)
            {
                return x.cabin.CompareTo(y.cabin);
            }
            if (x.windows != y.windows)
            {
                return x.windows.CompareTo(y.windows);
            }
            if (x.IDopName != y.IDopName)
            {
                return x.IDopName.CompareTo(y.IDopName);
            }
            return 0;
        }
    }
}
