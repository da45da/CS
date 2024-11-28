using System;
/* Damian Attia-Barillas
Did this program compile? Yes
Did this program run as expected? Yes
Mark that you think you deserve. 98%

From this activity, I learned how to create objects and how to use them. Additionally, I learned a more efficient way to TryParse when I want to use a while loop.

I believe that a 98% is reasonable because I believe that I have explained each line of code to the fullest of its purpose, but I am still open to the idea that there is more to learn.
 */

namespace Classes// The name of the file; how my computer recognises it
{
    class Program// Creates a class called Program
    {
        static void Main(string[] args)// The main method of the code; required for the code to execute
        {
            int i1, i2, i3;// Declares integers i1, i1, and i3
            Mathematics obj = new Mathematics();// Tells the program to create an object for the class Mathematics called obj and to call the method of the same name as its purpose
            i1 = obj.Getint();// Tells the program to use an object Mathematics' function Getint to get an integer for i1
            i2 = obj.Getint();// Tells the program to use an object Mathematics' function Getint to get an integer for i2
            i3 = obj.Getint();// Tells the program to use the object Mathematics' function Getint to get an integer for i3
            Console.WriteLine(i1 + " * " + i2 + " * " + i3 + " = " + i1 * i2 * i3);// Tells the user the 3 integers they inputted, as well as their product
            Console.ReadLine();// Tells the program to wait for the user to write a line of characters before closing
        }
    }

    class Mathematics// Creates a class called mathematics
    {
        int i1, i2;// Declares integers i1 and i2 for this class
        public Mathematics()// Creates a mathod called Mathematics that can be called from anywhere due to the access modifier public
        {
            i1 = i2 = 0;// Sets both i1 and i2 equal to 0
        }
        public int Getint()// Creates anther method; this one tasked with returning an int
        {
            int ret;// Declares integer ret
            Console.WriteLine("Please enter an integer");// Prompts the user to enter an integer
            string s1 = Console.ReadLine();// Creates string s1 and has it become equal to an input from the user
            while (!int.TryParse(s1, out ret))// Creates a loop. Takes the value the user assigned to s1 and tries to convert it into an integer. So long as a non-integer is inputted, the following code block will execute. If an integer is inputted, the loop will break.
            {
                Console.WriteLine("Error, not an integer, try again");// Tells the user that a non-integer has been detected and to try again
                s1 = Console.ReadLine();// Resets the loop
            }
            return ret;// Returns the value of integer ret to the console
        }
    }
}
