using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3 
{
    class PublicTransport : IVehicle
    {
        private string number;
        public string Number
        {
            get { return number; }
            set
            {
                if (value == "")
                    throw new Exception("Введите корректный номер автомобиля.");
                else
                    number = value;
            }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new Exception("Введите корректное число.");
                else
                    year = value;
            }
        }

        public int Capacity { get; set; }

        public string Repair()
        {
            return "Вы починили транспорт с номером " + Number;
        }

        public string Fuel()
        {
            return "Вы заправили транспорт с номером " + Number;
        }

        public string ShowInfo()
        {
            return "Транспорт с номером " + Number + " " + Year + " года выпуска.";
        }

        public string ShowCapacity()
        {
            return "Транспорт с номером " + Number + " имеет вместимость " + Capacity + " человек.";
        }
    }
}
