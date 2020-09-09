using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kalkulatorze");
            Console.WriteLine("Aby zacząć podaj dwie liczby i wybierz działanie jakie chcesz wykonać");
            Console.WriteLine("Liczba pierwsza to: ");
            string liczbaWprowadzona1 = Console.ReadLine();
            Console.WriteLine("Liczba druga to: ");
            string liczbaWprowadzona2 = Console.ReadLine();
            NumberValidator validator = new NumberValidator(liczbaWprowadzona1, liczbaWprowadzona2);
            double liczba1;
            double liczba2;
            //bool zmienna = true;
            bool zmienna = validator.Validator(liczbaWprowadzona1, liczbaWprowadzona2, out liczba1, out liczba2);
            if(zmienna == true)
            {
                Console.WriteLine("Brawo, Twoje liczby to {0}, {1}", liczba1, liczba2);
            }
            else
            {
                Console.WriteLine("Liczby nie są nieprawidłowe, wprowadź je jeszcze raz: ");
            }
            while(zmienna != true) 
            { 
                Console.WriteLine("Wprowadź liczbę pierwszą jeszcze raz: ");
                liczbaWprowadzona1 = Console.ReadLine();
                Console.WriteLine("Wprowadź liczbę drugą jeszcze raz: ");
                liczbaWprowadzona2 = Console.ReadLine();
                zmienna = validator.Validator(liczbaWprowadzona1, liczbaWprowadzona2, out liczba1, out liczba2);
                if (zmienna == true)
                {
                    Console.WriteLine("Brawo, Twoje liczby to {0}, {1}", liczba1, liczba2);
                    
                }
                else
                {
                    Console.WriteLine("Liczby nie są nieprawidłowe, wprowadź je jeszcze raz: ");
                }
            }
            int wybor = 0;
            Dzialania dzialania = new Dzialania(liczba1, liczba2);
            Console.WriteLine("Teraz Wybierz jedno z kilku możliwych działań: ");
            Console.WriteLine("1 --- Dodawanie, ");
            wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Console.WriteLine(dzialania.Dodawanie(liczba1, liczba2));
                    break;
                default:
                    Console.WriteLine("Chwilowo trwają prace konserwacyjne");
                    break;
            }
            Console.ReadKey();
        }
    }
}
