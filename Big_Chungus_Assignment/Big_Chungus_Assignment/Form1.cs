using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Chungus_Assignment
{
    public partial class Form1 : Form
    {
        /* Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 100%

        1) I learned that there's a way to check if two objects interact with each other  2) I learned that there is a "random" object  3) I learned that % initiates a modulo

        I believe that a 100% is reasonable because the game is fully functional with some minor upgrades from the initial, basic version.

        Partners: Nick Ellison, Michael Stofega
        */
        System.Timers.Timer timer = new System.Timers.Timer();// Declares the Timer timer and makes it a new Timer
        public int slox = 5, sloy = 10, p1scr = 0, p2scr = 0, intrval = 20;// Declares integer slox while giving it a value of 5, sloy with an initial value of 10, p1scr with a value of 0, intrval with a value of 20, and p2scr with a value of 0
        bool x = true;// Declares the boolean x and sets it to true
        bool y = true;// Declares boolean y and sets it to true
        bool timmy;// Declares the boolean timmy
        Random rnd = new Random();// Declares the R.N.G. rnd
        public Form1()
        {
            InitializeComponent();// Starts the program
            timer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2)//sender already used here, and e2
            {
                this.BeginInvoke(new Action(() =>//What happens if this is removed? If this is removed, a cross-thread error occurs preventing the window from moving
                {
                    timer.Interval = intrval;// Sets the time interval equal to the value of intrval
                    handleMove(true, slox, sloy);// Calls the handleMove method and sends a true value in addition to slox and sloy
                    handleMove(false);// Calls the handleMove method and sends a false value
                }));
            };
        }
        private void Movement(object sender, KeyPressEventArgs e)// Declares the method Movement with sender as an object and the event argument e
        {
            {
                if (e.KeyChar == (char)Keys.W)// If the W key is pressed, the following happens
                {
                    Player1.Top -= 20;// Moves Player1 up 20 pixels
                }
                if (e.KeyChar == (char)Keys.S)// If the S key is pressed, the following happens
                {
                    Player1.Top += 20;// Moves Player1 down 20 pixels
                }

                if (e.KeyChar == (char)Keys.P)// If the tab key is pressed, the following happens
                {
                    if (timmy)// Checks if timmy is true
                    {
                        timmy = false;// Changes timmy to false
                        timer.Stop();// Stops the timer
                    }
                    else
                    {
                        timmy = true;// Changes timmy to true
                        timer.Start();// Starts the timer
                    }
                }
                if (Player1.Top + Player1.Height >= this.Height)// Checks if player 1 is on screen
                    Player1.Top -= 25;// Lowers player 1 by 25 pixels

                if (Player1.Top <= 0)// Checks if player 1 is on screen
                    Player1.Top += 25;// Moves player 1 25 pixels down
            }
        }

        private void Closing(object sender, FormClosingEventArgs e)// Declares the method cLOSING with sender as an object and the closing event argument e
        {
            if (timmy)// Checks if the timer is running
                timer.Stop();// Stops the timer
        }

        private void handleMove(bool b1, int i1, int i2)// Declares the method handleMove with boolean b1 and integers i1 and i2
        {
            if (Ball.Left <= 0)// Checks if the ball is beyond the left edge of the screen
            {
                p2scr++;// Adds 1 to player2's score
                Ball.Top = this.Height / 2;// Brings the ball to about the middle of the window in combination with the next line
                Ball.Left = this.Width / 2;// Brings the ball to about the middle of the window in combination with the previous line

                if ((rnd.Next() % 2) == 0)// Checks if there's a remainder when the next value in rnd is halved
                    x = false;// If so, sets x to false
                else
                    x = true;// If not, sets x to true

                slox = 5;// Resets slox
                intrval = intrval + 2;// Slows down the timer, and therefore the ball by extention
            }
            else if (Ball.Left >= this.Width - Ball.Width)// Checks if the ball is beyond the right edge of the window
            {
                p1scr++;// Adds 1 to player1's score
                Ball.Top = this.Height / 2;// Brings the ball to about the middle of the window in combination with the next line
                Ball.Left = this.Width / 2;// Brings the ball to about the middle of the window in combination with the previous line

                if ((rnd.Next() % 2) == 0)// Checks if there's a remainder when the next value in rnd is halved
                    x = false;// If so, sets x to false
                else
                    x = true;// If not, sets x to true

                slox = 5;// Resets slox
                intrval = intrval + 2;// Slows down the timer, and therefore the ball by extention
            }

            if (Ball.Top <= 0)// Checks if the ball is beyond the top of the screen
                y = true;// Sets y to true
            else if (Ball.Top >= this.Height - Ball.Height)// Checks if the ball is beyond the bottom of the window
                y = false;// Sets y to false

            if (Ball.Bounds.IntersectsWith(Player1.Bounds))// Checks if the ball is in contact with Player 1
            {
                x = true;// Sets x to true
                slox++;// Increases the speed of the ball in the x-direction by a pixel
                if (intrval > 1)// Checks if intrval is greater than one
                    intrval--;// Lowers the time interval and as such, speeds up the ball
            }
            else if (Ball.Bounds.IntersectsWith(Player2.Bounds))// Checks if the ball is in contact with Player 2
            {
                x = false;// Sets x to false
                slox++;// Increases the speed of the ball in the x-direction by a pixel
                if (intrval > 1)// Checks if intrval is greater than one
                    intrval--;// Lowers the time interval and as such, speeds up the ball
            }

            if (x)// Checks if x is true
                Ball.Left += i1;// Moves the window to the right 
            else
                Ball.Left -= i1;// Reverses the motion

            if (y)// Checks if y is true
                Ball.Top += i2;// Moves the window down
            else
                Ball.Top -= i2;// Reverses the motion

            P1_Score.Text = p1scr.ToString();// Makes P1_Score display the value of p1scr
            P2_Score.Text = p2scr.ToString();// Makes P2_Score display the value of p2scr

            if (p1scr == 5)// Check if Player 1 has a score of 5
            {
                timer.Stop();// Stops the timer
                slox = 5;
                intrval = 20;
                MessageBox.Show("Player 1 Wins!");// Declares Player 1 as the winner
                p1scr = p2scr = 0;// Resets the scoreboard's values
            }
            if (p2scr == 5)// Check if Player 1 has a score of 5
            {
                timer.Stop();// Stops the timer
                intrval = 20;
                slox = 5;
                MessageBox.Show("Player 2 Wins!");// Declares Player 2 as the winner
                p1scr = p2scr = 0;// Resets the scoreboard's values
            }
            P1_Score.Text = p1scr.ToString();// Makes P1_Score display the value of p1scr
            P2_Score.Text = p2scr.ToString();// Makes P2_Score display the value of p2scr
        }

        private void handleMove(bool b1)// Declares an overload for the method handleMove with boolean b1
        { }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)// Declares an overide for the ProcessCmdKey method
        {
            if (keyData == Keys.Up)// If the up arrow is pressed, the following happens
            {
                Player2.Top -= 20;// Moves Player2 up 20 pixels
            }
            if (keyData == Keys.Down)// If the down arrow is pressed, the following happens
            {
                Player2.Top += 20;// Moves Player2 down 20 pixels
            }

            if (Player2.Top + Player2.Height >= this.Height)// Checks if player 2 is at the bottom of the window
                Player2.Top -= 25;// Raises player 2 by 25 pixels

            if (Player2.Top <= 0)// Checks if player 2 is at the top of the window
                Player2.Top += 25;// Lowers player 2 by 25 pixels

            return base.ProcessCmdKey(ref msg, keyData);// Returns the result to the base method
        }
    }
}