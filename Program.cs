using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string first, last;
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
        }
    }
}
