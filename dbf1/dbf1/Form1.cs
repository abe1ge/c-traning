using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbf1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader r;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Documents\\abel\\projects\\c-traning\\dbf1\\dbf1\\Database1.mdf';Integrated Security=True");
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from school";
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBoxID.Text = r["reg"].ToString();
                textBoxName.Text = r["name"].ToString();
                textBoxMark.Text = r["marks"].ToString();
            }

        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (r.Read())
            {
                textBoxID.Text = r["reg"].ToString();
                textBoxName.Text = r["name"].ToString();
                textBoxMark.Text = r["marks"].ToString();
            }
            else
            {
                MessageBox.Show("no more records");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "Insert into school values ("+ textBoxID + ",'"+textBoxName+"',"+textBoxMark+")";
            cmd.ExecuteNonQuery();
        }
    }
}
