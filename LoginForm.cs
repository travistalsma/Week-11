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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomerData.mdf;Integrated Security=True;Connect Timeout=30";

        public void button1_Click(object sender, EventArgs e)
        {
            //MainForm frm = new MainForm(CusNumTB.Text);
            //frm.Show();

            if (CusNumTB.Text == "" || PinTB.Text == "")
            {
                MessageBox.Show("Please provide CustomerNumber and PIN");
                return;
            }
            try
            {

                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from CustomerInfo where CustomerNum=@customernum and PIN=@pin", con);
                cmd.Parameters.AddWithValue("@customernum", CusNumTB.Text);
                cmd.Parameters.AddWithValue("@pin", PinTB.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    MainForm fm = new MainForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CusNumTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PinTB_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
