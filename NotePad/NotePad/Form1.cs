using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FormNotePad : Form
    {
        string currentFile = "";
        public FormNotePad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //richTextBoxMain.Text += " box intial width" + richTextBoxMain.Width + " box initail hight " + richTextBoxMain.Height;
            //richTextBoxMain.Text += " frame intial width" + this.Width + " frame initail hight " + this.Height ;
        }

        private void FormNotePad_Resize(object sender, EventArgs e)
        {
           //richTextBoxMain.Width = (this.Width - 25);
           // richTextBoxMain.Height = (this.Height - 20);
        }

        private void richTextBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (currentFile == "" || B.Text == "Save As" )
            {
                saveFileDialog1.ShowDialog();
                currentFile = saveFileDialog1.FileName;
                if (currentFile != "")
                {
                    richTextBoxMain.SaveFile(currentFile);
                    this.Text = "NotePad - " + currentFile;
                }
            }
            else
            {
                richTextBoxMain.SaveFile(currentFile);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            currentFile = openFileDialog1.FileName;
            richTextBoxMain.LoadFile(currentFile);
            this.Text = "NotePad - " + currentFile;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem B = (ToolStripMenuItem)sender;
            if (currentFile == "" || B.Text == "Save As")
            {
                saveFileDialog1.ShowDialog();
                currentFile = saveFileDialog1.FileName;
                if (currentFile != "")
                {
                    richTextBoxMain.SaveFile(currentFile+".txt");
                    this.Text = "NotePad - " + currentFile;
                }
            }
            else
            {
                richTextBoxMain.SaveFile(currentFile);
            }
        }

       

       


        

       
    }
}
