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
        public string InputLastName()
        {
            InputStringDialog input = new InputStringDialog(new WordValidator(), "Введите фамилию");

            if (input.ShowDialog() == DialogResult.OK)
                return input.Value;

            return "";
        }


        public int InputCompetitionsNumber()
        {
            InputStringDialog input = new InputStringDialog(new NotNegativeIntValidator(), "Введите количество соревнований");

            if (input.ShowDialog() == DialogResult.OK)
                return Int32.Parse(input.Value);

            return 0;
        }

        public int InputCompetitionsPlacesSum()
        {
            InputStringDialog input = new InputStringDialog(new NotNegativeIntValidator(), "Введите сумму мест, занятых на соревнованиях");

            if (input.ShowDialog() == DialogResult.OK)
                return Int32.Parse(input.Value);

            return 0;
        }

        public bool InputRankedFirst()
        {
            return MessageBox.Show("Занял ли хоть раз первое место?", "", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
