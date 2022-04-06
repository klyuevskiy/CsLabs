using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sportsmans;

namespace Main
{
    public partial class MainForm : Form
    {
        BaseSportsman baseSportsman = new BaseSportsman();
        DerivedSportsman derivedSportsman = new DerivedSportsman();

        public MainForm()
        {
            InitializeComponent();
        }

        private void inputBaseSportsmanButton_Click(object sender, EventArgs e)
        {
            baseSportsman.Input(new FormSportsmanInputter());
        }

        private void printBaseSportsmanButton_Click(object sender, EventArgs e)
        {
            // при выводе, когда считвается качество может быть вызвано иключение - так как иначе будет деление на 0
            try
            {
                baseSportsman.Print(new FormSportsmanPrinter(baseSportsmanLastName, baseSportsmanCompetitionsNumber,
                baseSportsmanQuality, baseSportsmanCompetitionsPlacesSum));
            }
            catch(InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void inputDerivedSportsmanButton_Click(object sender, EventArgs e)
        {
            derivedSportsman.Input(new FormSportsmanInputter());
        }

        private void printDerivedSportsmanButton_Click(object sender, EventArgs e)
        {
            // при выводе, когда считвается качество может быть вызвано иключение - так как иначе будет деление на 0
            try
            {
                derivedSportsman.Print(new FormSportsmanPrinter(derivedSportsmanLastName, derivedSportsmanCompetitionsNumber,
                    derivedSportsmanCompetitionsPlacesSum, derivedSportsmanQuality, derivedSportsmanRankedFirst));
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
