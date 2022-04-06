using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // валидатор, что целое неотрицательное число
    public class NotNegativeIntValidator : IStringValidator
    {
        // число типа int => используем при этом валидатор на int
        IntValidator intValid = new IntValidator();

        string errorMessage;
        public string ErrorMessage { get => errorMessage; }

        public bool IsValid(string str)
        {
            bool isInt = intValid.IsValid(str);

            // не число, сразу выход
            if (!isInt)
            {
                errorMessage = intValid.ErrorMessage;
                return false;
            }

            // теперь проверим что не отрицательный
            bool isValid = Int32.Parse(str) >= 0;

            if (!isValid)
                errorMessage = "Число меньше 0";

            return isValid;
        }
    }
}
