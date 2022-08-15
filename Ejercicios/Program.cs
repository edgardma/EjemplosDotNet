using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge0.FizzBuzz();
            Console.WriteLine(Challenge1.IsAnagrama("123456", "654321"));
        }
    }
}



// See https://aka.ms/new-console-template for more information
/*
fizzBuzz();

void fizzBuzz() 
{
    for (int index=1; index <= 100; index++)
    {
        bool divisibleByTree = index % 3 == 0;
        bool divisibleByFive = index % 5 == 0;

        if (divisibleByTree && divisibleByFive)
        {
            Console.WriteLine("fizzbuzz");
        } else if (divisibleByTree) {
            Console.WriteLine("fizz");
        } else if (divisibleByFive) {
            Console.WriteLine("buzz");
        } else {
            Console.WriteLine(index);
        }
    }
}
*/