using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.DAL
{
    public class BookCaseRepository : IRepository<BookCase>
    {
        List<BookCase> _bookCases;

        public BookCaseRepository()
        {
            _bookCases = new List<BookCase>();
        }

        public void Add(BookCase item)
        {
            item.Id = _bookCases.Max(elem => elem.Id) + 1;
            _bookCases.Add(item);
        }

        public void Delete(int id)
        {
            var itemToDelete = Get(id);

            if (itemToDelete != null)
                _bookCases.Remove(itemToDelete);
        }

        public BookCase Get(int id)
        {
            return _bookCases.FirstOrDefault(elem => elem.Id == id);
        }

        public IEnumerable<BookCase> GetAll()
        {
            return _bookCases;
        }

        public void Update(BookCase item)
        {
            var itemToUpdate = Get(item.Id);

            if (itemToUpdate != null)
            {
                itemToUpdate.Height = item.Height;
                itemToUpdate.Width = item.Width;
                itemToUpdate.Length = item.Length;
                itemToUpdate.ShelvesNumber = item.ShelvesNumber;
                itemToUpdate.BooksNumberOnShelfe = item.BooksNumberOnShelfe;
            }
        }
    }
}
