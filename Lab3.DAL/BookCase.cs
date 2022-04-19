using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.DAL
{
    public class BookCase : Closet
    {
        public int ShelvesNumber { get; set; }
        public int BooksNumberOnShelfe { get; set; }
    }
}
