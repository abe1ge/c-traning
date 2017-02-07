using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void my_button_Click(object sender, EventArgs e)
        {
            string msg = textBox1.Text;

            textBox2.Text = textBox1.Text;

            textBox1.Text = "";


            textBox3.Text = "Hello";
            textBox4.Text = "Hello";
            textBox5.Text = "Hello";
            textBox6.Text = "Hello";
            textBox7.Text = "Hello";
            textBox8.Text = "Hello";
            textBox9.Text = "Hello";
            textBox10.Text = "Hello";
            textBox11.Text = "Hello";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
