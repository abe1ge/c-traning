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
            this.BackColor = Color.Beige;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            textBox1.Text += B.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            opp = B.Text;

            try
            {
                firstNum = Int32.Parse(textBox1.Text);
                textBox1.Text += B.Text;
            }
            catch (System.FormatException)
            {
                
            }
        }
        private void Controle_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            
            switch (B.Text)
            {
                case "C":
                    textBox1.Text = "";
                    break;
                case "=":

                    DataTable dt = new DataTable();
                    textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
                    
                    //switch (opp)
                    //{
                    //    case "+":
                    //        result = firstNum + Int32.Parse(textBox1.Text);
                    //        textBox1.Text = result.ToString();
                    //        break;
                    //    case "-":
                    //        result = firstNum - Int32.Parse(textBox1.Text);
                    //        textBox1.Text = result.ToString();
                    //        break;
                    //    case "/":
                    //        result = firstNum / Int32.Parse(textBox1.Text);
                    //        textBox1.Text = result.ToString();
                    //        break;
                    //    case "x":
                    //        result = firstNum * Int32.Parse(textBox1.Text);
                    //        textBox1.Text = result.ToString();
                    //        break;
                    //}
                    break;
            }
        }

        private void buttonSience_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if(B.Text == "sic")
            {
                this.Width = 400;
            }
            if(B.Text == "std")
            {
                this.Width = 240;
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            switch(B.Text)
            {
                case "*":
                    labelHelp.Text = "Help: Use for multipcation";
                    break;
                case "/":
                    labelHelp.Text = "Help: Use for division";
                    break;
                case "+":
                    labelHelp.Text = "Help: Use for addition";
                    break;
                case "-":
                    labelHelp.Text = "Help: Use for subtraction";
                    break;
                case "C":
                    labelHelp.Text = "Help: Use for Clear";
                    break;
                case "=":
                    labelHelp.Text = "Help: Use for equal/result";
                    break;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            labelHelp.Text = "Help: Hover over button to see help";
        }


    }
}
