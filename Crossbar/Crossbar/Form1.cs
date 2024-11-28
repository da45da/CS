using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossbar
{
    public partial class Form1 : Form
    {
        /* Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 99%

        1) I learned that editing the properties of an object can be as easy as just punching in the name  2) I learned that using a linear pattern to create a complex program is quite difficult

        I believe that a 99% is reasonable because the requirments and the window's title even chenges with the colour of the textBox

        Partners: Nick Ellison
        */
        System.Timers.Timer timer = new System.Timers.Timer();// Declares the Timer timer and makes it a new Timer
        public int posy, posx, intrval = 50, slox = 20, sloy = 20;// Declares integer posy, posx, intrval(at an initial value of 50), slox(while giving it a value of 20), and sloy(with an initial value of 20)
        bool timmy = false;// Declares boolean timmy while setting it to true
        byte by1 = 0, by2 = 0;// DEclares bytes by1 and by2 with a value of 0


        public Form1()
        {
            InitializeComponent();// Starts the program
            timer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2)//sender already used here, and e2
            {
                this.BeginInvoke(new Action(() =>//What happens if this is removed? If this is removed, a cross-thread error occurs preventing the window from moving
                {
                    timer.Interval = intrval;// Sets the time interval equal to the value of intrval
                    toolStrip1.Focus();// Focuses on the toolstrip
                    handleMove(slox, sloy);// Calls the handleMove method and sends sloy and slox
                }));
            };
        }

        private void Lode(object sender, EventArgs e)// Declares the method Lode with the sender as an object and the event argument e
        {
            posx = 50;// Sets posx to 50
            The_Box.Left = posx;// Sets the left edge of the box to posx
            posy = The_Box.Top;// Sets posy to the box's top value
        }

        private void toolStripButton2_Click(object sender, EventArgs e)// Declares the method toolStripButton2_Click with the sender as an object and the event argument e
        {
            if (timmy)// Checks if timmy is true
            {
                timer.Stop();// Stops the timer
                timmy = false;// Sets timmy to false
            }
            else
            {
                timer.Start();// Starts the timer
                timmy = true;// Sets timmy to true
            }
        }

        private void handleMove(int i1, int i2)// Declares the method handleMove with boolean b1 and integers i1 and i2
        {
            switch (by1)// Declares a switch statment determined by the value of by1
            {
                case 0:// Should by1 = 0, the following hapens
                    The_Box.Top -= i2;// Raises The Box by the value of i2
                    if (The_Box.Top <= toolStrip1.Height)// Checks if the box is at or above the toolstrip
                        by1 = 1;// Sets by1 to 1

                    if (The_Box.Top == posy)// Checks if The Box is at its original height
                        by1 = 2;// Sets by1 to 2
                    break;// Ends the current case

                case 1:// Should by1 = 1, the following hapens
                    The_Box.Top += i2;// Lowers The Box by the value of i2
                    if (The_Box.Top >= this.ClientSize.Height - The_Box.Height)// Checks if The Box is beyond the height boundaries of the window
                        by1 = 0;// Sets by1 to 0
                    break;// Ends the current case

                case 2:// Should by1 = 2, the following hapens
                    The_Box.Left += i1;// Moves The Box left by the value of i2
                    if (The_Box.Left >= this.ClientSize.Width - The_Box.Width)// Checks if The Box is beyond the width boundaries of the window
                        by1 = 3;// Sets by1 to 3

                    if (The_Box.Left == posx)// Checks if The Box is at its starting x-position
                        by1 = 0;// Sets by1 to 0
                    break;// Ends the current case

                case 3:// Should by1 = 3, the following hapens
                    The_Box.Left -= i1;// Moves the box to the right by the value of i1
                    if (The_Box.Left <= 0)// Checks if The Box is st or beyond the left edge of the screen
                        by1 = 2;// sets by1 to 2
                    break;// Ends the current case
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)// Declares the method toolStripButton1_Click with the sender as an object and the event argument e
        {
            switch (by2)// Declares a switch for the value of by2
            {
                case 0:// Should by2 = 0, the following hapens
                    The_Box.BackColor = Color.White;// Sets the colour of The Box to white
                    by2 = 1;// Sets by2 to 1
                    this.Text = "White";// Changes te title of the form to White
                    break;// Ends the current case

                case 1:// Should by2 = 1, the following hapens
                    The_Box.BackColor = Color.Blue;// Sets the colour of The Box to blue
                    by2 = 2;// Sets by2 to 2
                    this.Text = "Blue";// Changes te title of the form to Blue
                    break;// Ends the current case

                case 2:// Should by2 = 2, the following hapens
                    The_Box.BackColor = Color.Yellow;// Sets the colour of The Box to yellow
                    by2 = 0;// Sets by2 to 0
                    this.Text = "Yellow";// Changes te title of the form to Yellow
                    break;// Ends the current case
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)// Declares the method toolStripButton3_Click with the sender as an object and the event argument e
        {
            this.Close();// Closes the window
        }

        private void Closing(object sender, FormClosingEventArgs e)// DEclares the Closing event with sender as an object and the closing event argument e
        {
            if (timmy)/// Checks if timmy is true
                timer.Stop();// Stops the timer
        }
    }
}