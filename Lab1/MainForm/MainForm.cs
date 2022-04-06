using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricObjects;

namespace MainForm
{
    public partial class MainForm : Form
    {
        // текущий круг
        Circle circle = new Circle();

        // объекты для печати и ввода точек и круга
        FormCirclePrinter circlePrinter;
        FormInputPoint inputPoint = new FormInputPoint();
        FormInputCircle inputCircle = new FormInputCircle();

        public MainForm()
        {
            InitializeComponent();

            // зададим куда печатает принтер
            circlePrinter = new FormCirclePrinter(circleCenterX, circleCenterY, circleRadius);
            circlePrinter.Print(circle);
        }

        private void createCircleButton_Click(object sender, EventArgs e)
        {
            Circle newCircle = inputCircle.Input();

            // запросили новый круг и меняем, если он был получен

            if (newCircle != null)
            {
                circle = newCircle;
                circlePrinter.Print(circle);
            }
            else
                MessageBox.Show("Новый круг не был создан");
        }

        private void changeCircleCenterButton_Click(object sender, EventArgs e)
        {
            GeometricObjects.Point newCenter = inputPoint.Input();

            // запросили новый центр и меняем, если он был получен

            if (newCenter != null)
            {
                circle.Center = newCenter;
                circlePrinter.Print(circle);
            }
            else
                MessageBox.Show("Центр не был изменён");
        }

        private void changeCircleRadiusButton_Click(object sender, EventArgs e)
        {
            // диалоговое окно для ввода радиуса, задаём проверку на радиус
            InputStringDialog inputRadius = new InputStringDialog(new NotNegativeDoubleValidator(), "Введите радиус");

            if (inputRadius.ShowDialog() == DialogResult.OK)
            {
                circle.Radius = Double.Parse(inputRadius.Value);
                circlePrinter.Print(circle);
            }
            else
                MessageBox.Show("Радиус не был изменён");
        }

        private void PointInCircleButton_Click(object sender, EventArgs e)
        {
            GeometricObjects.Point point = inputPoint.Input();

            if (point != null)
            {
                // точка получена, получим результат

                string result = $"Точка ({point.X}, {point.Y}) находится ";
                
                if (circle.InCircle(point))
                    result +=  "внутри круга";
                else
                    result += "вне круга";

                MessageBox.Show(result);
            }
        }
    }
}
