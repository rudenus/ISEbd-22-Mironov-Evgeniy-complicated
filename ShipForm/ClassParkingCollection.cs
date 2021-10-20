using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<ShipBasic, SimplePipes>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<ShipBasic, SimplePipes>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<ShipBasic, SimplePipes>(pictureWidth, pictureHeight));
            }
        }
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<ShipBasic, SimplePipes> this[string ind]
        {
            get
            {
                return parkingStages[ind];
            }
        }
        public ShipBasic this[string ind,int ind2]
        {
            get
            {
                return parkingStages[ind][ind2];
            }
        }
    }
}
