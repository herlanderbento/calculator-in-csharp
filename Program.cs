using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("What do you what to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");


            Console.WriteLine("---------------");
            Console.WriteLine("Select an option: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1 :
                    Sum();
                break;

                case 2 :
                    Division();
                break;

                case 3 :
                    Subtraction();
                break;

                case 4 :
                    Multiplication();
                break;

                case 5 :
                    System.Environment.Exit(0);
                break;

                default: Menu(); break;
            }

        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("First value");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;

            Console.WriteLine($"The result of sum is {result}");
            Console.ReadKey();

            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("First value");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;

            Console.WriteLine($"The result of subtraction is {result}");
            Console.ReadKey();

            Menu();

        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("First value");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;

            Console.WriteLine($"The result of division is {result}");
            Console.ReadKey();

            Menu();

        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First value");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;

            Console.WriteLine($"The result of multiplication is {result}");
            Console.ReadKey();

            Menu();

        }
    }
}
