using System;
using System.Globalization;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string first, last;
              Console.WriteLine("Hello World!!!");
              Console.WriteLine("My Firs console program");
              Console.WriteLine("Enter your name: ");
              first = Console.ReadLine();
              Console.WriteLine("Enter  your last name");
              last = Console.ReadLine();
              Hello hello = new Hello();
              Console.WriteLine(hello.name(first, last));
              Console.WriteLine("End Hello ---------------");
            */
            ValuesTypes valuesTypes = new ValuesTypes();
            valuesTypes.Mutable();
            Console.WriteLine("End valuesTypes ---------------");

            IntegralNumericTypes integralNumericTypes = new IntegralNumericTypes();

            EnumConversionExample enumConversionExample = new EnumConversionExample();
            enumConversionExample.sesonConverter();

            StructWithoutNew structWithoutNew = new StructWithoutNew();
            structWithoutNew.initializer();
            int montlyWage = 0;
            int monts = 12;
            var bonus = 1000;

            bool isActive = true;
            double raiting = 99.25;
            var ratePerHour = 12.34;
            var numberOfHoursWorked = 100;

            var currentMonthWage = (ratePerHour * numberOfHoursWorked) + bonus;

            Console.WriteLine(currentMonthWage);

            Console.WriteLine($"intMinValue {int.MinValue}");
            Console.WriteLine($"intMinValue {int.MaxValue}");
            Console.WriteLine($"doubleMinValue {double.MinValue}");
            Console.WriteLine($"doubleMinValue {double.MaxValue}");

            char myChar = 'a';
            Console.WriteLine(char.IsWhiteSpace(myChar));
            Console.WriteLine(char.IsDigit(myChar));
            Console.WriteLine(char.IsPunctuation(myChar));
            Console.WriteLine(char.ToUpper(myChar));

            //Working with datetime
            DateTime birthDate = new DateTime(1981, 07, 27, 23, 25, 59);
            DateTime someDateTime2 = new DateTime(1981, 07, 27, new GregorianCalendar());
            DateTime today = DateTime.Today;
            DateTime twoDaysLater = today.AddDays(2);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            DayOfWeek dayName = birthDate.DayOfWeek;

            Console.WriteLine(birthDate.ToString());
            Console.WriteLine(someDateTime2.ToString());


            string format = "{MM/dd/yyyy hh:mm:ss tt}";

            Console.WriteLine(birthDate.ToString());
            Console.WriteLine($"Today is: {today.ToLongDateString()}");
            Console.WriteLine($"Today is: {today.CompareTo(today)}");
            Console.WriteLine($"DateTime.Now: {DateTime.Now}");
            Console.WriteLine($"twoDaysLater: { twoDaysLater}");
            Console.WriteLine($"BirthDay day: { dayName}");
            Console.WriteLine(birthDate.IsDaylightSavingTime());





        }
    }
}
