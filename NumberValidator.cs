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

        public double Validator(string liczba, out double result)
        {
            result = 0;
            bool wynik = double.TryParse(liczba, out double resultOne);
            if (wynik == true)
            {
                result = resultOne;
                return resultOne;
            }
            else
            {
                bool wynik1 = false;
                Console.WriteLine("Podana liczba jest nieprawidłowa, proszę podaj prawidłową liczbę: ");
                do
                {
                    NumbersFromUser ponownaLiczba = new NumbersFromUser();
                    this.Liczba = ponownaLiczba.GetNumberFromUser();
                    wynik1 = double.TryParse(this.Liczba, out double resultOne1);
                    if(wynik1 == true)
                    {
                        result = resultOne1;
                        return resultOne1;
                    }
                    Console.WriteLine("Podana liczba jest nieprawidłowa, proszę podaj prawidłową liczbę: ");
                } while (wynik1 != true);
                return 0;
            }
        }
    }
}
