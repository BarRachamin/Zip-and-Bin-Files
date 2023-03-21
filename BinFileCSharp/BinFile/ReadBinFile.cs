using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinFile
{
    public class ReadBinFile
    {

        //the contents of the car

        public struct Car
        {
            public int Id;
            public string Name;
            public string Description;
            public float km;
        }

        //the file name
        string fileName = "binFile.bin";

        public void SetCar()
        {
            Car[] car=new Car[5];



            for (int i = 0; i <car.Length; i++)
            {

                car[i].Id = i;
                car[i].Name = $"Car{i}";
                car[i].Description = $"Amazing car{i}";
                car[i].km = i * 1000;

            }
            WriteToFile(car);
            ReadFromFile();
        }
        public void WriteToFile(Car[] car)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            //another way BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                for (int i = 0; i < car.Length; i++)
                {
                    writer.Write(car[i].Id);
                    writer.Write(car[i].Name);
                    writer.Write(car[i].Description);
                    writer.Write(car[i].km);
                }
            }
        }
        public void ReadFromFile()
        {
            Car[] car = new Car[5];
            using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(fileName)))
            {
                for (int i = 0; i < car.Length; i++)
                {
                    car[i].Id = binaryReader.ReadInt32();
                    Console.WriteLine(car[i].Id);
                    car[i].Name = binaryReader.ReadString();
                    Console.WriteLine(car[i].Name);
                    car[i].Description = binaryReader.ReadString();
                    Console.WriteLine(car[i].Description);
                    car[i].km = binaryReader.ReadSingle();
                    Console.WriteLine(car[i].km);
                }
            }
        }
    }
}
