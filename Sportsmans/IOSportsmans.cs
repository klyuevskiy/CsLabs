using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsmans
{
    // интерфейсы для ввода и вывода классов

    public interface ISportsmanPrinter
    {
        void PrintLastName(string lastName);
        void PrintCompetitionsNumber(int competitionsNumber);
        void PrintCompetitionsPlacesSum(int competitionsPlacesSum);
        void PrintQuality(double quality);
        void PrintRankedFirst(bool rankedFirst);
    }

    public interface ISportsmanInputter
    {
        string InputLastName();
        int InputCompetitionsNumber();
        int InputCompetitionsPlacesSum();
        bool InputRankedFirst();
    }
}
