using System;

using System.Windows.Forms;

namespace New_C_Sharp_Calculatoe
{
    /*  Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 95%

        1) I learned that Sin, Cos, and Tan are as simple as the pow and sqrt functions to implement.  2) I learned about the "trim" objects, "Remove," and "Replace."

        I believe that 95% is reasonable because I have added Sin, Cos, Tan, their inverses, and base 10 exponents. The calculator does not consider order of operations, otherwise it is as good as I can make it

     Note: If you are seeing this version, I likely handed this in as a placeholder if getting BEDMAS functional in time proves too difficult. I do intend to come back and correct this assignment with it fully functional
     */
    public partial class Form1 : Form// Creates a class for the program
    {
        public Form1()// Creates method Form1
        {
            InitializeComponent();// Starts up the calculator window
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool stat;// Declares boolean stat
        bool second// Declares boolean second
            = false;// Sets the initial value of second to false
        double d1, d2;// Declares doubles d1 and d2
        byte by1;// Declares byte by1

        private void Onclick(object sender, EventArgs e)// Creates the private method Onclick with an object called sender and an event handler called e
        {
            string v;// Declares string v
            if (e == null)// If the user did not click a button, the following happens
                v = (string)sender;// Makes v equal to the sender's value as a string
            else// If the user clicked a button, the following happens
                v = ((Button)sender).Text;// Makes v equal to the sender's value as a string
            if (stat == true)// Checks if bool stat is true
            {
                if (by1 != 5)// If by1 is 5, the following does not happen
                    Display.Text = null;// Resets the display
                stat = false;// Makes stat false
            }
            Display.Text += v;// Adds the value of v to the Diplay
        }

        private void opp_Click(object sender, EventArgs e)// Creates the private method opp_Click with an object called sender and an event handler called e
        {
            string v, trim;// Declares strings v and trim
            char[] ca// Declares character array ca
                = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', '-' };// Assignes ca values 0-9 for its first 10 characters, and . and - as well for its 11th and 12th

            if (e == null)
                v = (string)sender;
            else
                v = ((Button)sender).Text;

            trim = Display.Text;// Sets trim's value to that of the Display's text
            if (by1 == 5)// Checks if by1 is 5
            {
                trim = trim.TrimStart// Trims off the first characters in trim according to the following parameters
                    (ca);// Sets the characers to trim based on the characters in the instances of ca

                trim = trim.Remove(0, 1);// Removes the first character from trim
                // Note: Checking if "^" is present would be redundant, as it is added if by1 = 5
            }

            Display.Text = trim;
            double.TryParse(Display.Text, out d1);// Takes the text currently on the display and converts it to a double

            if (v == "+-")// Checks if +- was entered
                d1 *= -1;

            switch (by1)// Creates a switch for the value of by1
            {
                case 1:// If by1 = 1, the following happens
                    d1 = // Assigns d1 a value corresponding to the following parameters
                        d2 += d1;// Adds d1 to d2 and makes d1 equal to their sum
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
                    d1 = (Math.Pow(d2, d1));// Finds the d2 to the power of d1
                    break;

                case 6:/// Checks if by1 = 6
                    d1 = (Math.Sqrt(d1));// Finds the square root of d1
                    break;

                case 8:// Checks if by1 = 8
                    if (second != true)// Unless second is false, the following line is skipped
                        d1 = (Math.Sin(d1));// d1 has the Sin opperand applied to it
                    d1 = (Math.Asin(d1)// d1 has the Asin, or Sin inverse, opperand applied to it
                        * (180 / Math.PI));// Since the result is in radians by default, converts it to degrees
                    break;

                case 9:// Checks if by1 = 9
                    if (second != true)
                        d1 = (Math.Cos(d1));// d1 has the Cos opperand applied to it
                    d1 = (Math.Acos(d1) * (180 / Math.PI));// d1 has the Acos opperand applied to it
                    break;

                case 10:// Checks if by1 = 10
                    if (second != true)
                        d1 = (Math.Tan(d1));// d1 has the Tan opperand applied to it
                    d1 = (Math.Atan(d1) * (180 / Math.PI));// d1 has the Atan opperand applied to it
                    break;

                case 11:// Checks if by1 = 11
                    d1 = d2 * (Math.Pow(10, d1));// Finds the 10 to the power of d1
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
                  (v == "Sin") ? 8 :// If v = Sin, by1 = 8
                  (v == "Sin-1") ? 8 :// If v = Sin-1, by1 = 8
                  (v == "Cos") ? 9 :// If v = Cos, by1 = 9
                  (v == "Cos-1") ? 9 :// If v = Cos-1, by1 = 9
                  (v == "Tan") ? 10 :// If v = Tan, by1 = 10
                  (v == "Tan-1") ? 10 :// If v = Tan-1, by1 = 10
                  (v == "10^") ? 11 :// If v = 10^, by1 = 11
                  0);// Makes by1 0 if none of the above are detected

            d2 = d1;// Makes d2 equal to d1
            Display.Text = null;
            Display.Text += d2;// Adds d2's value to the display
            stat = true;// Sets stat to true

            if (by1 == 5)
                Display.Text += "^";// Adds the exponent symbol to the Display (at your request)

            if (v == "C")// If v is C, the following will happen
            {
                by1 = 0;// Sets by1 to 0
                Display.Text = null;
                stat = false;
            }

            if (v == "2nd")// If v is 2nd, the following will happen
            {
                if (second != true)// Unless second is false, the following line is skipped
                {
                    second = true;// Assigns a True, or 1, value to second
                    button29.Text = "Sin-1";
                    button28.Text = "Cos-1";
                    button23.Text = "Tan-1";
                }
                else
                {
                    second = false;// Sets second to false
                    button29.Text = "Sin";
                    button28.Text = "Cos";
                    button23.Text = "Tan";
                }
            }
        }

        public void sign_Click(object sender, EventArgs e)// Creates the public method sign_Click
        {
            string p;// Declares string p

            if (e == null)
                p = (string)sender;// Makes p equal to the sender's value as a string
            else
                p = ((Button)sender).Text;// Casts sender as a button for use in the declared button b2

            Display.Text += p;// Adds p to the display
        }


        private void Type(object sender, KeyPressEventArgs e)// Creates the private method Type
        {
            string av = e.KeyChar.ToString();// Declares string av and makes it the pressed key's text
            if (av.Contains("."))// If . is pressed, the following happens
            {
                sign_Click(av, null);// Calls method sign_Click with the string av and no event handler
            }
            else// If a key other than those two is pressed, the following happens
            {
                if (char.IsNumber(e.KeyChar))// If isNumber is a character, the following happens
                    Onclick(av, null);// Invokes the method Onclick with the string av and no event handler
                else// Otherwise, the following happens
                    opp_Click(av, null);
            }
            Display.SelectionStart = Display.SelectionLength = 0;// Prevents the user from accidentally highlighting the Display
            Display.Focus();// Tells the program to focus on the Diaplay
        }

        private void Ende(object sender, EventArgs e)// Creates the private method Ende
        {
            this.Close();// Closes the program
        }
    }
}