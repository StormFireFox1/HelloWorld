using System;

/* "Odd number check (now with classes!)
 *
 * Ah, C#. The little child of Microsoft.
 *
 * Honestly, I've never been a fan of C#. Might be because I am used to structural programming in C and can't get out of the habit.
 * Overall, I have used C# for maybe a couple of projects. I have mostly done it because I was too lazy to code a good-looking UI
 * and used Visual Studio for it. Since C# was mostly default and mostly C, I was like "eh".
 *
 * I've since left it to rot in the back of my mind since Java does the OOP part better, and because I actually have the right mentality
 * there when it comes to OOP, compared to C#.
 *
 * This is an over-compartmentalized version of the odd number check. Same as even number check in C++, but with *way* too many objects.
 * I like how clinical I was with this, honestly. Probably more than with the other C# projects I have.
 *
 */

namespace isOdd
{
    class parityChecker
    {
        public int numberToCheck;
        public bool parity {get; set;}

        public void setNumber(int x) {
            numberToCheck = x;
        }

        public int getNumber() {
            return numberToCheck;
        }

        public bool isOdd() {
            if (numberToCheck % 2 == 1)
            {
                parity = true;
            } else {
                parity = false;
            }
            return parity;
        }
        
        public parityChecker()
        {
            parity = true;
            numberToCheck = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            parityChecker check = new parityChecker();
            Console.WriteLine("Gimme an odd number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            check.setNumber(x);
            if (check.isOdd())
            {
                Console.WriteLine("That's an odd number! Well done!");
            } else {
                Console.WriteLine("You donut, that isn't odd. What are you doing with your life?");
            }
        }
    }
}