using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbar
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
            Ypos.Text = parent.posy.ToString();// Places the value of posy from Form1 as a string in Ypos

            Xpos.Text = parent.posx.ToString();// Places the value of posx from Form1 as a string in Xpos

            slopeX.Text = parent.slox.ToString();// Places the value of slox from Form1 as a string in slopeX

            slopeY.Text = parent.sloy.ToString();// Places the value of sloy from Form1 as a string in slopeY

            Speed.Text = parent.intrval.ToString();// Places the value of intrval from Form1 as a string in Speed
        }
        private void button1_Click(object sender, EventArgs e)// Declares the button1_Click method with the sender as an object and the event argument e
        {
            int i;// Declares integer i

            if (int.TryParse(Ypos.Text, out i))// Tries to convert the text in Ypos into an integer to be placed in i
                parent.posy = i;// Changes the value of posy to the value of i

            if (int.TryParse(Xpos.Text, out i))// Tries to convert the text in Xpos into an integer to be placed in i
                parent.posx = i;// Changes the value of posx to the value of i

            if (int.TryParse(slopeY.Text, out i))// Tries to convert the text in slopeY into an integer to be placed in i
                parent.sloy = i;// Changes the value of sloy to the value of i

            if (int.TryParse(slopeX.Text, out i))// Tries to convert the text in slopeX into an integer to be placed in i
                parent.slox = i;// Changes the value of slox to the value of i

            if (int.TryParse(Speed.Text, out i))// Tries to convert the text in Speed into an integer to be placed in i
                parent.intrval = i;// Changes the value of intrval to the value of i

            this.Close();// Closes the program
        }

        private void button2_Click(object sender, EventArgs e)// Declares the button2_Click method with the sender as an object and the event argument e
        {
            this.Close();// Closes the program
        }
    }
}
