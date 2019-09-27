using System;
using System.Collections.Generic;

namespace ClassLib
{
    public class PC
    {
        //поля(марка, серийный номер и т.д.),  
        //свойства(к каждому полю),  
        //конструкторы(по умолчанию, с параметрами),  
        //методы, моделирующие функционирование ПЭВМ

        public string PcModel { get; set; }
        public string SerialNumber { get; set; }
        public string Info { get; set; }
        public double Price { get; set; }

        public PC()
        {
            PcModel = "GamePC"; SerialNumber = "0x000"; Info = "Intel Core i9 4000Mhz"; Price = 1000;
        }

        public PC(string pcModel, string serialNumber, string info, double price)
        {
            PcModel = pcModel; SerialNumber = serialNumber; Info = info; Price = price;
        }

        public double GiveMeSumTwoNumbers(double leftNumber, double rightNumber)
        {
            double sum = leftNumber + rightNumber;
            return sum;
        }
        public void PCstart()
        {
            Console.WriteLine("Hello BOSS!!!");
        }
        public void PCoff()
        {
            Console.WriteLine("GoodBye BOSS!!!");
        }
        public void PCsleep()
        {
            Console.WriteLine(this.PcModel + " Going to sleep");
        }
    }
}
