
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
    public partial class ownerForm : Form
    {
        public ownerForm()
        {
            InitializeComponent();
        }

        private void orderBookText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); // connection string establishes connection to specifc server using hostname, port number, database name, userid and password 
            NpgsqlConnection pconnect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); //need another connection to server for 2nd sql command where i get publisher name
            connect.Open(); //opens the connection to server
            string query = "SELECT isbn, bookname, authorname, genre, publisherid, yearpublished, numpages, bookprice, quantity FROM bookshop.books "; //beginning of string query
            string condition = "WHERE "; //will append to this within my if statements
            bool sw = false; //a check. used when user specifies >1 search field. eg. if they search by isbn, they we should add 'and' after, to the sql string. 

            if (ISBNText.Text != "")
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "isbn = " + ISBNText.Text + "'";
            }

            if (bookTitleText.Text != "")
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "bookname = '" + bookTitleText.Text + "'";
            }

            if (authorText.Text != "")
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "authorname = '" + authorText.Text + "'";
            }

            if (genreText.Text != "")
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "genre = '" + genreText.Text + "'";
            }

            if (publisherNameText.Text != "") //when user wants to search by publisher field.
            {
                if (sw) //true when user has already searched by other fields, false otherwise.
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                int pid;
                pconnect.Open();   //opening the pconnect connection to the database. 
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT publisherid FROM bookshop.publishers WHERE publishername = '" + publisherNameText.Text + "'", pconnect); //get the publisherid from the row that has the same 
                NpgsqlDataReader rd = cmd.ExecuteReader();                                                                   //publishername that the user entered in the publisherName text box
                if (rd.Read()) //if there is another row, execute body of if-statement, starts from position before the first row. checks for 1st row.
                {
                    pid = rd.GetInt32(0);
                }
                else
                {
                    pid = -1;
                }
                condition += "publisherid = " + pid.ToString(); //gets the publisherid given the publisher name that the user searched for.
                pconnect.Close(); //closes the pconnect connection
            }

            if (yearIncludedCheck.Checked) //since i've given the numericdowndowns default values, if the user wants to search using that field, they can check the checkboxes
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "yearpublished <= " + yearPublishedNumeric.Value.ToString();
            }

            if (maxPagesCheck.Checked)
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "numpages <= " + maxNumPagesNumeric.Value.ToString();
            }

            if (maxBookPriceCheck.Checked)
            {
                if (sw)
                {
                    //query += ", ";
                    condition += "and ";
                }
                sw = true;
                condition += "bookprice <= " + maxBookPriceNumeric.Value.ToString();
            }

            if (sw) //entering this if statement means that the user entered at least 1 option in the search field to search by.
            {
                NpgsqlCommand bookcommand = new NpgsqlCommand(query + condition, connect);  //find a book based on all the fields the user was interested in using the sql command string in books table.
                NpgsqlDataReader reader = bookcommand.ExecuteReader(); //executes the sql code in the 
                DataTable dt = new DataTable();
                dt.Columns.Add("ISBN"); //adding a column to the dt called ISBN. doing that for everything!
                dt.Columns.Add("Title");
                dt.Columns.Add("Author");
                dt.Columns.Add("Genre");
                dt.Columns.Add("Publisher");
                dt.Columns.Add("Year Published");
                dt.Columns.Add("Number of Pages");
                dt.Columns.Add("Price");
                dt.Columns.Add("Quantity");

                while (reader.Read())//reads the next row in the books table until there are no more rows.
                {
                    DataRow dr = dt.NewRow(); //creates a new row in the datatable
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT publishername FROM bookshop.publishers WHERE publisherid = '" + reader.GetInt32(4).ToString() + "'", pconnect);
                    pconnect.Open();
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    string pname = "unknown";
                    if (rd.Read())
                    {
                        pname = rd.GetString(0);
                    }

                    dr["ISBN"] = reader.GetInt32(0);
                    dr["Title"] = reader.GetString(1);
                    dr["Author"] = reader.GetString(2);
                    dr["Genre"] = reader.GetString(3);
                    dr["Publisher"] = pname;
                    dr["Year Published"] = reader.GetInt32(5);
                    dr["Number of Pages"] = reader.GetInt32(6);
                    dr["Price"] = Math.Round(reader.GetDouble(7), 2);
                    dr["Quantity"] = reader.GetInt32(8);
                    dt.Rows.Add(dr);
                    //rd.Close();
                    pconnect.Close();
                }
                bookListView.DataSource = dt;//in the booklistview element in the books page. set the data tha bookListView is displaying using the '.DataSource 'object. sets it to dt. which is all the row information.
                //bookListView.DataBind();
                //bookListView.Update();
            }
            else
            {
                MessageBox.Show("You need to specify at least one field for the search!");  //no fields
            }

            connect.Close();
         */   
        }

        
        private void insertButton_Click(object sender, EventArgs e)
        {
            /*
            NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); // connection string establishes connection to specifc server using hostname, port number, database name, userid and password 
            //NpgsqlConnection pconnect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); //need another connection to server for 2nd sql command where i get publisher name
            connect.Open(); //opens the connection to server
            string query = "INSERT INTO book.books ("; //beginning of string query
            string condition = "VALUES ("; //will append to this within my if statements
            bool sw = false; //a check. used when user specifies >1 search field. eg. if they search by isbn, they we should add 'and' after, to the sql string. 

            if (ISBNText.Text != "")
            {
                if (sw)
                {
                    query += ", ";
                    condition += ", ";
                }
                sw = true;
                query += "isbn";
                condition += "'" + ISBNText.Text + "'";
            }
            else
            {
                MessageBox.Show("Isbn cannot be empty!");
            }

            if (bookTitleText.Text != "")
            {
                if (sw)
                {
                    query += ", ";
                    condition += ", ";
                }
                sw = true;
                query += "bookname";
                condition += "'" + bookTitleText.Text + "'";
            }
            else
            {
                MessageBox.Show("bookname cannot be empty!");
            }

            if (bookPriceText.Text != "")
            {
                if (sw)
                {
                    query += ", ";
                    condition += ", ";
                }
                sw = true;
                query += "bookprice";
                condition += "'" + bookPriceText.Text + "'";
            }
            else
            {
                MessageBox.Show("bookprice cannot be empty!");
            }

            if (quantityText.Text != "")
            {
                if (sw)
                {
                    query += ", ";
                    condition += ", ";
                }
                sw = true;
                query += "quantity";
                condition += "'" + quantityText.Text + "'";
            } 
            else
            {
                MessageBox.Show("quantity cannot be empty!");
            }


            //other ifs for the other fields that are allowed to be empty. 

            //inserting to the database
            query += ") ";
            condition += ");";
            NpgsqlCommand bookcommand = new NpgsqlCommand(query + condition, connect);
            bookcommand.ExecuteNonQuery();
            connect.Close();
            */
        }
        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /*
            if (bookListView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No book is selected to be removed");
            }
            else
            {
                string isbn = bookListView.SelectedRows[0].Cells["ISBN"].Value.ToString();
                bookListView.Rows.RemoveAt(bookListView.SelectedRows[0].Index);
                NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); // connection string establishes connection to specifc server using hostname, port number, database name, userid and password 
                connect.Open(); //opens the connection to server
                NpgsqlCommand bookcommand = new NpgsqlCommand("DELETE FROM bookshop.books WHERE isbn = " + isbn, connect);
                bookcommand.ExecuteNonQuery();
                connect.Close();
            }
            */
        }
    }
}
