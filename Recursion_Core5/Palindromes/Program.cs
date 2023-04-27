/*
 * Joel Southall
 * April 27, 2023
 * 
 * 
 * Recursive method IsPalindrome to mark if string is true or false
 * Will need to remove whitespace, punctuation and capitalization
 * Base case is going to be if length of the string is 0 or 1, which is true.
 * Compare last and first characters of string. If not equal then IsPalindrome = false.
 * IsPalindrom method should be called recursively.
 * User Input is a word or phrase entered.
 * Output is whether or not the input is a palindrome. 
 * 
 */

using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word or phrase: ");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine("The text is a palindrome!");
            }
            else
            {
                Console.WriteLine("The text is not a palindrome.");
            }

            Console.ReadLine();
        }

        static bool IsPalindrome(string s)
        {
            // Base case: if the string is empty or has one character, it's a palindrome
            if (s.Length < 2)
            {
                return true;
            }
            // To do, recursive case
            else
            {
                return false;
            }
        }
    }
}