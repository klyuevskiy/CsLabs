using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // абстрактный класс модели - человека, в нашем случае это спростмен и доктор
    public abstract class PersonModel : Model
    {
        // координаты куда будет возвращаться модель, если не занята
        protected float defaultX, defaultY;

        // укажем в какую точку идёт модель в данный момент
        public float ToX { get; internal set; }
        public float ToY { get; internal set; }

        public PersonModel(Action<string> Notification, float defaultX, float defaultY)
            : base(Notification)
        {
            this.defaultX = defaultX;
            this.defaultY = defaultY;

            X = defaultX;
            Y = defaultY;

            ToX = defaultX;
            ToY = defaultY;

            // в начале определим что модель ничего не делает
            DoSomething = null;
        }

        // Фамилия и Имя
        public string LastName { get; set; }
        public string FirstName { get; set; }

        // максимальная скорость с которой идут модели по одной координате
        const float maxSpeed = 3;

        // делегат который будем вызвать в потоке
        // в зависимости от ситуации будем задавать нужный метод/функцию
        protected Action DoSomething;

        // проверка проиходящих сейчас событий
        // проверятся есть ли сейчас соревнование нппример
        // или есть ли больной, чтобы задать соответсвующие действия
        protected abstract void CheckEvents();

        public bool IsCome()
        {
            // различие в 5 пикселя будет незаметно, но зато точно не будет двигаться на месте
            return Math.Abs(X - ToX) < 5 && Math.Abs(Y - ToY) < 5;
        }

        public void Go()
        {
            // в пункте назначения
            if (IsCome())
                return;

            // определим как мы будем двигаться по координатам
            // |x-x0|/speedX = |y-y0|/speedY

            if (X - ToX != 0)
            {
                // X сдвигаем по maxSpeed speedY из соотношения выше вычисялем
                Y += maxSpeed * (ToY - Y) / Math.Abs(X - ToX);
                X += maxSpeed * Math.Sign(ToX - X);
            }
            else
            {
                X += maxSpeed * (ToX - X) / Math.Abs(Y - ToY);
                Y += maxSpeed * Math.Sign(Y - ToY);
            }
        }

        // Start везде одинаковый, пока не закрыт всё ок, делаем что-то
        public override void Start()
        {
            while (!IsCanceled)
            {
                // делаем проверку на null
                // так как модель в данный момент может не иметь нужное действие

                CheckEvents();
                Go();

                DoSomething?.Invoke();

                Task.Delay(30).Wait();
            }
        }
    }
}
