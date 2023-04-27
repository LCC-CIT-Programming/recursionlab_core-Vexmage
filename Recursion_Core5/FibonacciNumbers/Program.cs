/*
 * Joel Southall
 * April 27, 2023
 * Lab 3 -  FibonacciNumbers
 * 
 * THE FIBONACCI SEQUENCE:
 * 
 * F(0) = 0
 * F(1) = 1
 * F(n) = F(n-1) + F(n-2) for n > 1
 *
 * So the first few terms of the sequence are: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
 * 
 * 
 * PSUEDOCODE
 * 
 * Main method uses for loop to display first 10 numbers,
 * calling the FibonacciNumber method with each iteration.
 * The FibonacciNumber base case is n == 0 || 1
 *      which returns n
 * The recursive case is n > 1
 *      which returns sum of (n-1) and (n-2)
 */


using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("F_" + i + " = " + FibonacciNumber(i));
            }
        }

        static int FibonacciNumber(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
            }
        }
    }
}
