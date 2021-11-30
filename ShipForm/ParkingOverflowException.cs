using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
