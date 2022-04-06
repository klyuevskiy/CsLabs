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
        TextBox lastNameTextBox,
            competitionsNumberTextBox,
            competitionsPlacesSumTextBox,
            qualityTextBox,
            rankedFirstTextBox;

        public FormSportsmanPrinter(TextBox lastNameTextBox, TextBox competitionsNumberTextBox,
            TextBox competitionsPlacesSumTextBox, TextBox qualityTextBox)
        {
            this.lastNameTextBox = lastNameTextBox;
            this.competitionsNumberTextBox = competitionsNumberTextBox;
            this.competitionsPlacesSumTextBox = competitionsPlacesSumTextBox;
            this.qualityTextBox = qualityTextBox;
        }

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
