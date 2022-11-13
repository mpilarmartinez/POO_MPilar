using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.OneToOne;

public class Address
{
    // atributos
    public long Id;
    public string Street;
    public string City;

    // asociaciones
    public Customer customer; //bidireccional (opcional)

    //constructores
    public Address() { }

    // ToString
    public override string ToString()
    {
        return $"Address: {Id}, Street:{Street}, City:{City}";
    }
}


