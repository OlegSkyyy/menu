using System;
using System.Dynamic;

namespace menu // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести A (1)\nВвести B (2)\nвыполнить операцию “+” (3)\nвыполнить операцию “-” (4)\nвыполнить операцию “*” (5)\nвыполнить операцию “/” (6)");
            string v;
            v = Console.ReadLine();
            int a = 0; int b = 0;
            switch (v)
            {
                case "1":
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case "2":
                    {
                        b = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine(a + b);
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine(a - b);
                    }
                    break;
                case "5":
                    {

                    }
                    break;
                case "6":
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
            }
        }
    }
}