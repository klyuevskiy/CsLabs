using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsmans
{
    public class BaseSportsman
    {
        public string LastName { get; set; }
        public int CompetitionsNumber { get; set; }
        public int CompetitionsPlacesSum { get; set; }

        public BaseSportsman()
        {
            LastName = "";
            CompetitionsNumber = 0;
            CompetitionsPlacesSum = 0;
        }

        public BaseSportsman(string lastName, int competitionsNumber, int competitionsPlacesSum)
        {
            LastName = lastName;
            CompetitionsNumber = competitionsNumber;
            CompetitionsPlacesSum = competitionsPlacesSum;
        }

        public virtual double Quality()
        {
            return (double)CompetitionsNumber / (double)CompetitionsPlacesSum;
        }

        public virtual void Print(ISportsmanPrinter printer)
        {
            printer.PrintLastName(LastName);
            printer.PrintCompetitionsNumber(CompetitionsNumber);
            printer.PrintCompetitionsPlacesSum(CompetitionsPlacesSum);

            if (CompetitionsPlacesSum == 0)
                throw new InvalidOperationException("Невозможно подсчитать качество без суммы мест за соревнования");

            printer.PrintQuality(Quality());
        }

        public virtual void Input(ISportsmanInputter inputter)
        {
            LastName = inputter.InputLastName();
            CompetitionsNumber = inputter.InputCompetitionsNumber();
            CompetitionsPlacesSum = inputter.InputCompetitionsPlacesSum();
        }
    }
}
