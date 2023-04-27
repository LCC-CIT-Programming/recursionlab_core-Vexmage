/*
 * Joel Southall
 * April 27, 2023
 * Lab 3 - Triangular Numbers
 * 
 * PSUEDOCODE
 * Main:
 *  for i from 1 to 10:
 *      print TriangularNumber(i)
 *
 * TriangularNumber(n):
 *     if n == 1:
 *         return 1
 *     else:
 *         return n + TriangularNumber(n-1)
 *         
 * NOTE:
 * Was able to convert code I wrote for a C++ Recursion program
 */


using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("T_" + i + " = " + TriangularNumber(i));
            }
        }

        // Declare the TriangularNumber method, which takes an integer n and returns an integer
        static int TriangularNumber(int n)
        {
            // If n is 1, return 1
            if (n == 1)
            {
                return 1;
            }
            // Otherwise, return the sum of n and the (n-1)th triangular number
            else
            {
                return n + TriangularNumber(n - 1);
            }
        }
    }
}
