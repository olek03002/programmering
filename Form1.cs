using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slumpen = slump.Next(0, 101);
        }
        int antal = 0;
        Random slump = new Random();
        int slumpen;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("");
            label3.Text = ("");
            int gissning = int.Parse(textBox1.Text);
            if (gissning < slumpen)
            {
                label1.Text = ("Talet är för lågt");
                label3.Text = ("Gissa igen: ");
                antal++;
                label5.Text = (""+antal);
            }
            else if (gissning > slumpen)
            {
                label1.Text = ("Talet är för högt");
                label3.Text = ("Gissa igen: ");
                antal++;
                label5.Text = (""+antal);
            }
            else
            {
                label6.Text = ("Talet är rätt!");
                label5.Text = ("" + antal);
            }


        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
