using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.OneToOne;

public class Customer
{
    // atributos
    public long Id;
    public string Name;
    public int Age;

    // asociaciones
    public Address address; //one Customer to one Address

    // constructores
    public Customer() { }

    // métodos


    // ToString
    public override string ToString()
    {
        return $"Customer: {Id}, Name:{Name}, Age:{Age}";
    }

}
