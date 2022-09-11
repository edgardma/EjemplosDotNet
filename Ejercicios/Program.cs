using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge0.FizzBuzz();
            //Console.WriteLine(Challenge1.IsAnagrama("123456", "654321"));
            //Console.WriteLine(Challenge1.IsAnagrama("amor", "Roma"));
            //Console.WriteLine(Challenge1.IsAnagrama("prueba", "Prueba"));

            //Challenge2.Fibonacci();
            //Challenge3.PrintFirst100PrimeNumbers();

            //Challenge4.Area(new Triangle(10.0, 5.0));
            //Challenge4.Area(new Rectangle(5.0, 7.0));
            //Challenge4.Area(new Square(4.0));

            Console.WriteLine(Challenge6.Reverse("Hola mundo"));
            Console.WriteLine(Challenge6.RecursiveReverse("Hola mundo"));
        }
    }
}