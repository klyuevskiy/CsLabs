using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportsmans;
using System.Windows.Forms;

namespace Main
{
    class FormSportsmanPrinter : ISportsmanPrinter
    {
        // text box куда будем выводить инфу
        TextBox lastNameTextBox,
            competitionsNumberTextBox,
            competitionsPlacesSumTextBox,
            qualityTextBox,
            rankedFirstTextBox;

        // конструктор для класса 1 уровня, без флага занял ли первое место
        public FormSportsmanPrinter(TextBox lastNameTextBox, TextBox competitionsNumberTextBox,
            TextBox competitionsPlacesSumTextBox, TextBox qualityTextBox)
        {
            this.lastNameTextBox = lastNameTextBox;
            this.competitionsNumberTextBox = competitionsNumberTextBox;
            this.competitionsPlacesSumTextBox = competitionsPlacesSumTextBox;
            this.qualityTextBox = qualityTextBox;
        }

        // конструктор для класса 2 уровня
        public FormSportsmanPrinter(TextBox lastNameTextBox, TextBox competitionsNumberTextBox,
            TextBox competitionsPlacesSumTextBox, TextBox qualityTextBox, TextBox rankedFirstTextBox)
        {
            this.lastNameTextBox = lastNameTextBox;
            this.competitionsNumberTextBox = competitionsNumberTextBox;
            this.competitionsPlacesSumTextBox = competitionsPlacesSumTextBox;
            this.qualityTextBox = qualityTextBox;
            this.rankedFirstTextBox = rankedFirstTextBox;
        }

        public void PrintLastName(string lastName)
        {
            lastNameTextBox.Text = lastName;
        }

        public void PrintCompetitionsNumber(int competitionsNumber)
        {
            competitionsNumberTextBox.Text = competitionsNumber.ToString();
        }

        public void PrintCompetitionsPlacesSum(int competitionsPlacesSum)
        {
            competitionsPlacesSumTextBox.Text = competitionsPlacesSum.ToString();
        }

        public void PrintQuality(double quality)
        {
            qualityTextBox.Text = quality.ToString();
        }

        public void PrintRankedFirst(bool rankedFirst)
        {
            rankedFirstTextBox.Text = (rankedFirst ? "Да" : "Нет");
        }
    }
}
