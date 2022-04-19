using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repository
{
    //В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

    // репозиторий, реализация через List
    public class ListRepository : IRepository
    {
        List<IFurniture> _repository;

        public ListRepository()
        {
            _repository = new List<IFurniture>();
        }

        public IFurniture Get(int id)
        {
            var item = _repository.FirstOrDefault(elem => elem.Id == id);

            if (item == null)
                throw new ArgumentException("Не найден Id");

            return item;
        }

        public IEnumerable<IFurniture> GetAll()
        {
            return _repository;
        }

        public void Delete(int id)
        {
            var itemToDelete = Get(id);

            _repository.Remove(itemToDelete);
        }

        public void Update(IFurniture item)
        {
            var itemToUpdate = Get(item.Id);

            itemToUpdate.Copy(item);
        }

        public void Add(IFurniture item)
        {
            // получим максимальный id в базе
            // новый = макс + 1

            if (_repository.Count == 0)
                item.Id = 1;
            else
                item.Id = _repository.Max(elem => elem.Id) + 1;

            _repository.Add(item);
        }
    }
}
