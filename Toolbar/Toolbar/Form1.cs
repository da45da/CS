using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Toolbar
{
    /* Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 100%

        1)  I learned that there's a method to center a window on the screen  2) I learned that Timers must run like clockwork to be successful  3) I learned that you can call a seperate form as a dialog box relatively easily

        I believe that a 100% is reasonable because the window bounces around with varying speeds, slopes, and positions as determined by the user while having defult setting in case they choose not to set anything

        Partners: Nick Ellison
        */
    public partial class Form1 : Form// Generates a class for Form1
    {
        System.Timers.Timer timer = new System.Timers.Timer();// Declares the Timer timer and makes it a new Timer
        public int posy, posx, intrval = 50, slox = 5, sloy = 15;// Declares integer posy, posx, intrval(at an initial value of 50), slox(while giving it a value of 5), and sloy(with an initial value of 15)
        bool isOn;// Declares boolean isOn
        bool x = true, y = true;// Declares booleans x and y while setting them to true
        public Form1()// Declares a method to load the program
        {
            InitializeComponent();// Starts the program
            toolStripButton1.Image = Image.FromFile("9TpenRLTE.png");// Makes the button's image 9TpenRLTE.png

            timer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2)//sender already used here, and e2
            {
                this.BeginInvoke(new Action(() =>//What happens if this is removed? If this is removed, a cross-thread error occurs preventing the window from moving
                {
                    timer.Interval = intrval;// Sets the time interval equal to the value of  intrval
                    handleMove(true, slox, sloy);// Calls the handleMove method and sends a true value in addition to slox and sloy
                    handleMove(false);// Calls the handleMove method and sends a false value
                }));
            };
        }

        private void Form1_Load(object sender, EventArgs e)// Generates the method Form1_load with an object called sender and an event argument called e
        {
            this.CenterToScreen();// Centers the window
            this.Left = 0;// Brings the window to the left of the screen
            posy = this.Top;// Makes posy the number of pixels away the window is from the top
            posx = this.Left;// Makes posx the number of pixels away the window is from the left
        }



        private void Close(object sender, EventArgs e)// Generates the method Close with an object called sender and an event argument called e
        {
            MessageBox.Show("Goodbye");// Bids the user farewell
            this.Close();// Closes the windoow
        }

        private void Reset(object sender, EventArgs e)// Generates the method Reset with an object called sender and an event argument called e
        {
            this.Top = posy;// Brings the window's top to the value of posy
            this.Left = posx;// Brings the window's left edge to the value of posx
        }

        private void klak(object sender, KeyPressEventArgs e)
        {
            if (isOn)// Checks if the boolean isOn is true
            {
                isOn = false;// Makes isOn false
                toolStripButton1.Image = Image.FromFile("9TpenRLTE.png");// Opens "9TpenRLTE.png" from the files and changes toolStripButton1's image to it
                timer.Stop();// Stops the timer
            }
            else// If isOn is false, the following happens
            {
                isOn = true;// Makes isOn true
                toolStripButton1.Image = Image.FromFile("pause-button-hi.png");// Opens "pause-button-hi.png" from the files and changes toolStripButton1's image to it
                timer.Start();// Starts the timer
            }
        }
        private void Motion(object sender, EventArgs e)// Generates the method Motion with an object called sender and an event argument called e
        {
            if (isOn)// Checks if the boolean isOn is true
            {
                isOn = false;// Makes isOn false
                toolStripButton1.Image = Image.FromFile("9TpenRLTE.png");// Opens "9TpenRLTE.png" from the files and changes toolStripButton1's image to it
                timer.Stop();// Stops the timer
            }
            else// If isOn is false, the following happens
            {
                isOn = true;// Makes isOn true
                toolStripButton1.Image = Image.FromFile("pause-button-hi.png");// Opens "pause-button-hi.png" from the files and changes toolStripButton1's image to it
                timer.Start();// Starts the timer
            }
        }

        private void handleMove(bool b1, int i1, int i2)// Declares the method handleMove with boolean b1 and integers i1 and i2
        {
            if (this.Left <= 0)// Checks if the window is beyond the left edge of the screen
                x = true;// Sets x to true
            else if (this.Left >= Screen.PrimaryScreen.Bounds.Width - this.Width)// Checks if the window is beyond the right edge of the screen
                x = false;// Sets x to false

            if (this.Top <= 0)// Checks if the window is beyond the top of the screen
                y = true;// Sets y to true
            else if (this.Top >= Screen.PrimaryScreen.Bounds.Height - this.Height)// Checks if the window is beyond the bottom of the screen
                y = false;// Sets y to false

            if (x)// Checks if x is true
                this.Left += i1;// Moves the window to the right 
            else
                this.Left -= i1;// Reverses the motion

            if (y)// Checks if y is true
                this.Top += i2;// Moves the window down
            else
                this.Top -= i2;// Reverses the motion

        }

        private void handleMove(bool b1)// Creates an overload for handleMove that only checks for boolean b1
        {

        }


        private void Stats(object sender, EventArgs e)// Generates the method Stats with an object called sender and an event argument called e
        {
            Form2 f2 = new Form2(this);// Loads Form2 as f2
            f2.ShowDialog();// Converts f2 to a dialog box
        }
    }
}