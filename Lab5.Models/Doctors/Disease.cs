using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // класс хранящий информацию о всех возможных болезнях
    public static class Disease
    {
        // я решил, что у меня будут врачи: кардиолог, невролог, травматолог
        // я не стал искать настоящие названия болезней, поэтому сделал так:
        static string[] _allDisease = new string[]
        {
            "Болезнь нервов №1",
            "Болезнь нервов №2",
            "Болезнь нервов №3",
            "Болезнь сердца №1",
            "Болезнь сердца №2",
            "Болезнь сердца №3",
            "Травма №1",
            "Травма №2",
            "Травма №2"
        };

        public static string[] AllDisease { get => _allDisease; }
    }
}
