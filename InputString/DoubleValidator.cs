using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // Валидатор проверяющий, что строка число типа double
    public class DoubleValidator : IStringValidator
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
}
