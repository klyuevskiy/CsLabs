using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsmans
{
    //Задание: построить класс 1-го уровня с указанными в индивидуальном задании полями и методами: 
    //конструктор; 
    //функция, которая определяет «качество» объекта – Q по заданной формуле(столбец 2);
    //вывод информации об объекте.
    //Построить класс 2-го уровня (класс-потомок), который содержит: 
    //дополнительное поле P; 
    //функция, которая определяет «качество» объекта класса 2-го уровня – Qp, которая перекрывает функцию качества класса 1-го уровня(Q ), выполняя вычисление по новой формуле(столбец 3).  
    //Создать проект для демонстрации работы: ввод и вывод информации об объектах классов 1-го и 2-го уровней.


    //Спортсмен: 
    //фамилия; 
    //число соревнований;
    //сумма мест, занятых спортсменом в соревнованиях.
    //Q = (число соревнований)/ (сумма мест)
    //P: занимал ли хотя бы раз первое место

    //Qp = 1,5·Q,  если Р - истина,  иначе – Qp= Q, 



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
