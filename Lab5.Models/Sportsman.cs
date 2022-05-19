using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // так как соревнование будет само тыкать сопросменов, а врач сам к ним идти
    // то спортсмен не особо что-то делает, но будет возвращаться на своё место
    public class Sportsman : PersonModel
    {
        public bool IsIll { get; internal set; }

        public int DiseaseIndex { get; internal set; }

        public Sportsman(Action<string> Notification, float defaultX, float defaultY)
            : base(Notification, defaultX, defaultY)
        {

        }

        public bool WaitHeal { get; internal set; }

        public void RandomSick(Random random)
        {   
            // 30% заболеть
            // 0..9  в сумме 10
            if (random.Next(0, 10) < 3)
            {
                DiseaseIndex = random.Next(0, Disease.AllDisease.Length);
                IsIll = true;
                WaitHeal = false;
            }
        }

        // будет проверять занят или нет, если нет, то будет задавать отчку возвращения
        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                ToX = defaultX;
                ToY = defaultY;
            }
        }
    }
}
