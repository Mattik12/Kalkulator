using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    class NumberValidator
    {
        public string Liczba1 { get; private set; }

        public string Liczba2 { get; private set; }

        public double ResultOne { get; private set; }

        public NumberValidator()
        {
            this.Liczba1 = "";
            this.Liczba2 = "";
        }

        public NumberValidator(string liczba1, string liczba2)
        {
            this.Liczba1 = liczba1;
            this.Liczba2 = liczba2;
        }

        public bool Validator(string liczba1, string liczba2, out double result1, out double result2)
        {
            result1 = 0;
            result2 = 0;
            bool wynik1 = double.TryParse(liczba1, out double resultOne);
            bool wynik2 = double.TryParse(liczba2, out double resultTwo);
                if (wynik1 && wynik2)
                {

                result1 = resultOne;
                result2 = resultTwo;
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}
