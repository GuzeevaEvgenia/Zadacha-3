using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Tram : PublicTransport
    {
        public string Comment { get; set; }

        private int cost;
        public int Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    throw new Exception("Введите корректное число.");
                else
                    cost = value;
            }
        }

        public Tram(string number, int year, int cost, int capacity)
        {
            Number = number;
            Year = year;
            Cost = cost;
            Capacity = capacity;
        }

        public string AddComment(string cmt)
        {
            if (cmt == "")
                throw new Exception("Напишите комментарий.");
            else
                Comment += cmt;
            return Comment;
        }

        public string ShowComment()
        {
            return Comment;
        }
        public override string Repair()
        {
            return "Вы починили транспорт с номером " + Number;
        }
        public override string Fuel()
        {
            return "Вы заправили транспорт с номером " + Number;
        }
        public override string ShowInfo()
        {
            return "Транспорт с номером " + Number + " " + Year + " года выпуска.";
        }
        public override string ShowCapacity()
        {
            return "Транспорт с номером " + Number + " имеет вместимость " + Capacity + " человек.";
        }
    }
}

