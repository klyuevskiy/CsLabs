using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    // класс круг
    // круг ведёт себя как окружность, только туда ещё включена область внутри окружности, поэтому круг наследуем от окужности
    // класс круга только расширяет окружность и может использоваться как базовый класс

    public class Circle : Circumference
    {
        // круг наследуется от окружности, поэтому его изменение через свойства
        // свойства заменяют методы изменения размеров

        public Circle()
        {

        }

        public Circle(Point center, double radius) :
            base(center, radius)
        {

        }

        // определить что точко внутри круга
        public bool InCircle(Point point)
        {
            return Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)
                <= Math.Pow(Radius, 2);
        }
    }
}
