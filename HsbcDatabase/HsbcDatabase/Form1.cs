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

namespace HsbcDatabase
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
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\work\\Documents\\Visual Studio 2013\\Projects\\c-traning\\HsbcDatabase\\HsbcDatabase\\HsbcDb.mdf';Integrated Security=True");
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private string getNextId(char acc, char gender)
        {
            string id = "";

            id += acc;
            id += gender;
            cmd.CommandText = "select MAX( SUBSTRING(accountNo, 3,3)) as topAccount from Accounts where Substring(accountNo, 1, 1) = 'a'";
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                id += (Int32.Parse(r["topAccount"].ToString())) + 1;
            }
            r.Read();
            return id;
        }

        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {

            string regno = "";
            if (radioButtonCurrentA.Checked)
            {
                if (radioButtonMale.Checked) regno = getNextId('a','m');
                else regno = getNextId('a', 'f');
            }
            else
            {
                if (radioButtonMale.Checked) regno = getNextId('s', 'm');
                else regno = getNextId('s', 'f');
            }
            cmd.CommandText = "insert into Accounts values(" + regno + ",'" + textBoxName.Text + "','" + textBoxAddress.Text + "')";
            cmd.ExecuteNonQuery();
        }

    }
}
