using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_calculator
{
    /*  Damian Attia-Barillas
       Did this program compile? Yes
       Did this program run as expected? Yes
       Mark that you think you deserve. 99%

       1) I learned how to fix the error the old calculator had when trying to do exponents greater than 2

       I believe that 99% is reasonable because I have successfully rebuilt/reunderstood my old calculator, addressed some issues from the original code, and cleaned up the comments to make the file more readable
    */
    public partial class Form1 : Form// Declares a class for the program
    {
        public Form1()// Declares method Form1
        {
            InitializeComponent();// Starts up the calculator window
        }
        private void Form1_Load(object sender, EventArgs e)// Declares the private method Form1_Load with sender an an object and the event handler e
        {

        }

        bool stat;// Declares boolean stat
        double d1, d2;// Declares doubles d1 and d2
        byte by1;// Declares byte by1
        string v;// Declares string v

        private void Onclick(object sender, EventArgs e)// Declares the private method Onclick
        {
            if (e == null)// If the user did not click a button, the following happens
                v = (string)sender;// Makes v equal to the sender's value as a string
            else// If the user clicked a button, the following happens
                v = ((Button)sender).Text;// Makes v equal to the sender's value as a string
            if (stat == true)// Checks if stat is true
            {
                Display.Text = null;// Resets the display
                stat = false;// Assigns's stat a false, or 0, value
            }
            Display.Text += v;// Adds the value of v to the Diplay
        }

        private void opp_Click(object sender, EventArgs e)// Declares the private method opp_Click
        {
            if (e == null)
                v = (string)sender;
            else
                v = ((Button)sender).Text;
            double.TryParse(Display.Text, out d1);// Takes the text currently on the display and converts it to a double

            switch // Declares a switch
                (by1)// Sets the value of by1 as the condition for the switch
            {
                case 1:// If by1 = 1, the following happens
                    d1 = d2 += d1;// Adds d1 to d2 and makes d1 equal to their sum
                    break;// Ends the current case

                case 2:// Checks if by1 = 2
                    d1 = d2 -= d1;// Subtracts d1 from d2 
                    break;

                case 3:// Checks if by1 = 3
                    d1 = d2 /= d1;// Divides d1 and d2 
                    break;

                case 4:// Checks if by1 = 4
                    d1 = d2 *= d1;// Multiplies d1 and d2 
                    break;

                case 5:// Checks if by1 = 5
                    d1 = (Math.Pow(d2, d1));// Finds d2 to the power of d1
                    break;

                case 6:// Checks if by1 = 6
                    d1 = (Math.Sqrt(d1));// Finds the square root of d1
                    break;

                case 7:// Checks if by1 = 7
                    d1 = d1 * -1;// d1 is multiplied by -1, flipping it's sign very time the button is pressed
                    break;
            }

            by1 = (byte)((v == "+") ? 1 :// Creates a conditional if statement for the value of by1 using v's text and sets + to become 1
                   (v == "-") ? 2 :// If v holds a -, by1 will equal 2
                   (v == "/") ? 3 :// If v = /, by1 = 3
                   (v == "X") ? 4 :// If v = X, by1 = 4
                   (v == "x") ? 4 :// If v = x, by1 = 4
                   (v == "*") ? 4 :// If v = *, by1 = 4
                   (v == "^") ? 5 :// If v = ^, by1 = 5
                   (v == "√") ? 6 :// If v = √, by1 = 6
                   (v == "+-") ? 7 :// If v = +-, by1 = 7
                   0);// Makes by1 0 if none of the above are detected

            d2 = d1;// Makes d2 equal to d1
            Display.Text = null;
            Display.Text += d2;// Adds d1's value to the display
            stat = true;// Sets stat to true

            if (v == "C")// If v is C, the following will happen
            {
                by1 = 0;// Sets by1 to 0
                Display.Text = null;
                stat = false;
            }
        }

        public void sign_Click(object sender, EventArgs e)// Declares the public method sign_Click
        {
            Button b2 = (Button)sender;// Casts sender as a button for use in the declared button b2
            Display.Text += b2.Text;// Adds b2's text to the display
        }


        private void Type(object sender, KeyPressEventArgs e)// Declares the private method Type
        {
            string av = e.KeyChar.ToString();// Declares string av and makes it the pressed key's text

                if (char.IsNumber(e.KeyChar))// If isNum is true, the following happens
                    Onclick(av, null);// Invokes the method Onclick with the string av and no event handler
                else// Otherwise, the following happens
                    opp_Click(av, null);// Invokes the method opp_Click
            
            Display.SelectionStart = Display.SelectionLength = 0;// Prevents the user from accidentally highlighting the Display
            Display.Focus();// Tells the program to focus on the Diaplay
        }

        private void Ende(object sender, EventArgs e)// Declares the private method Ende 
        {
            this.Close();// Closes the program
        }
    }
}
