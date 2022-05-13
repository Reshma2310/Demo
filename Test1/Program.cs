// See https://aka.ms/new-console-template for more information
using System;

namespace Test1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            y = Convert.ToInt32(Console.ReadLine());

            Addition2No addition = new Addition2No();
            z = addition.add(x, y);
            Console.WriteLine("Addition of two numbers is " + z);
        }
    }
}
