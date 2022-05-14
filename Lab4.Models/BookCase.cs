using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    //Класс должен содержать дополнительно 2 свойства и 2 метода.

    // 2 свойства - HasDoor, ShelvesNumber
    // 2 метода - узнать кол-во книг

    // книжный шкаф
    public class BookCase : Closet
    {
        // свойства имеет шкаф дверь или нет
        public bool HasDoor { get; set; }

        // количество книжных полок

        private int _shelvesNumber;

        public int ShelvesNumber
        {
            get => _shelvesNumber;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указано отрицательное количество полок");

                _shelvesNumber = value;
            }
        }

        public override double ArrangeDelivery()
        {
            // пусть дотсавка зависит от объёма товара
            // также зависит от наличия дверцы - дверца + 200
            // минимальная сумма доставки - 500, максимальная - 10000
            return base.ArrangeDelivery() +
                (HasDoor ? 200 : 0);
        }

        // сколько книг помещается на одну полку
        public int HowManyBooksFitOnShelf(double bookWidth = 5)
        {
            if (bookWidth == 0)
                return 0;

            // для расчёта берётся длина шкафа и делиться на среднюю толщину книги
            // средняя толщина придумана
            return (int)(Length / bookWidth);
        }

        // сколько книг помещается в шкаф
        public int HowManyBooksFit(double bookWidth = 5)
        {
            return HowManyBooksFitOnShelf(bookWidth) * _shelvesNumber;
        }

        public override void Copy(IFurniture other)
        {
            base.Copy(other);

            // проверим что копируем книжный шкаф
            if (other is BookCase otherBookCase)
            {
                HasDoor = otherBookCase.HasDoor;
                ShelvesNumber = otherBookCase.ShelvesNumber;
            }
        }
    }
}
