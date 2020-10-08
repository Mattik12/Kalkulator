using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNumberOne = "";
            double resultFromValidator;
            NumbersFromUser numbers = new NumbersFromUser();
            Dzialania dzialania = new Dzialania();
            NumberValidator numberValidator = new NumberValidator();



            Console.WriteLine("Witaj w kalkulatorze");
            Console.WriteLine("Aby zacząć podaj liczbę i wybierz działanie jakie chcesz wykonać");
            Console.WriteLine("Liczba pierwsza to: ");
            userNumberOne = numbers.GetNumberFromUser();
            NumberValidator validator = new NumberValidator(userNumberOne);
            validator.Validator(userNumberOne, out double result);
            Console.WriteLine("Podana liczba to: {0}", result);
            OperationChoose operationChoose = new OperationChoose(dzialania, numberValidator, numbers, result);
            operationChoose.WyborDzialania(dzialania, numberValidator, numbers, result);
            Console.WriteLine(operationChoose.Wynik);

            
            Console.ReadKey();
        }
    }
}
