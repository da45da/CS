using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_For_Fun_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world! Chemistry is Poppin'!","Biology is Life!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Physics phlops","What About Physics?");
            this.Close();
        }
    }
}
