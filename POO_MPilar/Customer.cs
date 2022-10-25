using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class Customer
    {
        public string Dni;
        public string Email;
        public ISaludo saludo;
        public Address Address;
        public RoadVehicle Vehicle; //Polimorfismo
        //porque podria ser cualquiera de sus hijos
        public List<RoadVehicle> PersonalVehicles; //Polimorfismo
        public Customer()
        {
        }

        public void Saludar()
        {
            saludo.Saludar();
        }

    }
}
