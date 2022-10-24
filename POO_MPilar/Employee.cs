using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POO_MPilar;
// Clase que representa empleados
public class Employee
{
    
    // 1. atributos informacion del empleado

    public string Dni;
    
    public string Name;

    public int Age;

    public double Salary;

    public bool married;


    // 2. constructor: metodo especial que permite construir objetos
    public Employee(string dni, string name, int age, double salary, bool married)
    {
        Console.WriteLine("Employee constructor");
        Dni = dni;
        Name = name;
        Age = age;
        Salary = salary;
    }

    // constructor sobrecargado: permite duplicar métodos variando los parámetros
    public Employee(string Dni, string Name)
    {
        Console.WriteLine("Employee constructor 2");
        this.Dni = Dni;
        this.Name = Name;

    }

    // constructor sobrecargado
    public Employee(string Dni, string Name, double Salary)
    {
        Console.WriteLine("Employee constructor 3");
        this.Dni = Dni;
        this.Name = Name;
        this.Salary = Salary;    
    }

    //constructor vacio para crear objeto sin ningun valor inicial
    public Employee()
    {
    

    }

}
