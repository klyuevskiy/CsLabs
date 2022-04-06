using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // валидатор, что введено целое число
    public class IntValidator : IStringValidator
    {
        string errorMessage;
        public string ErrorMessage { get => errorMessage; }

        public bool IsValid(string str)
        {
            // проверяем строка что число типа double
            int res;
            bool isDouble = Int32.TryParse(str, out res);

            // строка не double настраиваем сообщение
            if (!isDouble)
                errorMessage = "Введено не целое число";

            return isDouble;
        }
    }
}
