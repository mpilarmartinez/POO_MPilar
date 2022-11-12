using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_MPilar
{
    public interface IComputerRepository
    {
        //recuperar todos los computers
        List<Computer> FindAll();

        //recuperar un computer por su id
        Computer FindById(int id);

        // comprobar si existe por id
        bool ExistsbyId(int id);

        // recuperar varios por ids
        List<Computer> FindAllByid();

        // recuperar por rango (min, max) de memoria Rams
        List<Computer> FindAllByRam(int min, int max);

        //buscar por su Model 
        List<Computer> FindAllByModel(string model);

        // guardar uno
        bool Save(Computer computer);

        // recuperar el número de ordenadores, para saber cuántos ordenadores hay
        int Count();

        // guardar varios
        int SaveAll(List<Computer> computersToAdd);

        // imprimir por consola (Print) todos los ordenadores de la lista
        // que ya tenemos
        void PrintAll();

        // modificar
        bool Update(Computer computer);

        //borrar por id
        bool DeleteById(int id);
     
        // borrar todos
           bool DeleteAll();

    }
}
