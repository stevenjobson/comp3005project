using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace comp3005project
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        /*
        private static void TestConnection()
        {
            using 
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            //connect to the server by creating a new connection and using the hostname, portnumber, database name, userid for the database and password 
            NpgsqlConnection connect = new NpgsqlConnection(@"Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");

            connect.Open(); //open the connection
            if (connect.State == ConnectionState.Open) //checks if the connection is open, if true, we know that we've connected our code to the server.
            {
                MessageBox.Show("successfully connected.");
            }
            connect.Close();//close the connection.
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");
            connect.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT userName, password FROM bookshop.users WHERE userName = '" + userNameText.Text + "'", connect);
            
            NpgsqlDataReader reader = command.ExecuteReader();//executes query and places result of query into reader

            bool rs = reader.Read(); //true when we've got a row in the table given by reader

            //WE ENTER THIS IF STATEMENT IF THERE ISN'T A ROW IN THE TABLE TO READ FROM
            if (!rs)//if there wasn't a row to read from the reader that means there wasn't any username or password stored in the users table that matched the username and password that the person logging in, entered.
            {          //meaning we cannot connect to the database for user to buy books since user isn't registered.
                MessageBox.Show("Connection Error, cannot connect to the database!"); 
            }
            else if (reader.GetString(1) != passwordText.Text) { //when the password doesn't match means its not a user, but it could be an owner
                //reading from owner table to see if there is an owner with the username and password matching the user's input
                reader.Close();
                connect.Close();
                connect.Open();//create a new connection to send a query to get the username & password from the owners table, to see if the username that user entered was actually the ownerName
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT username, password FROM bookshop.owners WHERE ownername = '" + userNameText.Text + "'", connect);
                NpgsqlDataReader rd = cmd.ExecuteReader();//gets all rows from the owner's table that have an owner's name that matches the name the user entered in the text field
                if (rd.Read()) //true if there is a row in table view of the owner's table 
                {
                    if (rd.GetString(1) == passwordText.Text) // we know that the username's match. now check if the password matches. if the password's match we know 100% that the user is actually an owner.
                    {
                        
                        //this.Hide(); //hide the login page from the user
                        //ownerForm bk = new ownerForm(); //creates a new instance of the ownerForm form called bk
                        //bk.ShowDialog();//shows us the form
                        
                        
                    }
                    else //the username was the same but the password was different, so the person logging in, isn't a user or an owner.
                    {
                        MessageBox.Show("Invalid user name or password.");
                    }
                }
                connect.Close();//close the connection that's checking if the person logging into the bookstore is an owner.
            }
            else //we know that the sql query we sent to the database returned a table of the user's username and password with rows. so the user is registered in the database.
            //the user entered a valid username and password.
            {
                //MessageBox.Show(reader.GetString(1));
                this.Hide(); //this refers to the login page. we're hiding it from the user
                bookShop bk = new bookShop(); //creates a new instance of the bookshop form called bk
                bk.ShowDialog();//shows us the new page!
            }
            

            connect.Close();//close the connection
        }
    }
}
