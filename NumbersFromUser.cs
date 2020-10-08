using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    class NumbersFromUser
    {
        private string number;

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public NumbersFromUser()
        {

        }

        public string GetNumberFromUser()
        {
            number = Console.ReadLine();
            return number;
        }
    }
}
