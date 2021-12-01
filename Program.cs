using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last;
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("My Firs console program");
            Console.WriteLine("Enter your name: ");
            first = Console.ReadLine();
            Console.WriteLine("Enter  your last name");
            last = Console.ReadLine();

            Hello hello = new Hello();

            Console.WriteLine(hello.name(first, last));


        }
    }
}
