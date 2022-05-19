using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    class Neurologist : Doctor
    {
        public Neurologist(Action<string> Notification, float defaultX, float defaultY, List<Sportsman> spotsmans, object sportsmansLocker)
            : base(Notification, defaultX, defaultY, spotsmans, sportsmansLocker)
        {
            for (int i = 0; i < Disease.AllDisease.Length; i++)
                if (Disease.AllDisease[i].Contains("нерв"))
                    HealDiseaseIndexes.Add(i);
        }
    }
}
