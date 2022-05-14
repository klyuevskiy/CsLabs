using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    //9.  interface Мебель -> abstract class Шкаф -> class Книжный Шкаф.

    //Для интерфейса необходимо определить 1 свойство и 2 метода. 

    // у меня 2 свойства и 2 метода

    // интерфейс мебели
    public interface IFurniture
    {
        // Id мебели - для хранения в базе
        int Id { get; set; }
        // цена мебели
        double Price { get; set; }

        // оформить доставку, возвращает цену доставки
        // цена доставки должна зависить от габаритов товара
        double ArrangeDelivery();
        // добавим метод копирования мебели(копировать информацию)
        void Copy(IFurniture other);
    }
}
