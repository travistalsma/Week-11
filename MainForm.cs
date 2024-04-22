using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Midterm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //CustNumLabel.Text = LoginForm.CusNumTB;
        }

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomerData.mdf;Integrated Security=True;Connect Timeout=30";

        private void WithCheck_Click(object sender, EventArgs e)
        {
            //accountnum balance - textbox amount = new
            //select CheckingNum from customer data where customer number = login form tb cust num
            int amount = 0;
            Int32.TryParse(Amount.Text, out amount);
            SQLHelper.WithdrawChecking(amount);
        }

        private void ViewCheck_Click(object sender, EventArgs e)
        {
            //account num display amount
            //select balance from account data where account num = checking num show in listbox.
            listBox1.DataSource = SQLHelper.ViewCheckingBalance();
            //value member tried and failed.
            listBox1.DisplayMember = "Balance";
            //all else returned an error. 
            
        }

        private void WithSav_Click(object sender, EventArgs e)
        {
            //accountnum balance - textbox amount = new
            int amount = 0;
            Int32.TryParse(Amount.Text, out amount);
            SQLHelper.WithdrawSavings(amount);
        }

        private void ViewSav_Click(object sender, EventArgs e)
        {
            //account num display amount
            listBox1.DataSource = SQLHelper.ViewSavingBalance();
            listBox1.DisplayMember = "Balance";
        }

        private void TransC2S_Click(object sender, EventArgs e)
        {
            //account balance - text box + other account balance
            int amount = 0;
            Int32.TryParse(Amount.Text, out amount);
            SQLHelper.TransferCheckToSave(amount);
        }

        private void TransS2C_Click(object sender, EventArgs e)
        {
            //account balance - text box + other account balance
            int amount = 0;
            Int32.TryParse(Amount.Text, out amount);
            SQLHelper.TransferSaveToCheck(amount);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //enter amount to withdraw or transfer
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display balance information
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm fl = new LoginForm();
            fl.Show();
        }

        private void CustNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
