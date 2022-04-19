using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repository
{
    //В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

    // интерфейс репозитория для большей гибкости
    public interface IRepository
    {
        IEnumerable<IFurniture> GetAll();
        IFurniture Get(int id);
        void Add(IFurniture item);
        void Update(IFurniture item);
        void Delete(int id);
    }
}
