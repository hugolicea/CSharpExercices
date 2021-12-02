using System;
namespace Exercices
{
    public class IntegralNumericTypes
    {

        public IntegralNumericTypes()
        {
            Console.WriteLine($"int.MinValue = {int.MinValue}");
            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"nint.MinValue = {nint.MinValue}");
            Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
            Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
            Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");

            double a = 1.0;
            decimal b = 2.1m;
            Console.WriteLine(a + (double)b);
            Console.WriteLine((decimal)a + b);
            Console.WriteLine($"double.MinValue = {double.MinValue}");
            Console.WriteLine($"double.MaxValue = {double.MaxValue}");

            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked"); // output: Checked
            Console.WriteLine(!check ? "Checked" : "Not checked"); // output: Not checked

            var chars = new[]{'j','\u006A','\x006A',(char)106,};
            Console.WriteLine(string.Join(" ", chars)); // output: j j j j
        }
    }
}
