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
    public partial class Form2 : Form
    {
        Form1 parent;// Declares parent as a variable that can contain as many variables as Form1
        public Form2(Form1 parentin)// Declares a method to load the second program while stating that Form1 is the parent file
        {
            InitializeComponent();// Loads the progeam
            parent = parentin;// Assigns every value in the parent file to parent
        }

        private void Onload(object sender, EventArgs e)// Declares the Onload method with the sender as an object and the event argument e
        {
            mdl.Text = parent.c4.model;

            brn.Text = parent.c4.brand;

            drnm.Text = parent.c4.doornum.ToString();

            sts.Text = parent.c4.seats.ToString();

            ts.Text = parent.c4.tirenum.ToString();

            yr.Text = parent.c4.year.ToString();

            msrp.Text = parent.c4.MSRP.ToString();
            // Assigns values from the parent form to the textboxes in this one

        }
        private void button1_Click(object sender, EventArgs e)// Declares the button1_Click method, saves the user's input
        {
            int i;// Declares integer i
            byte b;// Declares byte b

            parent.c4.model = mdl.Text;

            parent.c4.brand = brn.Text;

            if (byte.TryParse(sts.Text, out b))// Tries to convert the text in sts into an byte to be placed in i
                parent.c4.seats = b;// Changes the value of seats to the value of b

            if (byte.TryParse(drnm.Text, out b))// Tries to make drnm's text into a byte
                parent.c4.doornum = b;// Changes doornum's value to b's

            if (byte.TryParse(ts.Text, out b))// Tries to make ts' text into a byte
                parent.c4.tirenum = b;// // Changes tirenum's value to b's

            if (int.TryParse(msrp.Text, out i))// Tries to make msrp's valut into an integer
                parent.c4.MSRP = i;// Changes tirenum's value to i's

            if (int.TryParse(yr.Text, out i))// Tries to make yr's value into an int
                parent.c4.year = i;// Changes tirenum's value to i's

            this.Close();// Closes the program
        }

        private void button2_Click(object sender, EventArgs e)// Declares the button2_Click method
        {
            this.Close();
        }
    }
}