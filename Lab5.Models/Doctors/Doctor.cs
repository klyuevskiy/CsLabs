using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // в этом классе опредлется общее для всех докторов - идти лечит
    public abstract class Doctor : PersonModel, IDoctor
    {
        // список спорсменов, которые просматриваем и локер для него
        private readonly List<Sportsman> sportsmans;
        private readonly object sportsmansLocker;

        // ссылка на больного спросмена
        Sportsman sickSportsman;

        public Doctor(Action<string> Notification, float defaultX, float defaultY, List<Sportsman> spotsmans, object sportsmansLocker)
            : base(Notification, defaultX, defaultY)
        {
            HealDiseaseIndexes = new List<int>();

            this.sportsmans = spotsmans;
            this.sportsmansLocker = sportsmansLocker;
        }

        // нужный список болезней определяется профессией
        public List<int> HealDiseaseIndexes { get; }

        // идти лечить
        // проверят дошёл до цели, если дошёл, то лечит
        void Heal()
        {
            if (IsCome())
            {
                Notification($"Врач {LastName} {FirstName} лечит спортсмена " +
                        $"{sickSportsman.LastName} {sickSportsman.FirstName}");

                Task.Delay(5 * 1000).Wait();

                sickSportsman.IsIll = false;
                sickSportsman.IsLocked = false;

                Notification($"Спростмен {sickSportsman.LastName} {sickSportsman.FirstName} вылечен");

                // доктор ничего не делает
                DoSomething = null;
                IsLocked = false;

                //return to hospitel
                ToX = defaultX;
                ToY = defaultY;
            }
        }

        // здесь будем проверять есть ли кто нуждается в лечении
        protected override void CheckEvents()
        {
            if (IsLocked)
                return;

            lock(sportsmansLocker)
            {
                // если болеет и индекс болезни такой же
                sickSportsman = sportsmans
                    .FirstOrDefault(sportsman => sportsman.IsIll &&
                    HealDiseaseIndexes.Contains(sportsman.DiseaseIndex)
                    && !sportsman.WaitHeal);

                if (sickSportsman != null)
                {
                    // сразу пометим, что он ждёт лечения, чтобы другие врачи не пришли его лечить
                    sickSportsman.WaitHeal = true;
                    ToX = sickSportsman.X;
                    ToY = sickSportsman.Y;

                    IsLocked = true;
                    DoSomething = Heal;

                    Notification($"Врач {LastName} {FirstName} пошёл лечить спортсмена " +
                        $"{sickSportsman.LastName} {sickSportsman.FirstName}");
                }
            }
        }
    }
}
