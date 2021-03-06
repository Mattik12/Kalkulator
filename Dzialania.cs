﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    public class Dzialania
    {
        public double Number1 { get; private set; }

        public double Number2 { get; private set; }

        public double Wynik { get;  set; }

        public Dzialania()
        {
            this.Number1 = 0;
            this.Number2 = 0;
            this.Wynik = 0;
        }

        public Dzialania(double number1, double number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public double Dodawanie(double number1, double number2)
        {
            this.Wynik = number1 + number2;
            return this.Wynik;
        }

        public double Odejmowanie(double number1, double number2)
        {
            this.Wynik = number1 - number2;
            return this.Wynik;
        }

        public double Mnozenie(double number1, double number2)
        {
            this.Wynik = number1 * number2;
            return this.Wynik;
        }

        public double Dzielenie(double number1, double number2)
        {
            this.Wynik = number1 / number2;
            return this.Wynik;
        }
    }
}
