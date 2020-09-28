using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba;
            double number1 = 0;
            double number2 = 0;
            string liczbaWprowadzona1 = "";
            bool zmienna = false;
            NumberValidator validator = new NumberValidator(liczbaWprowadzona1);


            Console.WriteLine("Witaj w kalkulatorze");
            Console.WriteLine("Aby zacząć podaj dwie liczby i wybierz działanie jakie chcesz wykonać");
            Console.WriteLine("Liczba pierwsza to: ");
            liczbaWprowadzona1 = Console.ReadLine();
            zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
            if(zmienna != true)
            {             
                while(zmienna != true)
                {
                    Console.WriteLine("Podana liczba jest nieprawidłowa");
                    Console.WriteLine("Podaj liczbe jeszcze raz: ");
                    liczbaWprowadzona1 = Console.ReadLine();
                    zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                    if(zmienna == true)
                    {
                        number1 = liczba;
                    }
                }        
            }
            else
            {
                number1 = liczba;
            }
            Dzialania dzialania = new Dzialania(number1,number2);
            string znak;
            Console.WriteLine("Wprowadź znak: ");
            znak = Console.ReadLine();
            switch (znak)
            {
                case "+":
                    Console.WriteLine("Liczba Druga to: ");
                    liczbaWprowadzona1 = Console.ReadLine();
                    zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                    if (zmienna != true)
                    {
                        while (zmienna != true)
                        {
                            Console.WriteLine("Podana liczba jest nieprawidłowa");
                            Console.WriteLine("Podaj liczbe jeszcze raz: ");
                            liczbaWprowadzona1 = Console.ReadLine();
                            zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                            if (zmienna == true)
                            {
                                number2 = liczba;
                            }
                        }
                    }
                    else
                    {
                        number2 = liczba;
                    }
                    Console.WriteLine(dzialania.Dodawanie(number1, number2));
                    break;
            }
            double wynik;
            string wybor;
            wynik = dzialania.Wynik;
            Console.WriteLine("Jeśli chcesz kontynuować wybierz \"T\" lub \"N\" jeśli nie chcesz kontynuować");
            wybor = Console.ReadLine();
            if (wybor == "T")
            {
                while (wybor == "T")
                {
                    wynik = dzialania.Wynik;
                    Console.WriteLine("Proszę wybierz działanie: ");
                    znak = Console.ReadLine();
                    switch (znak)
                    {
                        case "+":
                            Console.WriteLine("Liczba Druga to: ");
                            liczbaWprowadzona1 = Console.ReadLine();
                            zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                            if (zmienna != true)
                            {
                                while (zmienna != true)
                                {
                                    Console.WriteLine("Podana liczba jest nieprawidłowa");
                                    Console.WriteLine("Podaj liczbe jeszcze raz: ");
                                    liczbaWprowadzona1 = Console.ReadLine();
                                    zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                                    if (zmienna == true)
                                    {
                                        number2 = liczba;
                                    }
                                }
                            }
                            else
                            {
                                number2 = liczba;
                            }
                            Console.WriteLine(dzialania.Dodawanie(wynik, number2));
                            break;

                        case "-":
                            Console.WriteLine("Liczba Druga to: ");
                            liczbaWprowadzona1 = Console.ReadLine();
                            zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                            if (zmienna != true)
                            {
                                while (zmienna != true)
                                {
                                    Console.WriteLine("Podana liczba jest nieprawidłowa");
                                    Console.WriteLine("Podaj liczbe jeszcze raz: ");
                                    liczbaWprowadzona1 = Console.ReadLine();
                                    zmienna = validator.Validator(liczbaWprowadzona1, out liczba);
                                    if (zmienna == true)
                                    {
                                        number2 = liczba;
                                    }
                                }
                            }
                            else
                            {
                                number2 = liczba;
                            }
                            Console.WriteLine(dzialania.Odejmowanie(wynik, number2));
                            break;
                        case "N":
                            wybor = "N";
                            Console.WriteLine("Koniec działań");
                            break;
                    }
                }
            }
            else Console.WriteLine(dzialania.Wynik);
            Console.ReadKey();
        }
    }
}
