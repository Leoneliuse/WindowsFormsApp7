using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i; int[] a; a = new int[5];
            int[] t; t = new int[5];
            for (i = 0; i < 5; i++)
                a[i] = int.Parse(textBox1.Text.ToString());
            for (i = 0; i < 5; i++)
                t[i] = int.Parse(textBox2.Text.ToString());
            for (i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i] == t[j])
                    {
                        label1.Text = t[j].ToString();
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
