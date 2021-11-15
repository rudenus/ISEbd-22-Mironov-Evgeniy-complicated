using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    public interface IDop
    {
        int Wheel { set; }
        void DrawDop(Graphics g, Point StartPosition, Color color);
    }
}
