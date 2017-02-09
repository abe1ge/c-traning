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


            int firstNumber = 0;
            int secondNumber = 0;

            try
            {
                firstNumber = Int32.Parse(textBox3.Text);
            }catch(System.FormatException)
            {
                textBox6.Text = "first number is not a number";
            }
            
            try
            {
                secondNumber = Int32.Parse(textBox4.Text);
            }
            catch (System.FormatException)
            {
                textBox6.Text = "first number is not a number";
            }

            switch (textBox5.Text)
            {
                case "+":
                    textBox6.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    textBox6.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "/":
                    textBox6.Text = (firstNumber / secondNumber).ToString();
                    break;
                case "x":
                    textBox6.Text = (firstNumber * secondNumber).ToString();
                    break;
                default:
                    textBox6.Text = "come on maaan, what do you want";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == "click me")textBox7.Text = "I have been clicked";


            if (b.Text == "I created") textBox8.Text = "I have been created";
        }
    }
}
