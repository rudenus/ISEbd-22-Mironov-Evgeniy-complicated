using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException() : base("Не найден автомобиль по месту ")
        { }
    }
}
