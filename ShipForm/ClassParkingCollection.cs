using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<ShipBasic, SimplePipes>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly char separator = ':';
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
        public bool SaveDataAll(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"ParkingCollection{Environment.NewLine}");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    fs.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
                    ITransport ship = null;
                    for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (ship.GetType().Name == "ShipBasic")
                            {
                                fs.Write($"ShipBasic{separator}");
                            }
                            if (ship.GetType().Name == "ShipChild")
                            {
                                fs.Write($"ShipChild{separator}");
                            }
                            //Записываемые параметры
                            fs.Write(ship + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }
        public bool SaveData(string filename, string parkingName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (!parkingStages.ContainsKey(parkingName))
            {
                return false;
            }
                using (StreamWriter fs = new StreamWriter(filename))
                {
                    fs.Write($"ParkingOnly{Environment.NewLine}");
                    //Начинаем парковку
                    fs.Write($"Parking{separator}{parkingName}{Environment.NewLine}");
                    ITransport ship = null;
                    for (int i = 0; (ship = parkingStages[parkingName].GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (ship.GetType().Name == "ShipBasic")
                            {
                                fs.Write($"ShipBasic{separator}");
                            }
                            if (ship.GetType().Name == "ShipChild")
                            {
                                fs.Write($"ShipChild{separator}");
                            }
                            //Записываемые параметры
                            fs.Write(ship + Environment.NewLine);
                        }
                    }
                }
           
            return true;
        }
        public bool LoadDataAll(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (StreamReader fs = new StreamReader(filename))
            {

                bufferTextFromFile = fs.ReadLine();

                if (bufferTextFromFile.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                ShipBasic car = null;
                string key = string.Empty;
                while (!fs.EndOfStream)
                {

                    //идем по считанным записям
                    bufferTextFromFile = fs.ReadLine();
                    if (bufferTextFromFile.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = bufferTextFromFile.Split(separator)[1];

                        parkingStages.Add(key, new Parking<ShipBasic, SimplePipes>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(bufferTextFromFile))
                    {
                        continue;
                    }
                    if (bufferTextFromFile.Split(separator)[0] == "ShipBasic")
                    {
                        car = new ShipBasic(bufferTextFromFile.Split(separator)[1]);
                    }
                    else if (bufferTextFromFile.Split(separator)[0] == "ShipChild")
                    {
                        car = new ShipChild(bufferTextFromFile.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + car;
                    if (!result)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (StreamReader fs = new StreamReader(filename))
            {

                bufferTextFromFile = fs.ReadLine();

                if (!bufferTextFromFile.Contains("ParkingOnly"))
                {
                    return false;
                }
                ShipBasic car = null;
                string key = string.Empty;
                while (!fs.EndOfStream)
                {

                    //идем по считанным записям
                    bufferTextFromFile = fs.ReadLine();
                    if (bufferTextFromFile.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = bufferTextFromFile.Split(separator)[1];
                        if (!parkingStages.ContainsKey(key))
                        {
                            parkingStages.Add(key, new Parking<ShipBasic, SimplePipes>(pictureWidth, pictureHeight));
                        }
                        else
                        {
                            parkingStages[key].Clear();
                        }
                        continue;
                    }
                    if (string.IsNullOrEmpty(bufferTextFromFile))
                    {
                        continue;
                    }
                    if (bufferTextFromFile.Split(separator)[0] == "ShipBasic")
                    {
                        car = new ShipBasic(bufferTextFromFile.Split(separator)[1]);
                    }
                    else if (bufferTextFromFile.Split(separator)[0] == "ShipChild")
                    {
                        car = new ShipChild(bufferTextFromFile.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + car;
                    if (!result)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

    }
}
