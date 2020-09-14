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
            Console.Clear();
            Console.WriteLine("Liczba druga to: ");
            string liczbaWprowadzona2 = Console.ReadLine();
            Console.Clear();
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
                    Console.Clear();
                    Console.WriteLine("Brawo, Twoje liczby to {0}, {1}", liczba1, liczba2);
                }
                else
                {
                    Console.WriteLine("Liczby nie są nieprawidłowe, wprowadź je jeszcze raz: ");
                }
            }

            
            int wybor = 0;
            Dzialania dzialania = new Dzialania(liczba1, liczba2);
            do
            {
                Console.WriteLine("Teraz Wybierz jedno z kilku możliwych działań, jeśli chcesz opóścić program proszę wybierz 6 --- Wyjście ");
                Console.WriteLine("1 --- Dodawanie, ");
                Console.WriteLine("2 --- Odejmowanie, ");
                Console.WriteLine("3 --- Mnożenie, ");
                Console.WriteLine("4 --- Dzielenie, ");
                Console.WriteLine("6 --- Wyjście");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.WriteLine(dzialania.Dodawanie(liczba1, liczba2));
                        break;
                    case 2:
                        Console.WriteLine(dzialania.Odejmowanie(liczba1, liczba2));
                        break;
                    case 3:
                        Console.WriteLine(dzialania.Mnozenie(liczba1, liczba2));
                        break;
                    case 4:
                        if (liczba2 == 0)
                        {
                            Console.WriteLine("Nie mozna dzielic przez zero!");
                        }
                        else
                        {
                            Console.WriteLine(dzialania.Dzielenie(liczba1, liczba2));
                        }
                        break;
                    default:
                        Console.WriteLine("Chwilowo trwają prace konserwacyjne");
                        break;
                }
            } while (wybor != 6);

            Console.ReadKey();
        }
    }
}
