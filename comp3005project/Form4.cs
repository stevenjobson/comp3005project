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
    public partial class completeOrder : Form
    {
        public completeOrder()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //setup conenction to server
            //create query string
            //open connection
            //send query to server with npgsqlcommand using what we know which is the username from the 1st form (can we access that?)
            //read the 2 cells of interest from the view (shipping and billing address)
            //if the text in the text box is the same as the text in the database, 

            //string s = Form1.Controls[];


            if (billingText.Text != "" && shippingText.Text != "")
            {
                NpgsqlConnection connect = new NpgsqlConnection(@"Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");
                NpgsqlConnection conn1 = new NpgsqlConnection(@"Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");

                string query = "SELECT shippinginfo, billinginfo FROM bookshop.users WHERE shippinginfo = '" + shippingText.Text + "' and billinginfo = '" + billingText.Text + "'";
                connect.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) //means we were able to find a record with the same billing and shipping info, no need to add a new record. just wish the customer a good day and fulfill their order!
                {
                    if (reader.GetString(0) == shippingText.Text && reader.GetString(1) == billingText.Text)
                    {
                        MessageBox.Show("Order Complete!");
                        //not finished here. need to give the user their unique tracking number (order_id)
                    }
                } else
                {
                    //otherwise, the user still entered billing and shipping info, it just happens that it's different from what we have in the database.
                    //add this info to a new record with a different userid but all the same other information! THIS COULD CAUSE PROBLEMS WITH MY OTHER QUERIES
                    //since i would have multiple records with most of the same informatin except different userid's, shipping and billing information

                    //for now assume you don't have to create a new tuple in the database and just tell the user that their order is complete!
                    MessageBox.Show("Congrulations! Your order is complete!");
                }

                reader.Close();
                connect.Close();

                //check if the number of books is less than 10 in the database, if it is, get the publsiher's email and send them an email!
                NpgsqlConnection qconnect = new NpgsqlConnection(@"Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");
                qconnect.Open();
                query = "SELECT isbn FROM bookshop.books WHERE quantity < 10";
                NpgsqlCommand qcommand = new NpgsqlCommand(query, qconnect);
                NpgsqlDataReader qreader = qcommand.ExecuteReader();
                if (qreader.Read())
                {
                    
                    int isbn = qreader.GetInt32(0);
                    //use isbn from the query in another sql string to get publisheremail. then just say in a messagebox "email for x amt of books sent to publisher.
                    //problem: x is the number of books sold in the last month... how to solve?
                    MessageBox.Show("Ordering books from publisher");

                } else
                {
                    MessageBox.Show("Error");
                }

            } 
            else
            {
                MessageBox.Show("You must enter a billing and shipping address to complete order!");
            }
        }

        private void completeOrder_Load(object sender, EventArgs e)
        {
            //read the number of rows from the order table again. call it orderid
            //'select bookid, quantity from orders where orderid = orderid

        }
    }
}

