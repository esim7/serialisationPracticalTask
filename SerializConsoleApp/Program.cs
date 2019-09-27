using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;



namespace ClassLib
{
    class Program<T>
    {
        string path = @"C:\listSerial.txt";
        static void Main(string[] args)
        {
            List<PC> computers = new List<PC>
            {
                new PC
                {
                    PcModel = "WorkPC",
                    SerialNumber = "0x005656A",
                    Info = "Компьютер для офиса",
                    Price = 250000
                },
                new PC
                {
                    PcModel = "HomePC",
                    SerialNumber = "0x01056A",
                    Info = "Компьютер для дома",
                    Price = 312000
                },
                new PC
                {
                    PcModel = "GamePC",
                    SerialNumber = "0x01100B",
                    Info = "Игровой компьютер",
                    Price = 545000
                },
                new PC
                {
                    PcModel = "HardcoreGamePC",
                    SerialNumber = "0x01110C",
                    Info = "Компьютер для заядлых игроманов",
                    Price = 1255000
                }
            };

            string json = JsonConvert.SerializeObject(computers);

            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path: @"C:\listSerial.txt", FileMode.CreateNew)))
            {
                binaryWriter.Write(json);
            }

            //var result = JsonConvert.DeserializeObject<List<Book>>(json);
        }
    }
}
