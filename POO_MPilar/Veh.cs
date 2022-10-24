using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class Veh
    {
        // Atributos o estado
        public string Manufacturer;
        public string Model;
        public double CubicCentimeters;
        public bool Status; // encendido (true) o apagado (false)
        public int velocidad; // atributo velocidad

        // Constructor vacío (permite crear nuevos objetos)
        public Veh()
        {
        
        }

        // Metodos o comportamiento
        public void Start()
        {
            Status = true;
        }

        public void Stop()
        {
            Status = false;
        }

        // 1.metodo para acelerar la velocidad en una cantidad determinada
        // 1.a si la velocidad mas la cantidad supera 120 km/ entonces no lo sumamos
       
        public void Acelerar(int cantidad)
        {
            if (cantidad > 0 && velocidad + cantidad <= 120)
                velocidad += cantidad;
            else if (velocidad + cantidad > 120)
                velocidad = 120; // limite superior
        }

        // Método sobrecargado:  acelerar que reciba una cantidad y un límite
        public void Acelerar(int cantidad, int límite)
        {
            if (cantidad > 0 && velocidad + cantidad <= límite)
                velocidad += cantidad;
            else if (velocidad + cantidad > límite)
                velocidad = límite; // limite superior
        }

        // 2.metodo para reducir la velocidad en una cantidad determinada
        // 2.a si la velocidad menos la cantidad es menor que 0 entonces no la restamos
        public void Frenar(int cantidad)
        {
            if (cantidad > 0 && velocidad - cantidad <= 0)
                velocidad -= cantidad;
            else if (velocidad - cantidad < 0)
                velocidad = 0; 
        }

      



    }
}
