using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace comp3005project
{
    public partial class bookShop : Form
    {
        double tax = 0.13;
        public bookShop()
        {
            InitializeComponent();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); 
            //this connection is for the query that filters for what attributes the user wants to search by. 
            NpgsqlConnection pconnect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); 
            //need another connection to server for 2nd sql command where i get publisher name, b/c publisherName is in the publisher table not the users table
            //i can go into the 
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
                condition += "isbn = '" + ISBNText.Text + "'";
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
                NpgsqlCommand bookcommand = new NpgsqlCommand(query+condition, connect);  //find a book based on all the fields the user was interested in using the sql command string in books table.
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

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookShop_Load(object sender, EventArgs e)
        {
            /*
            bookListView.Columns.Add("ISBN", "ISBN");
            bookListView.Columns.Add("Title", "Title");
            bookListView.Columns.Add("Author", "Author");
            bookListView.Columns.Add("Genre", "Genre");
            bookListView.Columns.Add("Publisher", "Publisher");
            bookListView.Columns.Add("Year Published", "Year Published");
            bookListView.Columns.Add("Number of Pages", "Number of Pages");
            bookListView.Columns.Add("Price", "Price");
            bookListView.Columns.Add("Quantity", "Quantity");
            */
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cartView.Rows.Count.ToString());
            if (bookListView.SelectedRows.Count != 0)//if the user has selected at least 1 row of books to add to the cart, execute body. otherwise...
            {
                int i, j, qnt = 0;
                for (i = 0; i < bookListView.SelectedRows.Count; i++)//loop through all the books the user selected
                {
                    NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;"); //connect to server
                    //DataGridViewRow row = bookListView.Rows[i];//i think this is wrong! I think it should be bookListView.SelectedRows[i]
                    DataGridViewRow row = bookListView.SelectedRows[i];
                    connect.Open();//open the connection
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT quantity FROM bookshop.books WHERE isbn = " + row.Cells["ISBN"].Value.ToString(), connect);//send the sql query to database
                    NpgsqlDataReader rd = cmd.ExecuteReader();                                                  //get the value of the cell holding isbn information & turn it into a string
                    if (rd.Read())
                    {
                        qnt = rd.GetInt32(0);
                    }
                    rd.Close();
                    connect.Close();
                          
                    if (qnt >= Convert.ToInt32(quantityNumeric.Value))
                    {
                        //adding to the cart
                        bool sw = false;
                        for (j = 0; j < cartView.Rows.Count; j++)
                            
                        {
                            //MessageBox.Show("here0");
                            //!!!
                            //if (sw) { }
                            if (cartView.Rows[j].Cells["ISBN"].Value == row.Cells["ISBN"].Value) //when you want to add more of the same book to the cart. there is already a copy of the book. just updates the quantity and amt to pay 
                            {
                                //MessageBox.Show("here1");
                                cartView.Rows[j].Cells["Quantity"].Value = Convert.ToInt32(cartView.Rows[j].Cells["Quantity"].Value) + Convert.ToInt32(quantityNumeric.Value);
                                cartView.Rows[j].Cells["Amount"].Value = Math.Round(Convert.ToDouble(cartView.Rows[j].Cells["Quantity"].Value) * Convert.ToDouble(cartView.Rows[j].Cells["Price"].Value), 2);
                                subTotalValueLabel.Text = Math.Round((Convert.ToDouble(subTotalValueLabel.Text) + Convert.ToDouble(cartView.Rows[j].Cells["Price"].Value) * Convert.ToDouble(quantityNumeric.Value)), 2).ToString();
                                taxValueLabel.Text = Math.Round((Convert.ToDouble(subTotalValueLabel.Text) * tax), 2).ToString();
                                totalValueLabel.Text = Math.Round((Convert.ToDouble(subTotalValueLabel.Text) + Convert.ToDouble(taxValueLabel.Text)), 2).ToString();
                                sw = true;
                                //MessageBox.Show("here2");
                                break;
                            }
                        }
                        if (!sw)//when you pick a book that isn't already in the cart

                        {
                            //MessageBox.Show("here3");
                            //MessageBox.Show(cartView.Rows.Count.ToString());

                            //MessageBox.Show("here5");
                            int ind = cartView.Rows.Add();
                            //cartView.Columns[0].Name = "ISBN";
                            cartView.Rows[ind].Cells["ISBN"].Value = row.Cells["ISBN"].Value.ToString();
                            cartView.Rows[ind].Cells["Title"].Value = row.Cells["Title"].Value.ToString();
                            cartView.Rows[ind].Cells["Price"].Value = (row.Cells["Price"].Value).ToString();
                            cartView.Rows[ind].Cells["Quantity"].Value = quantityNumeric.Value;
                            double amount = Convert.ToDouble(row.Cells["Price"].Value) * Convert.ToDouble(quantityNumeric.Value);
                            cartView.Rows[ind].Cells["Amount"].Value = Math.Round(amount, 2).ToString();
                            /*ORIGINAL:
                            cartView.Rows[ind].Cells["ISBN"] = row.Cells["ISBN"];
                            cartView.Rows[ind].Cells["Title"] = row.Cells["Title"];
                            cartView.Rows[ind].Cells["Price"] = row.Cells["Price"];
                            cartView.Rows[ind].Cells["Quantity"].Value = quantityNumeric.Value;
                            cartView.Rows[ind].Cells["Amount"].Value = Convert.ToDouble(row.Cells["Price"]) * Convert.ToDouble(quantityNumeric);
                            */

                            subTotalValueLabel.Text = Math.Round((Convert.ToDouble(subTotalValueLabel.Text) + Convert.ToDouble(cartView.Rows[ind].Cells["Price"].Value) * Convert.ToDouble(quantityNumeric.Value)), 2).ToString();
                            taxValueLabel.Text = Math.Round((Convert.ToDouble(subTotalValueLabel.Text) * tax), 2).ToString();
                            totalValueLabel.Text = Math.Round((Convert.ToDouble(subTotalValueLabel.Text) + Convert.ToDouble(taxValueLabel.Text)), 2).ToString();

                            if (cartView.Rows.Count == 1) //cartView hasn't been initialized that's why there are no rows.
                            {
                                //another solution//////////////////////////////////////
                                /*
                                cartView.Columns[0].Name = "ISBN";
                                cartView.Columns[1].Name = "Title";
                                cartView.Columns[2].Name = "Price";
                                cartView.Columns[3].Name = "Quantity";
                                cartView.Columns[4].Name = "Amount";

                                string[] cartRow = { row.Cells["ISBN"].ToString(), row.Cells["Title"].ToString(), row.Cells["Price"].ToString(), quantityNumeric.Value.ToString(), (Convert.ToDouble(row.Cells["Price"]) * Convert.ToDouble(quantityNumeric)).ToString()};
                                object[] row1 = new object[] { cartRow };
                                foreach (string[] rowArray in row1)
                                {
                                    cartView.Rows.Add(rowArray);
                                }
                                MessageBox.Show("here5.9");
                                */
                                ///////////////////////////////////////////////////////
                                
                                //MessageBox.Show("here6");
                            }

                            

                        }

                        //updating the table and the database

                        //updates the bookListView
                        row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) - Convert.ToInt32(quantityNumeric.Value);

                        connect.Open(); //updates the database
                        NpgsqlCommand ucmd = new NpgsqlCommand("UPDATE bookshop.books SET quantity = " + row.Cells["Quantity"].Value.ToString() + " WHERE isbn = " + row.Cells["ISBN"].Value.ToString(), connect);
                        //NpgsqlDataReader rd = cmd.ExecuteReader();
                        ucmd.ExecuteNonQuery();
                        connect.Close();

                    } 
                    else
                    {
                        MessageBox.Show("Not enough copies available of " + row.Cells["Title"] + " in the bookshop!");
                    }
                      
                }
            }
            else //when user clicks add to cart but they haven't selected an element to add
            {
                MessageBox.Show("No book is selected!");
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //(1) check if book row is selected
            //ask user to fill out 'complete order form' 
            //user must fill in billing and shipping info, if the 
            //user gives an alternate billing and shipping info, add a new row with this information
            //(2) tell user to choose a book row to check out

            //orders table has orderid, isbn, userid, etc
            //loop through all rows in cartlist
            //add a row for each book in the cart list to the orders table in the database, open a connection and use an insert
            //command and add it to the orders table in the database
            //must generate an order number sequentially. easiest way to do that is to read the number of rows of the order table with a 'select from the bookshop.orders'
            //and add 1 to it. 
            //query to read number of rows in table in sql with 'Select count(*) from orders;'


            this.Hide();//hides the current forms
            completeOrder cof = new completeOrder(); //creates a new instance of complete order 
            cof.ShowDialog();//shows the completeorder form


        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //(1)check if the user clicked any books to remove in the cartview, for EACH BOOK
            
            NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");
            
            
            if (cartView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No book is selected to be removed from the cart");
            }
            else if (Convert.ToInt32(cartView.SelectedRows[0].Cells["Quantity"].Value) < Convert.ToInt32(quantityNumeric.Value))
            {
                MessageBox.Show("There are not enough copies of this book in the cart, check the quantity value.");
            }
            else
            {
                for (int g = 0; g < bookListView.Rows.Count; g++)
                {
                    if (bookListView.Rows[g].Cells["ISBN"].Value == cartView.SelectedRows[0].Cells["ISBN"].Value)
                    {

                        bookListView.Rows[g].Cells["Quantity"].Value = Convert.ToInt32(bookListView.Rows[g].Cells["Quantity"].Value) + Convert.ToInt32(quantityNumeric.Value);
                        
                    }

                }

                double pr = Convert.ToDouble(cartView.SelectedRows[0].Cells["Price"].Value);
                string isbn = cartView.SelectedRows[0].Cells["ISBN"].Value.ToString();

                if (Convert.ToInt32(cartView.SelectedRows[0].Cells["Quantity"].Value) == Convert.ToInt32(quantityNumeric.Value)) //means we have to remove item from cart 
                {
                    cartView.Rows.RemoveAt(cartView.SelectedRows[0].Index);//remove row completely 
                }
                else
                {
                    cartView.SelectedRows[0].Cells["Quantity"].Value = Convert.ToInt32(cartView.SelectedRows[0].Cells["Quantity"].Value) - Convert.ToInt32(quantityNumeric.Value);
                    cartView.SelectedRows[0].Cells["Amount"].Value = Math.Round(Convert.ToDouble(cartView.SelectedRows[0].Cells["Quantity"].Value) * Convert.ToDouble(cartView.SelectedRows[0].Cells["Price"].Value), 2).ToString();
                }
                subTotalValueLabel.Text = Math.Round(Convert.ToDouble(Convert.ToDouble(subTotalValueLabel.Text) - Convert.ToDouble(quantityNumeric.Value) * pr), 2).ToString();
                taxValueLabel.Text = Math.Round(Convert.ToDouble(subTotalValueLabel.Text) * tax, 2).ToString();
                totalValueLabel.Text = Math.Round(Convert.ToDouble(subTotalValueLabel.Text) + Convert.ToDouble(taxValueLabel.Text), 2).ToString();

                connect.Open(); //updates the database
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT quantity FROM bookshop.books WHERE isbn = " + isbn , connect);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                int newqnt = 0;
                if (rd.Read())
                {
                    newqnt = rd.GetInt32(0);
                }
                connect.Close();
                newqnt = newqnt - Convert.ToInt32(quantityNumeric.Value);
                connect.Open();
                NpgsqlCommand ucmd = new NpgsqlCommand("UPDATE bookshop.books SET quantity = " + newqnt.ToString() + " WHERE isbn = " + isbn , connect);
                //NpgsqlDataReader rd = cmd.ExecuteReader();
                ucmd.ExecuteNonQuery();
                connect.Close();
            }


            /*
            if (cartView.SelectedRows.Count > 0)
            {

                for (i = 0; i < cartView.Rows.Count; i++) {
                    //(1.1) check if the quantity is 1
                    //need another check to see if user selceted the row to remove
                    if (cartView.Rows[i].Selected) //i probably don't need the larger if statement now
                    {
                        //string isbnOfSBook = cartView.Rows[i].Cells["ISBN"].Value.ToString();

                        //get the quantity from the booklistview table
                        //for loop through the booklistview checking the quantity in the cartView row with 
                        //the quantity in the bookListView
                        //if the quantities match, stroe the isbn and the quantity for the row in the booklistview.
                        
                        for (int g = 0; g < bookListView.Rows.Count; g++)
                        {
                            if (bookListView.Rows[g].Cells["ISBN"].Value == cartView.Rows[i].Cells["ISBN"].Value)
                            {
                                
                                isbn = bookListView.Rows[g].Cells["ISBN"].Value.ToString();
                                quantity = bookListView.Rows[g].Cells["Quantity"].Value.ToString();

                                MessageBox.Show(isbn);
                                MessageBox.Show(quantity);
                                
                            }
                            
                        }
                        

                        
                        string query = "UPDATE bookshop.books SET quantity = '" + quantity + "' WHERE isbn = '" + isbn + "'";
                        connect.Open();
                        NpgsqlCommand command = new NpgsqlCommand(query, connect);
                        command.ExecuteNonQuery();
                        connect.Close();
                        

                        //trying to update the database.


                        if (Convert.ToInt32(cartView.Rows[i].Cells["Quantity"].Value) == 1)
                        {
                            MessageBox.Show("Here1");

                            //add 1 to the quantity to the corresponding book in the booklistview

                            //loop through the selected rows of the cartview, i
                            //loop through the rows of the bookview, j
                            //if the isbn cell of the row in the cartview is the same as the isbn cell of the row in the booklistview, 
                            //add 1 to the quantity cell of the row in the booklistview

                            
                            for (int b = 0; b < bookListView.Rows.Count; b++)
                            {
                                if (bookListView.Rows[b].Cells["ISBN"].Value == cartView.Rows[i].Cells["ISBN"].Value)
                                {
                                    bookListView.Rows[b].Cells["Quantity"].Value = Convert.ToInt32(cartView.Rows[i].Cells["Quantity"].Value) + 1;
                                }
                            }
                            


                            //remove the entire row 

                            //IGNORE:the quantity in the database should increase by 1. 
                            //IGNORE:the prices should update
                            //update the rows. move every row after the deleted row up by one position

                            k = i;//problems here! MAJOR PROBLEM! I STILL NEED i LATER
                            for (j = i + 1; j < cartView.Rows.Count; j++)
                            {
                                cartView.Rows[k].Cells["ISBN"].Value = cartView.Rows[j].Cells["ISBN"].Value;
                                cartView.Rows[k].Cells["Title"].Value = cartView.Rows[j].Cells["Title"].Value;
                                cartView.Rows[k].Cells["Price"].Value = cartView.Rows[j].Cells["Price"].Value;
                                cartView.Rows[k].Cells["Quantity"].Value = cartView.Rows[j].Cells["Quantity"].Value;
                                cartView.Rows[k].Cells["Amount"].Value = cartView.Rows[j].Cells["Amount"].Value;
                                k++;
                            }

                            //update the booklistview here


                            

                            //so after this. the row that was selected which had a quantity of 1 book will be deleted. 
                            //all the other rows with books will move up 1 row. In the bookListView the quantity will increase by 1.


                        }

                        //(1.2) check if the quantity is greater than 1
                        if (Convert.ToInt32(cartView.Rows[i].Cells["Quantity"].Value) > 1)
                        {
                            MessageBox.Show("here2");
                            //reduce the quantity of the book in cartview by 1
                            cartView.Rows[i].Cells["Quantity"].Value = Convert.ToInt32(cartView.Rows[i].Cells["Quantity"].Value) - 1;
                            //IGNORE:increase the quantity tuple in the database by 1.
                            //IGNORE:update prices

                            
                            for (int b = 0; b < bookListView.Rows.Count; b++)
                            {
                                if (bookListView.Rows[b].Cells["ISBN"].Value == cartView.Rows[i].Cells["ISBN"].Value)
                                {
                                    bookListView.Rows[b].Cells["Quantity"].Value = Convert.ToInt32(cartView.Rows[i].Cells["Quantity"].Value) + 1;
                                }
                            }
                            

                        }

                        //the quantity in the booklistview should increase by 1.

                        for (int b = 0; b < bookListView.Rows.Count; b++)
                        {
                            //MessageBox.Show("value of b" + b.ToString());
                            if (bookListView.Rows[b].Cells["ISBN"].Value == cartView.Rows[i].Cells["ISBN"].Value)
                            {
                                //MessageBox.Show("value of b" + b.ToString());
                                bookListView.Rows[b-1].Cells["Quantity"].Value = Convert.ToInt32(bookListView.Rows[b-1].Cells["Quantity"].Value) + 1;
                            }
                        }

                        //MessageBox.Show("here3");

                        //to make the query i need to know the isbn of the book that i want to add 1 to, 
                        //loop through the booklistview and check if the isbn of the 

                        //NpgsqlConnection connect = new NpgsqlConnection("Server=localhost; Port=5432; Database=bookstore; User Id=postgres; Password=H*i5*9y;");
                        //connect.Open();

                        string query = "UPDATE bookshop.books SET quantity = '" + quantity + "' WHERE isbn = '" + isbn + "'";
                        connect.Open();
                        NpgsqlCommand command = new NpgsqlCommand(query, connect);
                        command.ExecuteNonQuery();
                        connect.Close();

                        //connect.Close();


                        //the quantity in the database view should increase by 1 

                        //the prices should update
                    }
                    


                }


            }

            else
            {
                //(2) if not, tell them to
                MessageBox.Show("You didn't select any items the cart to Remove!");
            }
            */
           

        }
    }
}

//loop through all the selected rows in the cartListView that the user decided to checkout.
//check if the quantity is less than 10. if it is, send an email to the publisher of the books for the same number of books as the user checked out
//this means for the selectedRow in the cartListView I need to use the book's isbn to find publisher email (create a connection for that with a query for that information)
//update the database's quantity by getting the quantity that was in the cartListView's row quantity cell. add that to the database's quantity. need another connection for that.
//select quantity from bookshop.books where isbn = ' + cartListView.selectedRows.Cells["ISBN"]