using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    class NumberValidator
    {
        public string Liczba { get; private set; }

        public double ResultOne { get; private set; }

        public NumberValidator()
        {
            this.Liczba = "";
        }

        public NumberValidator(string liczba)
        {
            this.Liczba = liczba;
        }

        public bool Validator(string liczba1, out double result1)
        {
            result1 = 0;
            bool wynik1 = double.TryParse(liczba1, out double resultOne);
            if (wynik1 == true)
            {
                result1 = resultOne;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
