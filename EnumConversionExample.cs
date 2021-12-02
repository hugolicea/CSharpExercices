using System;
namespace Exercices
{
    public class EnumConversionExample
    {
        public EnumConversionExample() { }
        public void sesonConverter()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}"); // output: Integral value of Autumn is 2
            var b = (Season)1;
            Console.WriteLine(b); // output: Summer
            var c = (Season)4;
            Console.WriteLine(c); // output: 4
        }
    }
}