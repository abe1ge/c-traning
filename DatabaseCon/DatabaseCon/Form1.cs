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

namespace DatabaseCon
{
    public partial class FormDBConnect : Form
    {
        
        public FormDBConnect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\abel\\projects\\c-traning\\DatabaseCon\\DatabaseCon\\class.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select * from class";
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    textBoxID.Text = r["regno"].ToString();
                    textBoxName.Text = r["name"].ToString();
                    textBoxMark.Text = r["mark"].ToString();
                }
            }
            catch
            {

            }
        }
    }
}
