using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asociaciones.ManyToMany
{
    //Many Films to Many Categories (ManyToMany)
    public class Film
    {
        public long Id;
        public string Title;
        public int Duration;

        //asociaciones
        public List<Category> categories = new List<Category>();

        public Film() { }

        public override string ToString()
        {
            return $"Film: {Id}, Title:{Title}, Duration:{Duration}";
        }
    }
}
