using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class SaludoFormal : ISaludo
    { //implementa la interfaz ISaludo
        public void Saludar()
        {
        //define el cómo se hace
        Console.WriteLine("Hello ladies and gentlemen");
        }
        public void Saludar(string nombre)
        {
            Console.WriteLine("Dear Mrs/Sr" + nombre + ".");
        }
    }
}
