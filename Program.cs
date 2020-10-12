using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNumberOne = "";
            double resultFromValidator;
            string wybor = "";
            string upperWybor = "";
            double wynikPoPierwszejIteracji = 0;


            NumbersFromUser numbers = new NumbersFromUser();
            Dzialania dzialania = new Dzialania();
            NumberValidator numberValidator = new NumberValidator();

            Console.WriteLine("Witaj w kalkulatorze");
            Console.WriteLine("Aby zacząć podaj liczbę i wybierz działanie jakie chcesz wykonać");
            Console.WriteLine("Liczba pierwsza to: ");
            userNumberOne = numbers.GetNumberFromUser();
            NumberValidator validator = new NumberValidator(userNumberOne);
            validator.Validator(userNumberOne, out double result);


            OperationChoose operationChoose = new OperationChoose(dzialania, numberValidator, numbers, result);
            operationChoose.WyborDzialania(dzialania, numberValidator, numbers, result);
            Console.WriteLine(operationChoose.Wynik);
                     
            Console.WriteLine("Jeśli chcesz kontynuować operacje na kalkulatorze wybierz jedno z dostępnych działań");
            do
            {
                wynikPoPierwszejIteracji = operationChoose.Wynik;
                operationChoose.WyborDzialania(dzialania, numberValidator, numbers, wynikPoPierwszejIteracji);
                Console.WriteLine(operationChoose.Wynik);
                Console.WriteLine("Wciśnij dowolny klawisz w celu kontynuowania, jeśli chcesz wyjść wybierz klawisz Q");
                wybor = Console.ReadLine();
                upperWybor = wybor.ToUpper();
                Console.Clear();
                
            } while (upperWybor != "Q");
       
            Console.ReadKey();
        }
    }
}
