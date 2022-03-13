using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    // класс окружность
    public class Circumference
    {
        // изменения центра и радиуса через свойства

        // центр - автосовойство 
        public Point Center { get; set; }

        // на радиус заложим ограничение, что он не меньше 0
        // обращение через свойство гарантирует выполнение условия

        protected double radius;

        public double Radius
        {
            get => radius;
            set
            {
                // при нарушении условия выбразываем исключение
                if (value < 0)
                    throw new ArgumentException("Invalid radius");

                radius = value;
            }
        }

        public Circumference()
        {
            Center = new Point();
            Radius = 0;
        }

        public Circumference(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}
