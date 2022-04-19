using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
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

        // сколько книг помещается на одну полку
        public int HowManyBooksFitOnShelf(double bookWidth = 5)
        {
            // для расчёта берётся длина шкафа и делиться на среднюю толщину книги
            // средняя толщина придумана
            return (int)(Length / bookWidth);
        }

        // сколько книг помещается в шкаф
        public int HowManyBooksFit(double bookWidth = 5)
        {
            return HowManyBooksFitOnShelf(bookWidth) * _shelvesNumber;
        }

        public new void Copy(IFurniture other)
        {
            base.Copy(other);

            // проверим что копируем книжный шкаф
            if (other is BookCase)
            {
                BookCase otherBookCase = other as BookCase;

                HasDoor = otherBookCase.HasDoor;
                ShelvesNumber = otherBookCase.ShelvesNumber;
            }
        }
    }
}
