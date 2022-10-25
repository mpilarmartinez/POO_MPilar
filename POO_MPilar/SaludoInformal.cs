using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class SaludoInformal : ISaludo
    {
        public void Saludar()
        {
        Console.WriteLine("whats up guaysss!!!");
        
        }
    public void Saludar(string nombre)
        {
            Console.WriteLine("whats up" + nombre + "!!!");
        }  
    }
}
