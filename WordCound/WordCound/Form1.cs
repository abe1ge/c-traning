using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //count the number of words
        private void buttonCount_Click(object sender, EventArgs e)
        {
           
            int numWords = 0;

            for (int i = 1; i < textBoxWords.Text.Length; i++)
            {
                if (textBoxWords.Text[i] == ' ' && 
                    textBoxWords.Text[i- 1] != ' ') numWords++;
                
               
            }
            try
            {
                if (textBoxWords.Text[textBoxWords.Text.Length - 1] != ' ') numWords++;
            }catch(System.IndexOutOfRangeException)
            {

            }
             textBoxCWords.Text = numWords.ToString();
        }

        
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            /*Convert the string
             * Double the numbers
             * Lower case to upper and upper case to lower
             * special charectors stay the same
             * */
            string converted = "";
            converted += (textBoxWords.Text.Select(x => convertStr(x))).ToArray(); 

            //for (int i = 0; i < textBoxWords.Text.Length; i++)
            //{
            //    if (Char.IsNumber(textBoxWords.Text[i])) converted += Int32.Parse(textBoxWords.Text[i].ToString()) * 2;
            //    else if (Char.IsLetter(textBoxWords.Text[i]))
            //    {
            //        if (Char.IsLower(textBoxWords.Text[i]))
            //            converted += textBoxWords.Text[i].ToString().ToUpper();
            //        else converted += textBoxWords.Text[i].ToString().ToLower();
            //    }
            //    else converted += textBoxWords.Text[i];
            //}
            textBoxConverted.Text += textBoxWords.Text.Select(x => convertStr(x)).ToArray();
        }

        private string convertStr(Char c)
        {
            if (Char.IsNumber(c)) return (Int32.Parse(c.ToString()) * 2).ToString();
            else if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                    return c.ToString().ToUpper();
                else return c.ToString().ToLower();
            }
            else return c.ToString();
        }
    }
}
