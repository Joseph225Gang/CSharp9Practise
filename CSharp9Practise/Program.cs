using System;

namespace CSharp9Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person(28, "Bill");
            var p2 = new Person(28, "Bill");

            Console.WriteLine(object.ReferenceEquals(p1, p2));
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(object.Equals(p1, p2));
            Console.WriteLine(p1 == p2);

            var dog = new Dog() { Age = 12 };

            string? hello = "hello world";

            if (hello is { Length: > 0 })
            {
                Console.WriteLine($"{hello} has {hello.Length} letters.");
            }

            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.KeyChar is 'Y' or 'y')
            {
                Console.WriteLine("Do something.");
            }

            Console.ReadLine();
        }
    }
}
