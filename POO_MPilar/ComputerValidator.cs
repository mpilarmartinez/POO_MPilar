using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar;
public class ComputerValidator
{
    public bool Validate(Computer computer) {

        //Comprobar Id
        if (computer == null || computer.Id == 0)
            return false; //El computer es incorrecto

        //Comprobar RAM
        if (computer.Ram <= 2  || computer.Ram >= 256)
            return false; //El computer es incorrecto

        //Comprobar Model
        if (computer.Model == null || computer.Model.Length<=3)
            return false; //El computer es incorrecto
        
        return true; // El computer es correcto
    }
    
}
