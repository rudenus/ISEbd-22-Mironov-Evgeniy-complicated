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
        readonly Dictionary<string, Parking<Vessel, SimplePipes>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly char separator = ':';
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vessel, SimplePipes>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<Vessel, SimplePipes>(pictureWidth, pictureHeight));
            }
        }
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<Vessel, SimplePipes> this[string ind]
        {
            get
            {
                return parkingStages[ind];
            }
        }
        public Vessel this[string ind,int ind2]
        {
            get
            {
                return parkingStages[ind][ind2];
            }
        }
        public void SaveDataAll(string filename)
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
                    foreach (ITransport ship in level.Value)
                    {
                        //Записываем тип мшаины
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
        public void SaveData(string filename, string parkingName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"ParkingOnly{Environment.NewLine}");
                    //Начинаем парковку
                    fs.Write($"Parking{separator}{parkingName}{Environment.NewLine}");
                    foreach (ITransport ship in parkingStages[parkingName])
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
        public void LoadDataAll(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
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
                    throw new FileLoadException("Неверный формат файла");
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
                        parkingStages.Add(key, new Parking<Vessel,SimplePipes>(pictureWidth, pictureHeight));
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
                        throw new FileLoadException("Не удалось загрузить автомобиль на парковку");
                    }
                }

            }
        }

    public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (StreamReader fs = new StreamReader(filename))
            {

                bufferTextFromFile = fs.ReadLine();

                if (!bufferTextFromFile.Contains("ParkingOnly"))
                {
                    throw new FileLoadException("Неверный формат файла");
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
                            parkingStages.Add(key, new Parking<Vessel, SimplePipes>(pictureWidth, pictureHeight));
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
                        throw new FileLoadException("Не удалось загрузить автомобиль на парковку");
                    }
                }

            }
        }

    }
}
