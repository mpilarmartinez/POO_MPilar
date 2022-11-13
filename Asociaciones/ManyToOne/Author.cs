using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.ManyToOne
{
    //One Author To Many Books (OneToMany)
    public class Author
    {
        // atributos
        public long Id;
        public string Name;

        //asociaciones (OneToMany)
        public List<Book> books;
        public Author() { }

        public override string ToString()
        {
            return $"Author: {Id}, Name:{Name}";
        }


    }
}
