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
        SqlDataReader r;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\abel\\projects\\c-traning\\HsbcDatabase\\HsbcDatabase\\HsbcDb.mdf;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not connect to the database, Please check your internet connection.");
            }

        }


        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {

            String accType, gender;

            if (radioButtonCurrentA.Checked) accType = "C";
            else accType = "S";

            if (radioButtonMale.Checked) gender = "M";
            else gender = "F";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = "insert into Accounts values('" + accType + gender +
                    "'+(select Format (COALESCE((MAX( SUBSTRING(accountNo, 3,3)) + 1),1), '000')  " +
                    " as topAccount from Accounts where accountNo like '" + accType + "%'),'" + textBoxName.Text + "','" + textBoxAddress.Text + "');";
                
                try
                {
                    cmd.ExecuteNonQuery();
                    labelAccountCreated.Text = "Account has been created for" + textBoxName.Text;

                    textBoxName.Text = "";
                    textBoxAddress.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The is no longer space avaliable for new accounts");
                }
            }

        }

    }
}
