using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinFileCSharp
{
    public class Class1
    {
        public struct Car
        {
            public int Id;
            public string Name;
            public string Description;
            public float km;
        }

        string fileName = @"C:\\Users\\shaha\\source\\repos\\FirstClassCS\\FirstClassCS\\binFileCW20.3\\binFileCW.bin";

        public void SetCar()
        {
            Car car;

            for (int i = 0; i < 5; i++)
            {
                car = new Car();
                car.Id = i;
                car.Name = $"Car{i}";
                car.Description = $"Amazing car{i}";
                car.km = i * 1000;
                WriteToFile(car);
                ReadFromFile();
            }
        }
        public void WriteToFile(Car car)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            //another way BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                writer.Write(car.Id);
                writer.Write(car.Name);
                writer.Write(car.Description);
                writer.Write(car.km);
            }
        }
        public void ReadFromFile()
        {
            Car car = new Car();
            using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(fileName)))
            {
                car.Id = binaryReader.ReadInt32();
                Console.WriteLine(car.Id);
                car.Name = binaryReader.ReadString();
                Console.WriteLine(car.Name);
                car.Description = binaryReader.ReadString();
                Console.WriteLine(car.Description);
                car.km = binaryReader.ReadSingle();
                Console.WriteLine(car.km);
            }
        }
    }
}
