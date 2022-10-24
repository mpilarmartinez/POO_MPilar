using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public class Address
    {
        public string Street;
        public string PostalCode;
        public string City;
        public Country Country; 
        //Asociacion ente clases:
        //separar a una nueva clase asociada

        public Address() { }
    }
    public class Country
    {
        //atributos
        public string NameISO;
        public int Population;
        public double PIB;
        public string Capital;
        public bool IsMemberEU;
        //Asociacion con una nueva clase language (1:N)
        //tiene multiples lenguajes
        public List<Language> Languages = new List<Language>();
        // Language (1:1) Tiene un idioma

    }

    public class Language
    {
        public string Name;
        public string ISO;
        public int Year;
        public bool latin;
    }
    //Crear clase lenguaje

}
