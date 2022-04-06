using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricObjects;
using System.Windows.Forms;
using InputString;

namespace MainForm
{
    // класс для ввода точки, возвращает null если ввод не удачный
    class FormInputPoint
    {
        public Point Input()
        {
            // создаём диалоговые окна для ввода координат

            InputStringDialog inputX = new InputStringDialog(new DoubleValidator(), "Введите X координату"),
                inputY = new InputStringDialog(new DoubleValidator(), "Введите Y координату");

            // возвращаем точку если оба диалго вернули OK

            if (inputX.ShowDialog() == DialogResult.OK && inputY.ShowDialog() == DialogResult.OK)
                return new Point(Double.Parse(inputX.Value), Double.Parse(inputY.Value));

            // иначе null
            return null;
        }
    }

    // класс для ввода круга, возвращает null если ввод не удачный
    class FormInputCircle
    {
        // надо вводить центр круга, поэтому нужен ввод точки
        FormInputPoint inputPoint = new FormInputPoint();

        public Circle Input()
        {
            Point center = inputPoint.Input();

            InputStringDialog inputRadius = new InputStringDialog(new NotNegativeDoubleValidator(), "Введите радиус");

            // Создаём круг если ввод успешный 
            if (center != null && inputRadius.ShowDialog() == DialogResult.OK)
                return new Circle(center, Double.Parse(inputRadius.Value));

            // иначе null
            return null;
        }
    }

    // Класс для печати круга
    class FormCirclePrinter
    {
        // label куда записывается информация о круге
        Label circleCenterX, circleCenterY, circleRadius;

        public FormCirclePrinter(Label circleCenterX, Label circleCenterY, Label circleRadius)
        {
            this.circleCenterX = circleCenterX;
            this.circleCenterY = circleCenterY;
            this.circleRadius = circleRadius;
        }

        public void Print(Circumference circle)
        {
            circleCenterX.Text =  circle.Center.X.ToString() ?? "";
            circleCenterY.Text = circle.Center.Y.ToString() ?? "";
            circleRadius.Text = circle.Radius.ToString() ?? "";
        }
    }
}
