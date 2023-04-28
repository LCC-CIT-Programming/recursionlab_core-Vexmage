/*
 * 
 * Joel Southall
 * CS 162N
 * April 27, 2023
 * Towers of Hanoi
 * 
 * Base case: T(1) = 1
 * Recursive case: T(n) = 2T(n-1) + 1
 * 
PSEUDOCODE FOR MY ORIGINAL C++ PROGRAM:
function moveDisks(n, start, end, temp):
    if n == 1:
        // Base case: if there is only one disk to move, simply move it from the 'start' peg to the 'end' peg
        print "Move disk 1 from peg " + start + " to peg " + end
    else:
        // Recursive case: move the top 'n-1' disks from the 'start' peg to the 'temp' peg using the 'end' peg as temporary storage
        moveDisks(n - 1, start, temp, end)
        // Move the 'n'th disk from the 'start' peg to the 'end' peg
        print "Move disk " + n + " from peg " + start + " to peg " + end
        // Move the 'n-1' disks from the 'temp' peg to the 'end' peg using the 'start' peg as temporary storage
        moveDisks(n - 1, temp, end, start)

The function takes four inputs: the number of disks to move (n), the starting peg (start), the ending peg (end), and the temporary peg (temp).
 If n is 1, the function simply moves the disk from the starting peg to the ending peg. Otherwise, it calls itself recursively with n-1 disks,
 moving them from the starting peg to the temporary peg using the ending peg as temporary storage.Then, it moves the nth disk from the starting
 peg to the ending peg. Finally, it calls itself recursively with n-1 disks again, moving them from the temporary peg to the ending peg using
 the starting peg as temporary storage.
*/

using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number of disks from the user
            Console.Write("Enter the number of disks: ");
            int n = int.Parse(Console.ReadLine());
            // Call the moveDisks function to solve the puzzle
            moveDisks(n, 'A', 'C', 'B');
        }

        // Function to move 'n' disks from the 'start' tower to the 'end' tower using the 'temp' tower
        static void moveDisks(int n, char start, char end, char temp)
        {
            // Base case:
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from tower " + start + " to tower " + end);
                return;
            }
            // Recursive case:
            moveDisks(n - 1, start, temp, end);
            // Move the 'n'th disk from the 'start' tower to the 'end' tower
            Console.WriteLine("Move disk " + n + " from tower " + start + " to tower " + end);
            // Move the 'n-1' disks from the 'temp' tower to the 'end' tower using the 'start' tower as temporary storage
            moveDisks(n - 1, temp, end, start);
        }
    }
}