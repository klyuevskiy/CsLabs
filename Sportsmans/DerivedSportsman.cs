using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsmans
{
    public class DerivedSportsman : BaseSportsman
    {
        public bool RankedFirst { get; set; }

        public DerivedSportsman()
        {
            RankedFirst = false;
        }

        public DerivedSportsman(string lastName, int competitionsNumber, int competitionsPlacesSum, bool rankedFirst) :
            base(lastName, competitionsNumber, competitionsPlacesSum)
        {
            RankedFirst = rankedFirst;
        }

        public override double Quality()
        {
            return base.Quality() * (RankedFirst ? 1.5 : 1);
        }

        public override void Print(ISportsmanPrinter printer)
        {
            base.Print(printer);
            printer.PrintRankedFirst(RankedFirst);
        }

        public override void Input(ISportsmanInputter inputter)
        {
            base.Input(inputter);
            RankedFirst = inputter.InputRankedFirst();
        }
    }
}
