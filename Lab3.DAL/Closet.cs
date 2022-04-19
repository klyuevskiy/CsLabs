using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.DAL
{
    public abstract class Closet : IFurniture
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
    }
}
