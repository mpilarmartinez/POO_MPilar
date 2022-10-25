using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
  /*Las interfaces son tipos abstractos, no implementan los métodos,
   sólo los declaran*/
    public interface ISaludo
    {
        void Saludar (); //declara, dice qué hay que hacer
        void Saludar(string nombre);
        
    
    }   
}
