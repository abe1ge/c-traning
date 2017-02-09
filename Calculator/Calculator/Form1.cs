using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int firstNum;
        string opp;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            textBox1.Text += B.Text;
            
        
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            switch(B.Text)
            {
                case "+":
                    opp = B.Text;
                    firstNum = Int32.Parse(textBox1.Text);
                    textBox1.Text = "";
                    break;
                case "-":
                    opp = B.Text;
                    firstNum = Int32.Parse(textBox1.Text);
                    textBox1.Text = "";
                    break;
                case "/":
                    opp = B.Text;
                    firstNum = Int32.Parse(textBox1.Text);
                    textBox1.Text = "";
                    break;
                case "x":
                    opp = B.Text;
                    firstNum = Int32.Parse(textBox1.Text);
                    textBox1.Text = "";
                    break;
                case "C":
                    textBox1.Text = "";
                    break;
                case "=":
                    switch (opp)
                    {
                        case "+":
                            result = firstNum + Int32.Parse(textBox1.Text);
                            textBox1.Text = result.ToString();
                            break;
                        case "-":
                            result = firstNum - Int32.Parse(textBox1.Text);
                            textBox1.Text = result.ToString();
                            break;
                        case "/":
                            result = firstNum / Int32.Parse(textBox1.Text);
                            textBox1.Text = result.ToString();
                            break;
                        case "x":
                            result = firstNum * Int32.Parse(textBox1.Text);
                            textBox1.Text = result.ToString();
                            break;
                    }
                    break;

            }
        }

    
    }
}
