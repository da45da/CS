using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dem_GREPHICS_The_Squeakuel_
{
    public partial class Form1 : Form
    {
        /* Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 100%

        1) I learned that an easy way to get to the opposite end of the screen is to simply check the boundaries.  2) I learned that you can put multiple while loops in a single case.

        I believe that a 100% is reasonable because the window meets all requirements, includes a failsafe, and improves slightly is some areas from its previous iteration.

            Note: Resubmitted with more efficient code, originally submitted wihin the given timeframe. Resubmitted within your approved extended timeframe.
        */
        string filenames;// Declares string filenames
        Image i1;// Declares image i1
        byte by1 = 0;// Declares byte by1 and makes it 0
        public Form1()// Generates the method for the startup of the program
        {
            InitializeComponent();// Starts the program
            filenames = "SaveGrephics.txt";// Makes filenames the equivalent of "SaveGrephics.txt"
        }

        public void onLode(object sender, EventArgs e)// Creates the method onLode with the object sender and the event argument e
        {
            this.Left = 0;// Sets the window to the left edge of the screen
            this.Top = 0;// Brings the window to the top of the screen
            OpenFileDialog o1 = new OpenFileDialog();// Calls the OpenFileDialog class to search the device
            if (File.Exists(filenames))// Checks if SaveGrephics.txt exists
            {
                StreamReader sr = new StreamReader(filenames);// Reads SaveGrephics.txt and saves it to sr
                string s2 = sr.ReadLine();// Converts the text in sr to a string
                string[] sarr = s2.Split(',');// Splits s2 at every comma and places the pieces into sarr

                foreach (string item in sarr)// Saves the current index of sarr as string item
                {
                    if (File.Exists(item))// Checks if the file can be found
                    {
                        if (item.Length > 0)// Checks if the current index has a length              
                            fileNames.Items.Add(item);// Adds the current index as an item in the ComboBox   
                    }
                }
                sr.Close();// Closes the StreamReader
            }
        }

        private void Change(object sender, EventArgs e)// Creates the method Change with the object sender and the event argument e
        {
            string s1;// Declares string s1
            i1 = Bitmap.FromFile(fileNames.Text);// Generates image i1 to become the selected file name
            pictureBox1.Image = i1;// Places the selected image in the picturebox

            if (e == null)// Checks if there is an event
                s1 = (string)sender;// Casts the sender as a string for s1
            else// If there is an event, the following happens
                s1 = ((ComboBox)sender).Text;// Sets s1 to the text in the ComboBox
            filePathAndName.Text = s1;// Makes the text in the TextBox s1

            pictureBox1.ImageLocation = s1;// Takes the text of s1, searches the device for it, and makes the resulting image the picture in the PictureBox

            Shift();// Calls the method Shift
        }

        private void Shift()// Declares the method Shift
        {
            int edge = Screen.PrimaryScreen.Bounds.Width - this.Width;// Declares int edge with a value of the left boundary - the width of the window
            int tedge = Screen.PrimaryScreen.Bounds.Height - this.Height;// Declares int tedge with a value of the top boundary - the height of the window
            switch (by1)// Creates a switch statement fr the value of by1
            {
                case 0:// If by1 = 0, the following happens
                    this.Left = edge;// Sets the window to edge
                    this.Top = 0;// Brings the window to the top of the screen
                    by1 = 1;// Sets by1 to 1
                    break;// Ends the current case

                case 1:// If by1 = 1, the following happens
                    this.Top = tedge;// Sets the window's height to tedge
                    this.Left = edge;// Sets the window to edge
                    by1 = 2;// Sets by1 to 2
                    break;// Ends the current case

                case 2:// If by1 = 2, the following happens
                    this.Top = tedge;// Sets the window's height to tedge
                    this.Left = 0;// Brings the window to the left of the screen
                    by1 = 3;// Sets by1 to 3
                    break;// Ends the current case

                case 3:// If by1 = 3, the following happens
                    this.Top = 0;// Brings the window to the top of the screen
                    this.Left = 0;// Brings the window to the left of the screen
                    by1 = 0;// Sets by1 to 0
                    break;// Ends the current case
            }
        }

        private void Close(object sender, EventArgs e)// Generates a method in case the close button is pressed
        {
            this.Close();// Tells the program to close;
        }

        private void Files(object sender, EventArgs e)// Generates a method in case the close button is pressed
        {
            OpenFileDialog o1 = new OpenFileDialog();// Opens the files window from the console and calls it o1
            o1.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg;)|*.jpeg;*.bmp;*.png;*.jpg";// Filters so that only imag file will be slectable
            o1.FilterIndex = 0;// Sets the index of the filter to 0
            o1.RestoreDirectory = true;// Saves/restores the file path (directory)
            o1.Multiselect = false;// Prevents multiple images from being selecter simultaneously

            if (o1.ShowDialog() == DialogResult.OK)// If a file is selected, the following happens
            {
                i1 = Bitmap.FromFile(o1.FileName);// Generates image i1 to become the selected file
                pictureBox1.Image = i1;// Places the selected image in the picturebox
            }
            string s1 = o1.FileName;// Converts the file name to a string and assigns it to s1
            if (!fileNames.Items.Contains(s1))// Checks if s1 exists in the combobox. If not, the following happens
            {
                fileNames.Text = s1;// Adds the name of the file to the ComboBox
                fileNames.Items.Add(s1);// Adds s1 to the items stored in fileNames
            }

            filePathAndName.Text = s1;// Replaces the text in filePathAndName with the current image's file name
            Shift();// Calls the method Shift
        }

        public void Shave(object sender, EventArgs e)// Creates the method Shave with the object sender and the event argument e
        {
            string save = "";// Declares an empty string calles save
            foreach (string str in fileNames.Items)// Assigns the items in fileNames to str one at a time
            {
                save += str + ",";// Saves the current index of str to save with a comma afterward
            }
            StreamWriter sw = new StreamWriter(filenames);// Calls the document SaveGrephics.txt
            sw.WriteLine(save);// Writes the contents of save to the document
            sw.Close();// Closes the StreamWriter

            MessageBox.Show("Save successful");// Notifies the user that their files have successfully saved
        }
    }
}