using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // класс соревнование
    // этот класс будет отвечать когда организоывать соревнование
    // этот класс будет тыкать свободных спорстменов прийти на него

    public class Competition : Model
    {
        // список спростменов и заглшука для него
        private readonly List<Sportsman> sportsmans;
        private readonly object sportsmansLocker;

        // участвующие в соревновпании спростмены
        List<Sportsman> participatingSportsmans;

        string Name { get; }

        int maxParticipatingSportmansNumber;

        public Competition(Action<string> Notification, List<Sportsman> sportsmans, object sportsmansLocker,
            float x, float y, string name, int maxParticipatingSportmansNumber = 5)
            : base(Notification)
        {
            this.sportsmans = sportsmans;
            this.sportsmansLocker = sportsmansLocker;
            X = x;
            Y = y;

            participatingSportsmans = new List<Sportsman>();

            Name = name;

            this.maxParticipatingSportmansNumber = maxParticipatingSportmansNumber;
        }

        // возвращеат началось ли соревнование или нет
        bool StartCompetition()
        {
            participatingSportsmans.Clear();

            lock (sportsmansLocker)
            {
                int participatingSportsmansNumber = 0;

                for (int i = 0; i < sportsmans.Count && participatingSportsmansNumber < maxParticipatingSportmansNumber; i++)
                {
                    // если не заблокирован
                    if (!sportsmans[i].IsLocked)
                    {
                        // назначем куда идти
                        sportsmans[i].ToX = X;
                        sportsmans[i].ToY = Y;

                        sportsmans[i].IsLocked = true;
                        participatingSportsmans.Add(sportsmans[i]);

                        participatingSportsmansNumber++;
                    }
                }
            }

            return participatingSportsmans.Count != 0;
        }

        async Task WaitAllSportmans()
        {
            bool allSportmansCame = false; ;

            while (!allSportmansCame)
            {
                await Task.Delay(100);

                lock (sportsmansLocker)
                {
                    allSportmansCame = participatingSportsmans.FirstOrDefault(item =>
                    !item.IsCome()) == null;
                }
            }
        }

        async Task DoCompetition()
        {
            Notification($"В соревновании {Name} примут участие {participatingSportsmans.Count} спортсменов");
            await WaitAllSportmans();

            Notification($"Соревнование {Name} начинается");
            Notification($"Соревнование {Name} идёт");

            // видимость соревнования(типо сколько-то длится)
            await Task.Delay(10 * 1000);
        }

        void PrintWinSportsman(int place, Sportsman sportsman)
        {
            Notification($"{place} место занял {sportsman.LastName} {sportsman.FirstName}");
        }

        // получить следующего победителя, рандомный, но который ещё не занял место
        int getNextWinner(Random random, int participatingSportsmansNumber, List<int> winners)
        {
            int result;

            do
            {
                result = random.Next(0, participatingSportsmansNumber);
            }
            while (winners.Contains(result));

            return result;
        }

        // return winners
        List<int> DetermineWinners()
        {
            List<int> winners = new List<int>();

            if (participatingSportsmans.Count == 0)
                return winners;

            Notification($"Победители соревнования {Name}:");

            // определим победителей

            // 1 просто рандомный из всего кол-ва
            Random random = new Random();

            int firstSportsman = getNextWinner(random, participatingSportsmans.Count, winners);
            winners.Add(firstSportsman);

            PrintWinSportsman(1, participatingSportsmans[firstSportsman]);

            // пришло больше одного спросмена, опрделеим 

            if (participatingSportsmans.Count == 1)
                return winners;

            int secondSportsman = getNextWinner(random, participatingSportsmans.Count, winners);
            winners.Add(secondSportsman);

            PrintWinSportsman(2, participatingSportsmans[secondSportsman]);

            if (participatingSportsmans.Count == 2)
                return winners;

            // 3
            int thirdSportsman = getNextWinner(random, participatingSportsmans.Count, winners);
            winners.Add(thirdSportsman);

            PrintWinSportsman(3, participatingSportsmans[thirdSportsman]);

            return winners;
        }

        async Task WaitHeal(List<Sportsman> sickSportsmans)
        {
            bool allHeal = true;

            do
            {
                await Task.Delay(100);

                allHeal = sickSportsmans.Count(sportsman => sportsman.IsIll) == 0;

            } while (!allHeal);
        }

        void PrintSickSportsmans(List<Sportsman> sickSPortsmans)
        {
            string message = "";

            foreach (var item in sickSPortsmans)
            {
                message += $"{item.LastName} {item.FirstName}: {Disease.AllDisease[item.DiseaseIndex]}\r\n";
            }

            Notification(message);
        }

        List<Sportsman> DetermineSickSportsmans(List<int> winners)
        {
            List<Sportsman> sickSportsmans = new List<Sportsman>();

            Random random = new Random();

            for (int i = 0; i < participatingSportsmans.Count; i++)
                if (!winners.Contains(i))
                {
                    participatingSportsmans[i].RandomSick(random);

                    if (participatingSportsmans[i].IsIll)
                        sickSportsmans.Add(participatingSportsmans[i]);
                    else
                        participatingSportsmans[i].IsLocked = false;
                }

            return sickSportsmans;
        }

        public async Task EndCompetition()
        {
            Notification($"Соревнование {Name} закончилось");

            List<int> winners = DetermineWinners();

            Notification($"Проходит цеременония награждения соревнования {Name}");

            await Task.Delay(5000);

            Notification($"Церемнония награждения соревнования {Name} закончена");

            // разблокируем победителей

            foreach (var item in winners)
            {
                participatingSportsmans[item].IsLocked = false;
            }

            // далее разыграем подарки... болезни

            // будем хранить список заболевших спортсемнов, чтобы подождать пока они вылячется

            Random random = new Random();

            List<Sportsman> sickSportsmans = DetermineSickSportsmans(winners);

            if (sickSportsmans.Count != 0)
            {
                Notification($"Во время соревнования {Name} спортсмены получили травмы\n");

                PrintSickSportsmans(sickSportsmans);
                Notification($"Пока все спортсены не выздоровят, соревнование {Name} не начнётся");
                await WaitHeal(sickSportsmans);

                Notification($"Соревнования {Name}: Все спортсмены вылечены!");
            }
        }

        public override async void Start()
        {
            while (!IsCanceled)
            {
                Notification($"Скоро будет соревнование {Name}");

                await Task.Delay(5 * 1000);

                if (!StartCompetition())
                {
                    Notification($"Спортсмены не пришли на участие в соревнование {Name}, соревнование отменяется");
                }
                else
                {
                    await DoCompetition();

                    await EndCompetition();   
                }

                // интервал времени между соревнованиями
                await Task.Delay(10 * 1000);
            }
        }
    }
}
