using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asociaciones.ManyToOne
{
    //Many Books To One Author(ManyToOne)
    public class Book
    {
        // atributos
        public long id;
        public string title;

        // asociaciones
        public Author Author; //ManyToOne
        
        public Book() { }

        public override string ToString()
        {
            return $"Book: {id}, Title:{title}, Author:{Author.Name}";
        }
    }


}
