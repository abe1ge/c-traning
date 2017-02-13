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
        int changed = 0;

        public delegate void returnVoid();

        #region Form
        public FormNotePad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {  }

        private void FormNotePad_Resize(object sender, EventArgs e)
        {
            richTextBoxMain.Size = new Size(this.Width - 25, this.Height - 65);
        }

        #endregion

        private void richTextBoxMain_TextChanged(object sender, EventArgs e)
        {
            changed = 1;
        }
      

        //when trying to open a document
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (changed != 0)
            {
                saveDialogBox(open);
            }
            else open();
        }

        
        // when trying to save the file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem B = (ToolStripMenuItem)sender;
            if (currentFile == "" || B.Text == "Save As")
            {
                save();
            }
            else
            {
                richTextBoxMain.SaveFile(currentFile);
            }
        }

        //when creating a new document
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed != 0)
            {
                string caption = "current file";
                if (currentFile != "") caption = currentFile;

                saveDialogBox(newF);
            }
            else newF();
        }

        private void closeExitToolStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem B = (ToolStripMenuItem)sender;

            if (changed != 0)
            {
                if (B.Text == "Close") saveDialogBox(close);
                else saveDialogBox(exit);
            }
            else
            {
                if (B.Text == "Close") close();
                else exit();
            }
        }

        #region new/save/open

        public void saveDialogBox(returnVoid what)
        {
            switch (MessageBox.Show("Do you like to save the file", "Save dialog", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    save();
                    if (changed == 0) what();
                    break;
                case DialogResult.No:
                    what();
                    break;
            }
        }

        private void newF()
        {
            richTextBoxMain.Text = "";
            currentFile = "";
            changed = 0;
            this.Text = "NotePad - New";
            richTextBoxMain.Visible = true;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void save()
        {
            saveFileDialog1.ShowDialog();
            currentFile = saveFileDialog1.FileName;
            if (currentFile != "")
            {
                richTextBoxMain.SaveFile(currentFile + ".txt");
                this.Text = "NotePad - " + currentFile;
                changed = 0;
            }
        }

        private void open()
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                currentFile = openFileDialog1.FileName;
                richTextBoxMain.LoadFile(currentFile);
                this.Text = "NotePad - " + currentFile;
                richTextBoxMain.Visible = true;
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void close()
        {
            richTextBoxMain.Text = "";
            currentFile = "";
            changed = 0;
            this.Text = "NotePad - none";
            richTextBoxMain.Visible = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
        }

        private void exit() { Application.Exit(); }
        #endregion



        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBoxMain.Font = fontDialog1.Font;
        }

        private void closeExitToolStrip_Click(object sender, FormClosedEventArgs e)
        {

        }

        private void redExit_Click(object sender, FormClosedEventArgs e)
        {
            if (changed != 0) saveDialogBox(exit);
            else exit();
        }
    }
}
