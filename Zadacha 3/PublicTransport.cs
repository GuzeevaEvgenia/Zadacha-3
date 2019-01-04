using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3 
{
    public abstract class PublicTransport : IVehicle
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

        protected int Capacity { get; set; }

        public abstract string Repair();

        public abstract string Fuel();

        public abstract string ShowInfo();

        public abstract string ShowCapacity();
    }
}
