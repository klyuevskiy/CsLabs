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


    public class DerivedSportsman : BaseSportsman
    {
        // доп поле
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

        // ввод вывод вызываем у базового класса и вводим(выводим) доп. поле

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
