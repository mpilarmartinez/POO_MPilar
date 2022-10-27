using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace POO_MPilar
{
    // Implementar métodos de interfaz 
    public class ComputerListRepository : IComputerRepository
    {
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
        // recupera todos los computers
        public List<Computer> FindAll()
        {
            return computers;
        }

        //recuperar un computer por su id
        public Computer FindById(int id)
        {
            foreach (Computer computer in computers)
            {
                if (computer.Id == id)
                    return computer;
            }
            return null;
        }

        // comprobar si existe por id
        public bool ExistsById(int id)
        {
            /*foreach (Computer computer in computers)
            {
                if (computer.Id == id)
                    return true;
            }
            return false; */
            return FindById(id) != null; // true o false
        }

        // recuperar por rango (min, max) de memoria Rams
        public List<Computer> FindAllByRam(int min, int max)
        {
            List<Computer> computersByRam = new List<Computer>();

            foreach (Computer computer in computers)
            {
                if (computer.Ram >= min && computer.Ram <= max)
                {
                    //añado el ordenador que cumple los filtros de RAM a la nueva lista

                    computersByRam.Add(computer);
                }
            }
            return computersByRam;
        }

        //buscar por su Model 
        public List<Computer> FindAllByModel(string model)
        {
            List<Computer> computersByModel = new List<Computer>();

            foreach (Computer computer in computers)
                if (computer.Model.ToLower().Equals(model.ToLower()))
                    computersByModel.Add(computer);

            return computersByModel;
        }

        // guardar uno
        public bool Save(Computer computer)
        {
            Console.WriteLine(computer);

            // comprobar si existe
            bool exist = ExistsById(computer.Id);

            // si existe no lo añado y devuelvo false
            if (exist) return false;

            // si no existe entonces lo añado a la lista y devuelvo true
            computers.Add(computer);
            return true;
        }

        // Count
        /*public int Count()
        {
            // return computers.Count;

            int contador = 0;

        }*/
        public bool ExistsbyId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Computer> FindAllByid()
        {
            throw new NotImplementedException();
        }
    }
}
