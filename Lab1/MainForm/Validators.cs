using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    // интерфейс для валидаторов строки
    public interface IStringValidator
    {
        bool IsValid(string str);

        // сообщение об ошибке, задаём почему строка невалидна
        string ErrorMessage { get; }
    }

    // Валидатор проверяющий, что строка число типа double
    class DoubleValidator : IStringValidator
    {
        string errorMessage = "";
        public string ErrorMessage { get => errorMessage; }

        public bool IsValid(string str)
        {
            // проверяем строка что число типа double
            double res;
            bool isDouble = Double.TryParse(str, out res);

            // строка не double настраиваем сообщение
            if (!isDouble)
                errorMessage = "Введено не число";

            return isDouble;
        }
    }

    // Валидатор, проверяющий радиус
    class RadiusValidator : IStringValidator
    {
        // радиус типа double => используем при этом валидатор на double
        DoubleValidator doubleValid = new DoubleValidator();

        string errorMessage;
        public string ErrorMessage { get => errorMessage; }

        public bool IsValid(string str)
        {
            bool isDouble = doubleValid.IsValid(str);

            // не число, сразу выход
            if (!isDouble)
            {
                errorMessage = doubleValid.ErrorMessage;
                return false;
            }

            // теперь проверим что радиус не отрицательный
            bool isValid = Double.Parse(str) >= 0;

            if (!isValid)
                errorMessage = "Радиус меньше 0";

            return isValid;
        }
    }
}
