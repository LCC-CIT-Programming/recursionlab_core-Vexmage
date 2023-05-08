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
 * The recursive case for the Palindrome program is to check if the first and last characters
 * of the string are the same. If they are, then the function should call itself 
 * recursively with the substring of the original string that excludes 
 * the first and last characters.
 * User Input is a word or phrase entered.
 * Output is whether or not the input is a palindrome. 
 * 
 * PSUEDOCODE FOR ADDED CALCULATION OF MULTIPLE PHRASES AND PLAYAGAIN FEATURE
 * 1. Prompt the user to enter words and phrases to evaluate (separated by commas)
 * 2. Split the input string into array of strings using comma as a delimiter
 * 3. For each string in the array, check if palindrome using the IsPalindrome function
 * 4. Print a message indicating whether each string is a palindrome or not
 * 5. Ask the user if they want to play again
 * 6. If yes, go to step 1; if no, exit the program
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
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Enter one or more words or phrases (separated by commas):");
                string input = Console.ReadLine();

                string[] texts = input.Split(',');

                foreach (string text in texts)
                {
                    string cleanText = new string(text.ToLower().ToCharArray()
                                                    .Where(c => Char.IsLetterOrDigit(c))
                                                    .ToArray());

                    if (IsPalindrome(cleanText))
                    {
                        Console.WriteLine("The text \"" + text + "\" is a palindrome!");
                    }
                    else
                    {
                        Console.WriteLine("The text \"" + text + "\" is not a palindrome.");
                    }
                }

                Console.Write("Play again? (Y/N): ");
                string answer = Console.ReadLine().ToUpper();
                playAgain = (answer == "Y");
            }
        }

        static bool IsPalindrome(string s)
        {
            // Base case: if the string is empty or has one character, it's a palindrome
            if (s.Length < 2)
            {
                return true;
            }
            // Recursive case
            else
            {
                if (s[0] == s[s.Length - 1])
                {
                    return IsPalindrome(s.Substring(1, s.Length - 2));
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
