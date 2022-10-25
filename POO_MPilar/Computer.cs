using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class Computer
    {
        public int Id;
        public string Model;
        public int Ram;

        public Computer() { }

        // To String 

        public override string ToString()
        {
            return $"Computer: {Id}, Model:{Model}, Ram:{Ram}";
        }
    }
}
