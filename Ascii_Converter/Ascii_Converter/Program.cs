using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascii_Converter
{
    class Program
    {
        static void Main(string[] args)
        /* Damian Attia-Barillas
         Did this program compile? Yes
         Did this program run as expected? Yes
         Mark that you think you deserve. 100%

         1) I learned about the Encoding command. 2) I was reminded about various commands in c#, and had to re-learn a couple of them

         I believe that 100% is reasonable because the program meets most of the requirements laid out for the assignment, has thorough comments, and is made as user-friendy as possible
         */
        {
            bool b1 // Declares a boolean called b1
                = false; // Assigns b1 a false, or 0, value
            int i1, length; // Declares integers with designations i1 and length
            string s1, s2; // Declares two strings; one with the designation s1, and the other s2

            while // Loops the following code so long as a condition is met
                (b1 == false) // Sets the condition for the loop, the condition being that b1 is false
            {
                Console.WriteLine // Calls the Console to display something
               ("Please enter something to convert into ascii"); // Sets the characters between the quotations to be displayed

                s1 = Console.ReadLine(); // Assigns s1 a value according to an input from the user
                length = s1.Length; // Obtains the number of characters in s1 and assigns that value to length
                byte[] ba // Declares a byte array labelled ba
                    = Encoding.ASCII.GetBytes(s1); // Converts the characters in s1 into ascii values and assigns them to individual bytes in ba

                for // Creates a loop that sustains itself for as long as the following integer meets the conditions
                    (i1 = 0; i1 < length - 1; i1++) // States the condition that i1 starts at 0 and so long as its value does not go beyond that of the integer length, it increases by 1 after the following code is executed
                {
                    Console.Write(ba[i1] + ", "); // Displays the current value of ba, followed by a comma and a space
                }
                if (i1 == length - 1) // Ensures that the following code only executes if there's only one value left in ba
                {
                    Console.WriteLine(ba[i1]); // Displays the last value in ba
                    Console.WriteLine(); // Generates a blank line
                }

                Console.WriteLine("Here are your ascii values, would you like to convert more?"); // Notifies the user that their text has been successfully converted and asks if they wish to continue

                s2 = Console.ReadLine(); // Assigns a value to s2 according to the user's input
                if // Checks to see whether or not the following round bracket contains a true value. The code that follows them is skipped if they return false
                    (s2 != "Yes")  // Returns a "true" value if s2 is "Yes", anything else will return false
                if // If the previous if statement returned false, checks to see if the following argument is true
                    (s2 != "yes") // Returns a "true" value if s2 is "yes", anything else will return false
                    b1 = true; // Changes b1 to be true, ending the loop
                
                Console.WriteLine(); // Generates a blank line
            }
            Console.WriteLine("Goodbye then, press any key to close"); // Bids the user farewell and prompts them to close the application
            Console.ReadKey(); // Waits for the user to press a key before closing
        }
    }
}
