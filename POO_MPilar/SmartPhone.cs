using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class SmartPhone
    {
        public int Ram;
        public string Manufacturer;
        public int Cores;

        public SmartPhone() { }

        public SmartPhone(int ram, string manufacturer, int cores)
        {
            Ram = ram;
            Manufacturer = manufacturer;
            Cores = cores;
        }
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, Ram:{Ram}, Cores:{Cores}";

        }
    }
}