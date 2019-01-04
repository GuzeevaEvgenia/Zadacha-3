using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    interface IVehicle
    {
        string Number { get; set; }
        int Year { get; set; }
        string Repair();
        string Fuel();
    }
}
