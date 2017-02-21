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
        Panel currentPannel;

        public Form1()
        {
            InitializeComponent();
            currentPannel = panelWelcome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hsbcDbDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.hsbcDbDataSet.Accounts);
            this.Text = "Main Menu";
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\work\\Documents\\Visual Studio 2013\\Projects\\c-traning\\HsbcDatabase\\HsbcDatabase\\HsbcDb.mdf';Integrated Security=True");
            try
            {
                con.Open();
            }

            catch (Exception)
            {
                MessageBox.Show("Can not connect to the database, Please check your internet connection.");
            }
            cmd = new SqlCommand();

        }


        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {
            //validation
            if (textBoxName.Text.Length < 6 ||
                textBoxName.Text.Length >= 20 ||
                textBoxAddress.Text.Length < 20)
            {
                MessageBox.Show("Name must be over five charecters and less then 20 \n" +
                "address must be over 20", "name and address field rules");
            }
            else creatAccount();
        }


        private void creatAccount()
        //creating an account
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
                    labelAccountCreated.Text = "Account has been created for " + textBoxName.Text;

                    textBoxName.Text = "";
                    textBoxAddress.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("The is no longer space avaliable for new accounts");
                }
            }
        }

        private void changePannelButton_Click(object sender, EventArgs e)
        {
            string cPannel = "";

            try
            {
                Button B = (Button)sender;
                cPannel = B.Text;
            }
            catch (Exception)
            {
                ToolStripMenuItem B = (ToolStripMenuItem)sender;
                cPannel = B.Text;
            }

            switch (cPannel)
            {
                case "Create an account":
                    changePannel(panelCreatAccount, "Create an Account");
                    break;
                case "Withdraw":
                    changePannel(panelWithdraw, "With draw from an account");
                    break;
                case "Deposit":
                    changePannel(panelDeposit, "Deposit into an account");
                    break;
                case "Welcome":
                    changePannel(panelWelcome, "welcome to HSBC");
                    break;
            }
        }

        private void changePannel(Panel to, string fname)
        {
            if (currentPannel.Name != to.Name)
            {
                to.Visible = true;
                currentPannel.Visible = false;
                currentPannel = to;

                this.Text = fname;
            }
        }

        private void buttonWDSearch_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if (B.Name == "buttonWSearch") searchByAccNo(textBoxWAccountNo, textBoxWName, textBoxWaddress, textBoxWBalance);
            else searchByAccNo(textBoxDAccountNo, textBoxDName, textBoxDAddress, textBoxDBalance);
        }

        private void searchByAccNo(TextBox accountNo, TextBox name, TextBox address, TextBox balance)
        {
            cmd.Connection = con;
            cmd.CommandText = "select name,address, (select SUM(amount) from deposit where accountNo = '" + accountNo.Text + "') + (select SUM(amount) from deposit where accountNo = '" + accountNo.Text + "') as balance from Accounts where accountNo = '" + accountNo.Text + "'";

            using (r = cmd.ExecuteReader())
            {
                try
                {

                    if (r.Read())
                    {
                        name.Text = r["name"].ToString();
                        address.Text = r["address"].ToString();
                        balance.Text = r["balance"].ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not connect to database, please try again");
                }
            }

        }
    }
}
