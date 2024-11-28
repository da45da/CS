using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dem_GREPHICS
{
    public partial class Form1 : Form
    {
        /* Damian Attia-Barillas
        Did this program compile? Yes
        Did this program run as expected? Yes
        Mark that you think you deserve. 100%

        1) I learned how to use the Settings.settings window  2) I learned that you can split strings at certain characters  3) I learned how the program can detect if an object is on screen

        I believe that a 100% is reasonable because the save button is fully functional and avoids loading files that no longer exist in addition to the proper resizing introduced in the previous iteration.
        */
        public Form1()// Generates the method for the startup of the program
        {
            InitializeComponent();// Starts the program
        }

        public void onLode(object sender, EventArgs e)// Creates the method onLode with the object sender and the event argument e
        {
            OpenFileDialog o1 = new OpenFileDialog();
            if (Properties.Settings.Default.F1Size.Width == 0 || Properties.Settings.Default.F1Size.Height == 0)// Checks if the window has width
            {
                // Does nothing
            }
            else// If the window has width, the following hapens
            {
                this.WindowState = Properties.Settings.Default.F1State;// Sets the "state" of te window as the default
                if (this.WindowState == FormWindowState.Minimized)// Checks if the window is minimized
                    this.WindowState = FormWindowState.Normal;// Changes the state to "normal" or windowed mode

                this.Location = Properties.Settings.Default.F1Location;// Sets the location of the window to the default
                this.Size = Properties.Settings.Default.F1Size;// Makes the window its default size
            }
            if (File.Exists("SaveGrephics.txt"))// Checks if SaveGrephics.txt exists
            {
                StreamReader sr = new StreamReader("SaveGrephics.txt");// Reads SaveGrephics.txt and saves it to sr
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

        Image i1;// Declares image i1
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
            this.Left += 150;// Moves the window 150 pixels to the left
            if (this.Left + this.Width > Screen.PrimaryScreen.Bounds.Width)// Checks if the window is outside the boundaries of the screen
                this.Left = 0;// If so, brings the window back to the left side
        }

        private void Close(object sender, EventArgs e)// Generates a method in case the close button is pressed
        {
            this.Close();// Tells the program to close;
        }

        private void onClothes(object sender, FormClosingEventArgs e)// Creates the method onClothes with the object sender and the event argument e
        {
            Properties.Settings.Default.F1State = this.WindowState;// Calls the setting F1State
            if (this.WindowState == FormWindowState.Normal)// Checks if the window is in "Windowed" mode
            {
                Properties.Settings.Default.F1Location = this.Location;// Sets the new default location of the window to its current position
                Properties.Settings.Default.F1Size = this.Size;// Sets the new default size of the window to its current size
            }
            else// If not, the following happens
            {
                Properties.Settings.Default.F1Location = this.RestoreBounds.Location;// Sets the default location to the current bounds (either maximized or minimized)
                Properties.Settings.Default.F1Size = this.RestoreBounds.Size;// Sets the default size to the current bounds (either maximized or minimized)
            }
            Properties.Settings.Default.Save();// Saves these settings
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
                fileNames.Items.Add(s1);// Adds s1 to the items stored in fileNames
            }

            filePathAndName.Text = s1;// Replaces the text in filePathAndName with the current image's file name
        }

        public void Shave(object sender, EventArgs e)// Creates the method Shave with the object sender and the event argument e
        {
            string save = "";// Declares an empty string calles save
            foreach (string str in fileNames.Items)// Assigns the items in fileNames to str one at a time
            {
                save += str + ",";// Saves the current index of str to save with a comma afterward
            }
            StreamWriter sw = new StreamWriter("SaveGrephics.txt");// Calls the document SaveGrephics.txt
            sw.WriteLine(save);// Writes the contents of save to the document
            sw.Close();// Closes the StreamWriter

            MessageBox.Show("Save successful");// Notifies the user that their files have successfully saved
        }
    }
}