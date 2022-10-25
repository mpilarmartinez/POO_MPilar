using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{ 
    // Constructor
    // Implementar métodos de interfaz 
    public class ComputerListRepository : IComputerRepository {

        // Atributos
        private List<Computer> computers;
        // Constructor
        public ComputerListRepository()
        {
            computers = new List<Computer>{
                new Computer{ Id = 1, Model = "MackBook Pro", Ram=16 },
                new Computer{ Id = 2, Model = "MSI Modern", Ram=32 },
                new Computer{ Id = 3, Model = "Asus Assa", Ram=8 },
            };
        }

        // Implementar métodos de interfaz
        public List<Computer> FindAll()
        {
            return computers;
        }

        public Computer FindById(int id) {
            foreach (Computer computer in computers) {
                if (computer.Id == id)
                    return computer;
            }
            return null;
        }
    }
}
