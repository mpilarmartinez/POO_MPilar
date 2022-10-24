using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace POO_MPilar;

public class Guest
{
    // public int age { get; }
    // public int Age { get; set; }

    private int age;
    public int Age
    {
        // getter que permite obtener el age
        get
        {
            return age;
        }
        //setter que permite modificar el age
        set
        {
            if (value >= 18)
                age = value;
            else
                age = 18;
        }
    }

    // solo lectura, no permite modificar
    public string Dni { get; }

    public double Salary
    {
        get;
        private set; //solo permite modificar desde dentro de la clase
    }

    public void promote(double quantity)
    {
        Salary += quantity;
    }

    
    // Ejemplo de uso de un método private
    public void Promote()
    {
        double quantity = CalcSalaryPromotion();
        Salary += quantity;
    }

    public double CalcSalaryPromotion()
    {
        return 100.0;
    }
}
