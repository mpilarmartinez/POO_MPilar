using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        private ComputerValidator Validator;
        
        // Constructor
        public ComputerListRepository(ComputerValidator validator)
        {
            //Simulamos que la lista computers es una base de datos
            computers = new List<Computer>{
                new Computer{ Id = 1, Model = "MackBook Pro", Ram=16 },
                new Computer{ Id = 2, Model = "MSI Modern", Ram=32 },
                new Computer{ Id = 3, Model = "Asus Assa", Ram=8 },
            };
            Validator = validator;
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
            ComputerValidator validator = new ComputerValidator();
            
            if (!validator.Validate(computer))
                return false;

            computers.Add(computer);
            return true;



        }

        // Count
        public int Count()
        {
            // return computers.Count;

            int contador = 0;
            foreach (Computer computer in computers)
                contador++;
            //for (int i=0; i<com`puters.Count; i++)
            return contador;
        }

        // guardar varios y devolver el numero de ordenadores guardados
        public int SaveAll(List<Computer> computersToAdd){

            //computersToAdd es la nueva lista de ordenadores a agregar
            //computers es la lista de ordenadores que ya tenemos
            int contador = 0;
            foreach (Computer computer in computersToAdd){
                bool saved = Save(computer);
                if (saved) contador++;
            }
            return contador;
        }

        public void PrintAll() { 
        
        foreach (Computer computer in computers) {
                Console.WriteLine(computer);
        }
        
        }

        public bool Update(Computer computer) {

            // comprobar si existe
            if (!ExistsById(computer.Id))
                return false;

            // si no existe entonces devolver false
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i].Id == computer.Id)
                {
                    // actualizar atributos del computer de la lista con los
                    // del computer que llega como parámetro
                    computers[i].Model = computer.Model;
                    computers[i].Ram = computer.Ram;

                    return true; //una vez modificado salimos del métoddo
                }
            }
            return false;
        
        }

        //borrar por id
        public bool DeleteById(int id) {
            //comprobar si existe
        if(!ExistsById(id))
           return false;

            for (int i = 0; i < computers.Count; i++) {
                if (computers[i].Id == id) {
                    computers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteAll() {
            // if (computers.Count == 0)
            //     return false;

            if (!computers.Any())
                return false;
            
            computers.Clear();
            return true;

        }
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
