using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsmans
{
    public class BaseSportsman
    {
        // фамилия, кол-во соревнований, сумма мест
        public string LastName { get; set; }
        public int CompetitionsNumber { get; set; }
        public int CompetitionsPlacesSum { get; set; }

        // конструкторы

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

        // функция вычисления качества
        public virtual double Quality()
        {
            // не забываем привести к double
            return (double)CompetitionsNumber / (double)CompetitionsPlacesSum;
        }

        // ввод вывод осуществялется посредством реализации интерфейса
        // можно будет тогда реализовать ввод вывод с формы, консоли и т.д., структура класса не поменяется

        public virtual void Print(ISportsmanPrinter printer)
        {
            printer.PrintLastName(LastName);
            printer.PrintCompetitionsNumber(CompetitionsNumber);
            printer.PrintCompetitionsPlacesSum(CompetitionsPlacesSum);

            // произойдёт деление на 0, что недопустимо
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
