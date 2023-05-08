using System;

namespace Mulitplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply");

            // Prompt the user to choose an algorithm
            Console.WriteLine("Choose an algorithm: ");
            Console.WriteLine("1. Iterative");
            Console.WriteLine("2. Recursive");
            int choice = int.Parse(Console.ReadLine());

            // Perform multiplication using the chosen algorithm
            if (choice == 1)
            {
                for (int n = 1; n <= 10; n++)
                    Console.WriteLine(String.Format("5 * {0,2} is {1,2}", n, MultiplyIterative(5, n)));
                    Console.WriteLine();

                    Console.WriteLine("Now for some real fun!");
                    Console.WriteLine(String.Format("5 * {0,2} is {1,2}", 0, MultiplyIterative(5, 0)));
                    Console.WriteLine();
            }
            else if (choice == 2)
            {
                for (int n = 1; n <= 10; n++)
                    Console.WriteLine(String.Format("5 * {0,2} is {1,2}", n, MultiplyRecursive(5, n)));
                Console.WriteLine();

                Console.WriteLine("Now for some real fun!");
                Console.WriteLine(String.Format("5 * {0,2} is {1,2}", 0, MultiplyRecursive(5, 0)));
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static int MultiplyIterative(int x, int y)
        {
            int result = 0;
            for (int i = 0; i < y; i++)
            {
                result += x;
            }
            return result;
        }

        static int MultiplyRecursive(int x, int y)
        {
            if (y == 1)
                return x;
            else
                return x + MultiplyRecursive(x, y - 1);
        }
    }
}
