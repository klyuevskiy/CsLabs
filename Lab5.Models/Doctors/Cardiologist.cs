using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Cardiologist : Doctor
    {
        public Cardiologist(Action<string> Notification, float defaultX, float defaultY, List<Sportsman> spotsmans, object sportsmansLocker)
            : base(Notification, defaultX, defaultY, spotsmans, sportsmansLocker)
        {
            for (int i = 0; i < Disease.AllDisease.Length; i++)
                if (Disease.AllDisease[i].Contains("сердц"))
                    HealDiseaseIndexes.Add(i);
        }
    }
}
