using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    class OperationChoose
    {
        public Dzialania Dzialania { get; set; }

        public NumberValidator NumberValidator { get; set; }

        public NumbersFromUser NumbersFromUser { get; set; }

        public double WprowadzonaLiczba { get; set; }

        public double  Wynik { get; private set; }


        public OperationChoose(Dzialania dzialania, NumberValidator numberValidator, NumbersFromUser numbersFromUser, double wprowadzonaLiczba)
        {
            this.Dzialania = dzialania;
            this.NumberValidator = numberValidator;
            this.WprowadzonaLiczba = wprowadzonaLiczba;
            this.NumbersFromUser = numbersFromUser;
        }

        public double WyborDzialania(Dzialania dzialania, NumberValidator numberValidator, NumbersFromUser numbersFromUser, double wprowadzonaLiczba)
        {
            this.Wynik = 0;
            string wybor;
            string wprowadzonaLiczbaDruga = "";
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("Dodawanie --- +");
            wybor = Console.ReadLine();
            switch (wybor)
            {
                case "+":
                    wprowadzonaLiczbaDruga = numbersFromUser.GetNumberFromUser();
                    numberValidator.Validator(wprowadzonaLiczbaDruga, out double result);
                    dzialania.Dodawanie(WprowadzonaLiczba, result);
                    this.Wynik = dzialania.Wynik;
                    return result;
                    break;
                default:
                    break;
            }
            return this.Wynik;
        }

    }
}
