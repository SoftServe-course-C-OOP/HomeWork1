﻿using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tHomeWork 1");
            Console.WriteLine();
            Console.WriteLine("\tPart 1");
            Console.WriteLine();
            Console.Write("Enter lehgth of square:\t");
            bool success1 = int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine($"Area = { a * a }");
            Console.WriteLine($"Perimeter = { a * 4 }");
            Console.WriteLine("For next step type Enter");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("\tPart 2");
            Console.WriteLine();
            Console.Write("What is your name?\t");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, { name }?");
            bool success2 = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine($"{ name }, you are { age } years old!");
            Console.WriteLine("For next step type Enter");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\tPart 1");
            Console.WriteLine();
            Console.Write("Enter lehgth of square:\t");
            bool success1 = int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine($"Area = {a * a}");
            Console.WriteLine($"Perimeter = {a * 4}");
            Console.WriteLine("For next step type Enter");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
