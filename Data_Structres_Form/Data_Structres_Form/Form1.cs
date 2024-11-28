using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structres_Form
{
    /*  Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 99%

        1) I was reminded on how to use multiple forms in c#.  2) I learned how to combine elements from the Crossbar and Graphics assignments

        I believe that 99% is reasonable because the code meets the expectations put forth and does so in an organized and readable manner
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

    public partial class Form1 : Form
    {
        public Cars c1, c2, c3, c4;// Declares instances of Cars with labells c1, c2, and c3

        public Form1()
        {
            InitializeComponent();// Runs the program
        }

        public void onLode(object sender, EventArgs e)// Declares the method onLode with the object sender and the event argument e
        {
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

            CarNames.Items.Add(c1.brand + " " + c1.model + ", " + c1.year + ", " + c1.MSRP + ", " + c1.tirenum + ", " + c1.doornum + ", " + c1.seats);
            CarNames.Items.Add(c2.brand + " " + c2.model + ", " + c2.year + ", " + c2.MSRP + ", " + c2.tirenum + ", " + c2.doornum + ", " + c2.seats);
            CarNames.Items.Add(c3.brand + " " + c3.model + ", " + c3.year + ", " + c3.MSRP + ", " + c3.tirenum + ", " + c3.doornum + ", " + c3.seats);
            // Sets the first 3 items in the combobox to be c1-3's values

        }

        public void Shave(object sender, EventArgs e)// Creates the method Shave
        {
            CarNames.Items.Clear();
            CarNames.Text = "";
            // Removes all the values from the combobox

            MessageBox.Show("Clear successful");// Notifies the user that their files have successfully cleared
        }

        private void Change(object sender, EventArgs e)// Creates the method Change
        {
            string s1;// Declares string s1

            if (e == null)// Checks if there is an event
                s1 = (string)sender;// Casts the sender as a string for s1
            else// If there is an event, the following happens
                s1 = ((ComboBox)sender).Text;// Sets s1 to the text in the ComboBox


            string[] sar// Declares a string array designated sar
                = CarNames.Text.Split(',');// Splits the text in the combobox by the commas

            name.Text = sar[0];
            yer.Text = sar[1];
            price.Text = sar[2];
            tre.Text = sar[3];
            drs.Text = sar[4];
            sets.Text = sar[5];
            // Displays the given values in their respective textboxes
        }

        private void Files(object sender, EventArgs e)// Declares the method Files for user-added cars
        {
            Form2 f2 = new Form2(this);// Loads Form2 as f2
            f2.ShowDialog();// Converts f2 to a dialog box

            if (c4.brand != "" && c4.model != "")// Checks that c4 has values before proceeding
            {
                CarNames.Items.Add(c4.brand + " " + c4.model + ", " + c4.year + ", " + c4.MSRP + ", " + c4.tirenum + ", " + c4.doornum + ", " + c4.seats);// Adds c4's values to the combobox
            }
        }
        private void Close(object sender, EventArgs e)// Generates a method in case the close button is pressed
        {
            this.Close();// Tells the program to close
        }
    }
}
