using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportsmans;
using InputString;
using System.Windows.Forms;

namespace Main
{
    class FormSportsmanInputter : ISportsmanInputter
    {
        // ввод фамилии - вызов формы для ввода строки с проверкой на слово
        public string InputLastName()
        {
            InputStringDialog input = new InputStringDialog(new WordValidator(), "Введите фамилию");

            if (input.ShowDialog() == DialogResult.OK)
                return input.Value;

            return "";
        }

        // ввод кол-во соревнований - вызов формы ввода строки с проверкой на неотрицательное целое число
        public int InputCompetitionsNumber()
        {
            InputStringDialog input = new InputStringDialog(new NotNegativeIntValidator(), "Введите количество соревнований");

            if (input.ShowDialog() == DialogResult.OK)
                return Int32.Parse(input.Value);

            return 0;
        }

        // аналогично предыдущему
        public int InputCompetitionsPlacesSum()
        {
            InputStringDialog input = new InputStringDialog(new NotNegativeIntValidator(), "Введите сумму мест, занятых на соревнованиях");

            if (input.ShowDialog() == DialogResult.OK)
                return Int32.Parse(input.Value);

            return 0;
        }

        // вызов Message Box с кнопками Yes No
        public bool InputRankedFirst()
        {
            return MessageBox.Show("Занял ли хоть раз первое место?", "", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
