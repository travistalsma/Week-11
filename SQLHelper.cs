//Take a paragraph (4-7 sentences) to describe what unit testing is and what its benefits are.
//Unit testing is to write a program that tests a certain method or class. A method is written and executed to see if the code
//functions correctly and provides the desired result. This process improves the quality of the code and helps to ensure the code
//is bug free. This process also simplifies maintenance and allows for code refactoring without the need to consider that something
//may break. It is impossible to create a complex product without proper unit testing. 

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm
{
    public static class SQLHelper
    {
        //Opens a connection to our data source and adjusts the balance of the checking account by an amount listed in the
        //textbox. Once executed the connection closes. 
        public static void WithdrawChecking(int textBox1)
        {
            string dataSource;
            SqlConnection connection;
            dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Travis\OneDrive\Desktop\Homework\CIS 135\Week 8-9\Midterm\CustomerData.mdf"";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(dataSource);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String query = String.Empty;

            query = "Update AccountData set Balance = Balance - '"+textBox1+"' where AccountNum = 11111";
            command = new SqlCommand(query, connection);

            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        //Opens a connection to our data source and loads the balance of the checking account into the listbox. 
        //Once executed the connection closes. 
        public static List<Account> ViewCheckingBalance()
        {
            List<Account> balanceList = new List<Account>();

            string dataSource;
            SqlConnection connection;
            dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Travis\OneDrive\Desktop\Homework\CIS 135\Week 8-9\Midterm\CustomerData.mdf"";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(dataSource);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String query = String.Empty;

            //select balance from account data where account num = checking num show in listbox.
            //Tried with select *
            //tried without where
            query = "Select Balance from AccountData where AccountNum = 11111";
            command = new SqlCommand(query, connection);

            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            //list has no items?
            //balanceList.Add();

            command.Dispose();
            connection.Close();

            return balanceList;
        }

        //Opens a connection to our data source and adjusts the balance of the savings account by an amount listed in the
        //textbox. Once executed the connection closes. 
        public static void WithdrawSavings(int textBox1)
        {
            string dataSource;
            SqlConnection connection;
            dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Travis\OneDrive\Desktop\Homework\CIS 135\Week 8-9\Midterm\CustomerData.mdf"";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(dataSource);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String query = String.Empty;

            query = "Update AccountData set Balance = Balance - '"+textBox1+"' where AccountNum = 11112";
            command = new SqlCommand(query, connection);

            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        //Opens a connection to our data source and loads the balance of the savings account into the listbox. 
        //Once executed the connection closes.
        public static List<Account> ViewSavingBalance()
        {
            List<Account> balanceList = new List<Account>();
            
            string dataSource;
            SqlConnection connection;
            dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Travis\OneDrive\Desktop\Homework\CIS 135\Week 8-9\Midterm\CustomerData.mdf"";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(dataSource);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String query = String.Empty;

            query = "Select Balance from AccountData where AccountNum = 11112";
            command = new SqlCommand(query, connection);

            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            //balanceList.Add();

            command.Dispose();
            connection.Close();

            return balanceList;
        }

        //Opens a connection to our data source and adjusts the balance of the checking account by an amount listed in the
        //textbox and adds it to the savings account. Once executed the connection closes. 
        public static void TransferCheckToSave(int textBox1)
        {
            string dataSource;
            SqlConnection connection;
            dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Travis\OneDrive\Desktop\Homework\CIS 135\Week 8-9\Midterm\CustomerData.mdf"";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(dataSource);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String query = String.Empty;

            query = "Update AccountData set Balance = Balance - '" + textBox1 + "' where AccountNum = 11111 Update AccountData set Balance = Balance + '" + textBox1 + "' where AccountNum = 11112";
            command = new SqlCommand(query, connection);

            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        //Opens a connection to our data source and adjusts the balance of the savings account by an amount listed in the
        //textbox and adds it to the checking account. Once executed the connection closes. 
        public static void TransferSaveToCheck(int textBox1)
        {
            string dataSource;
            SqlConnection connection;
            dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Travis\OneDrive\Desktop\Homework\CIS 135\Week 8-9\Midterm\CustomerData.mdf"";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(dataSource);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String query = String.Empty;

            query = "Update AccountData set Balance = Balance - '" + textBox1 + "' where AccountNum = 11112 Update AccountData set Balance = Balance + '" + textBox1 + "' where AccountNum = 11111";
            command = new SqlCommand(query, connection);

            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }
    }
}
