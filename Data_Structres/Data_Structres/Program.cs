using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structres
{
    /*  Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 99%

        1) Declaring a data structre is different from, but similar to, declaring a class  2) Data structres can be repurposed multiple times, unlike arrays

        I believe that 99% is reasonable because the requirements for the assignment are met, there are detailed comments where the need arises, and the code is neatly organised
    */
    public struct Cars// Declares a public data structre designated Cars
    {
        public string brand;
        public string model;
        public int year;
        public int MSRP;
        public byte tirenum;
        public byte doornum;
        public byte seats;
        // Declares several variables within the structre
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars c1, c2, c3;// Declares instances of Cars with labells c1, c2, and c3

            c1.brand = "Ford";// Assigns Ford to c1's instance of brand
            c1.model = "Fusion";// Assigns Ford to c1's brand
            c1.year = 2009;// Sets c1's year to 2009
            c1.MSRP = 20000;// Sets c1's MSRP to 20000
            c1.tirenum = 4;// Sets c1's tirenum to 4
            c1.doornum = 4;// Sets c1's doornum to 4
            c1.seats = 5;// Sets c1's seats to 4

            c2 = c1;// Sets c2's values to match c1's

            c2.model = "Focus Coupe";// Changes the value for c2's model to Focus Coupe
            c2.MSRP = 17000;// Changes the value for c2's MSRP to 17,000
            c2.doornum = 2;// Changes the value for c2's doornum to 2

             c3 = c2;// Sets c3's values to equal c2's

            c3.brand = "Chevrolet";
            c3.model = "P.T. Cruiser";
            c3.year = 2010;
            c3.MSRP = 4675;
            c3.doornum = 4;
            // Changes c3's variables to match with the 2010 P.T. Cruiser

            Console.WriteLine("The following are cars and some of their specs\n");// Pretenses the following
            Console.WriteLine(c1.brand + " " + c1.model);// Displays the brand and model values for c1
            Console.WriteLine("Year: " + c1.year + "  MSRP: " + c1.MSRP + "  Number of tires: " + c1.tirenum + " Number of doors: " + c1.doornum + " Seats: " + c1.seats + "\n");// Displays the rest of the variables in c1

            Console.WriteLine(c2.brand + " " + c2.model);// Tells the user that c2's variables are displayed below
            Console.WriteLine("Year: " + c2.year + "  MSRP: " + c2.MSRP + "  Number of tires: " + c2.tirenum + " Number of doors: " + c2.doornum + " Seats: " + c2.seats + "\n");

            Console.WriteLine(c3.brand + " " + c3.model);// Tells the user that c3's variables are displayed below
            Console.WriteLine("Year: " + c3.year + "  MSRP: " + c3.MSRP + "  Number of tires: " + c3.tirenum + " Number of doors: " + c3.doornum + " Seats: " + c3.seats);

            Console.ReadKey();// Waits for user input before closing
        }
    }
}
