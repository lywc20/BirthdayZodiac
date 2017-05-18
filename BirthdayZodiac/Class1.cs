using System;
//using System.Diagnostics.Tracing;
//using System.Runtime.Serialization.Formatters;

namespace BirthdayZodiac
{//class for birth_day//
    public class Class1
    {
        private string _identity;
        private int _month;
        private int _day;

        public void Input()
        {
            if ((_month == 03 & (_day >= 21 || _day < 31)) || (_month == 04 & (_day >= 1 || _day <= 19)))
            {
                Console.WriteLine(_identity + " is an aries");
            }
            else if ((_month == 04 & (_day >= 20 || _day < 31)) || (_month == 05 & (_day >= 1 || _day <= 20)))
            {
                Console.WriteLine(_identity + " isa taurus");
            }
            else if ((_month == 05 & (_day >= 21 || _day < 31)) || (_month == 06 & (_day >= 1 || _day <= 20)))
            {
                Console.WriteLine(_identity + " is a gemini");

            }
            else if ((_month == 06 & (_day >= 20 || _day < 31)) || (_month == 07 & (_day >= 1 || _day <= 22)))
            {
                Console.WriteLine(_identity + " is a cancer");
            }
            else if ((_month == 07 & (_day >= 23 || _day < 31)) || (_month == 08 & (_day >= 1 || _day <= 22)))
            {
                Console.WriteLine(_identity + " is a leo");
            }
            else if ((_month == 08 & (_day >= 23 || _day < 31)) || (_month == 09 & (_day >= 1 || _day <= 22)))
            {
                Console.WriteLine(_identity + " is a virgo");
            }
            else if ((_month == 09 & (_day >= 23 || _day < 31)) || (_month == 10 & (_day >= 1 || _day <= 22)))
            {
                Console.WriteLine(_identity + " is a libra");
            }
            else if ((_month == 10 & (_day >= 23 || _day < 31)) || (_month == 11 & (_day >= 1 || _day <= 21)))
            {
                Console.WriteLine(_identity + " is a scorpio");
            }
            else if ((_month == 11 & (_day >= 22 || _day < 31)) || (_month == 12 & (_day >= 1 || _day <= 22)))
            {
                Console.WriteLine(_identity + " is a sagittarius");
            }
            else if ((_month == 12 & (_day >= 22 || _day < 31)) || (_month == 01 & (_day >= 1 || _day <= 19)))
            {
                Console.WriteLine(_identity + " is a capricorn");
            }
            else if ((_month == 01 & (_day >= 20 || _day < 31)) || (_month == 02 & (_day >= 1 || _day <= 18)))
            {
                Console.WriteLine(_identity + " is a aquarius");
            }
            else if ((_month == 02 & (_day >= 19 || _day < 31)) || (_month == 03 & (_day >= 1 || _day <= 20)))
            {
                Console.WriteLine(_identity + " is a pisces");
            }
        }

        public void Initialize()
        {
            var i = "";
            Console.WriteLine("Enter your name: ");
            i = Console.ReadLine();
            _identity = i;
            Console.WriteLine("Enter numerical _month: ");
            i = Console.ReadLine();
            _month = int.Parse(i);
            Console.WriteLine("Enter numrical _day: ");
            i = Console.ReadLine();
            _day = int.Parse(i);
        }
    }


}