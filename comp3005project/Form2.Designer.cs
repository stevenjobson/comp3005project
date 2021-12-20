namespace comp3005project
{
    partial class bookShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.yearPublishedLabel = new System.Windows.Forms.Label();
            this.maxNumPagesLabel = new System.Windows.Forms.Label();
            this.maxBookPagesLabel = new System.Windows.Forms.Label();
            this.ISBNText = new System.Windows.Forms.TextBox();
            this.bookTitleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.publisherNameText = new System.Windows.Forms.TextBox();
            this.yearPublishedNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxNumPagesNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxBookPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.bookListView = new System.Windows.Forms.DataGridView();
            this.cartLabel = new System.Windows.Forms.Label();
            this.bookListLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.yearIncludedCheck = new System.Windows.Forms.CheckBox();
            this.maxPagesCheck = new System.Windows.Forms.CheckBox();
            this.maxBookPriceCheck = new System.Windows.Forms.CheckBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalValueLabel = new System.Windows.Forms.Label();
            this.taxValueLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.cartView = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.yearPublishedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumPagesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBookPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.Location = new System.Drawing.Point(48, 75);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(83, 36);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book Title";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.Location = new System.Drawing.Point(48, 39);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(83, 36);
            this.ISBNlabel.TabIndex = 2;
            this.ISBNlabel.Text = "ISBN";
            this.ISBNlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ISBNlabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.Location = new System.Drawing.Point(48, 111);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(83, 36);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(48, 147);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(83, 36);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.genreLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // publisherLabel
            // 
            this.publisherLabel.Location = new System.Drawing.Point(48, 183);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(83, 36);
            this.publisherLabel.TabIndex = 2;
            this.publisherLabel.Text = "Publisher Name";
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.publisherLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // yearPublishedLabel
            // 
            this.yearPublishedLabel.Location = new System.Drawing.Point(23, 219);
            this.yearPublishedLabel.Name = "yearPublishedLabel";
            this.yearPublishedLabel.Size = new System.Drawing.Size(119, 36);
            this.yearPublishedLabel.TabIndex = 2;
            this.yearPublishedLabel.Text = "Published before Year";
            this.yearPublishedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yearPublishedLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // maxNumPagesLabel
            // 
            this.maxNumPagesLabel.Location = new System.Drawing.Point(23, 255);
            this.maxNumPagesLabel.Name = "maxNumPagesLabel";
            this.maxNumPagesLabel.Size = new System.Drawing.Size(108, 36);
            this.maxNumPagesLabel.TabIndex = 2;
            this.maxNumPagesLabel.Text = "Max Number Pages";
            this.maxNumPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maxNumPagesLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // maxBookPagesLabel
            // 
            this.maxBookPagesLabel.Location = new System.Drawing.Point(48, 291);
            this.maxBookPagesLabel.Name = "maxBookPagesLabel";
            this.maxBookPagesLabel.Size = new System.Drawing.Size(83, 36);
            this.maxBookPagesLabel.TabIndex = 2;
            this.maxBookPagesLabel.Text = "Max Book Price";
            this.maxBookPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maxBookPagesLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // ISBNText
            // 
            this.ISBNText.Location = new System.Drawing.Point(152, 48);
            this.ISBNText.Name = "ISBNText";
            this.ISBNText.Size = new System.Drawing.Size(100, 20);
            this.ISBNText.TabIndex = 3;
            // 
            // bookTitleText
            // 
            this.bookTitleText.Location = new System.Drawing.Point(152, 84);
            this.bookTitleText.Name = "bookTitleText";
            this.bookTitleText.Size = new System.Drawing.Size(100, 20);
            this.bookTitleText.TabIndex = 3;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(152, 120);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(100, 20);
            this.authorText.TabIndex = 3;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(152, 156);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 20);
            this.genreText.TabIndex = 3;
            // 
            // publisherNameText
            // 
            this.publisherNameText.Location = new System.Drawing.Point(152, 192);
            this.publisherNameText.Name = "publisherNameText";
            this.publisherNameText.Size = new System.Drawing.Size(100, 20);
            this.publisherNameText.TabIndex = 3;
            // 
            // yearPublishedNumeric
            // 
            this.yearPublishedNumeric.Location = new System.Drawing.Point(152, 229);
            this.yearPublishedNumeric.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.yearPublishedNumeric.Minimum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.yearPublishedNumeric.Name = "yearPublishedNumeric";
            this.yearPublishedNumeric.Size = new System.Drawing.Size(100, 20);
            this.yearPublishedNumeric.TabIndex = 4;
            this.yearPublishedNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearPublishedNumeric.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // maxNumPagesNumeric
            // 
            this.maxNumPagesNumeric.Location = new System.Drawing.Point(152, 265);
            this.maxNumPagesNumeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.maxNumPagesNumeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maxNumPagesNumeric.Name = "maxNumPagesNumeric";
            this.maxNumPagesNumeric.Size = new System.Drawing.Size(100, 20);
            this.maxNumPagesNumeric.TabIndex = 4;
            this.maxNumPagesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxNumPagesNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // maxBookPriceNumeric
            // 
            this.maxBookPriceNumeric.Location = new System.Drawing.Point(152, 301);
            this.maxBookPriceNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxBookPriceNumeric.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxBookPriceNumeric.Name = "maxBookPriceNumeric";
            this.maxBookPriceNumeric.Size = new System.Drawing.Size(100, 20);
            this.maxBookPriceNumeric.TabIndex = 4;
            this.maxBookPriceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxBookPriceNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // bookListView
            // 
            this.bookListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListView.Location = new System.Drawing.Point(315, 48);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(536, 453);
            this.bookListView.TabIndex = 5;
            // 
            // cartLabel
            // 
            this.cartLabel.Location = new System.Drawing.Point(864, 9);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(83, 36);
            this.cartLabel.TabIndex = 2;
            this.cartLabel.Text = "Cart";
            this.cartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cartLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // bookListLabel
            // 
            this.bookListLabel.Location = new System.Drawing.Point(312, 9);
            this.bookListLabel.Name = "bookListLabel";
            this.bookListLabel.Size = new System.Drawing.Size(83, 36);
            this.bookListLabel.TabIndex = 2;
            this.bookListLabel.Text = "Book List";
            this.bookListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookListLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(159, 468);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(93, 33);
            this.addToCartButton.TabIndex = 7;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(159, 519);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(93, 33);
            this.checkoutButton.TabIndex = 7;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(36, 519);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(106, 33);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove From Cart";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // yearIncludedCheck
            // 
            this.yearIncludedCheck.AutoSize = true;
            this.yearIncludedCheck.Location = new System.Drawing.Point(38, 342);
            this.yearIncludedCheck.Name = "yearIncludedCheck";
            this.yearIncludedCheck.Size = new System.Drawing.Size(207, 17);
            this.yearIncludedCheck.TabIndex = 8;
            this.yearIncludedCheck.Text = "Year Published Included in the Search";
            this.yearIncludedCheck.UseVisualStyleBackColor = true;
            // 
            // maxPagesCheck
            // 
            this.maxPagesCheck.AutoSize = true;
            this.maxPagesCheck.Location = new System.Drawing.Point(38, 381);
            this.maxPagesCheck.Name = "maxPagesCheck";
            this.maxPagesCheck.Size = new System.Drawing.Size(264, 17);
            this.maxPagesCheck.TabIndex = 8;
            this.maxPagesCheck.Text = "Maximum Number of Pages included in the Search";
            this.maxPagesCheck.UseVisualStyleBackColor = true;
            // 
            // maxBookPriceCheck
            // 
            this.maxBookPriceCheck.AutoSize = true;
            this.maxBookPriceCheck.Location = new System.Drawing.Point(38, 416);
            this.maxBookPriceCheck.Name = "maxBookPriceCheck";
            this.maxBookPriceCheck.Size = new System.Drawing.Size(235, 17);
            this.maxBookPriceCheck.TabIndex = 8;
            this.maxBookPriceCheck.Text = "Maximum Book Price Included in the Search";
            this.maxBookPriceCheck.UseVisualStyleBackColor = true;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(887, 445);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(83, 36);
            this.subTotalLabel.TabIndex = 2;
            this.subTotalLabel.Text = "SubTotal";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subTotalLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(887, 481);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(83, 36);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taxLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(887, 519);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(83, 36);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // subTotalValueLabel
            // 
            this.subTotalValueLabel.Location = new System.Drawing.Point(1335, 445);
            this.subTotalValueLabel.Name = "subTotalValueLabel";
            this.subTotalValueLabel.Size = new System.Drawing.Size(83, 36);
            this.subTotalValueLabel.TabIndex = 2;
            this.subTotalValueLabel.Text = "0.00";
            this.subTotalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subTotalValueLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // taxValueLabel
            // 
            this.taxValueLabel.Location = new System.Drawing.Point(1335, 481);
            this.taxValueLabel.Name = "taxValueLabel";
            this.taxValueLabel.Size = new System.Drawing.Size(83, 36);
            this.taxValueLabel.TabIndex = 2;
            this.taxValueLabel.Text = "0.00";
            this.taxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taxValueLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Location = new System.Drawing.Point(1335, 519);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(83, 36);
            this.totalValueLabel.TabIndex = 2;
            this.totalValueLabel.Text = "0.00";
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalValueLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.Location = new System.Drawing.Point(312, 516);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(83, 36);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quantityLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(401, 526);
            this.quantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(100, 20);
            this.quantityNumeric.TabIndex = 4;
            this.quantityNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cartView
            // 
            this.cartView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Price,
            this.Quantity,
            this.Amount});
            this.cartView.Location = new System.Drawing.Point(890, 48);
            this.cartView.MultiSelect = false;
            this.cartView.Name = "cartView";
            this.cartView.Size = new System.Drawing.Size(528, 368);
            this.cartView.TabIndex = 9;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // bookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 564);
            this.Controls.Add(this.cartView);
            this.Controls.Add(this.maxBookPriceCheck);
            this.Controls.Add(this.maxPagesCheck);
            this.Controls.Add(this.yearIncludedCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.bookListView);
            this.Controls.Add(this.maxBookPriceNumeric);
            this.Controls.Add(this.maxNumPagesNumeric);
            this.Controls.Add(this.quantityNumeric);
            this.Controls.Add(this.yearPublishedNumeric);
            this.Controls.Add(this.publisherNameText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.bookTitleText);
            this.Controls.Add(this.ISBNText);
            this.Controls.Add(this.maxBookPagesLabel);
            this.Controls.Add(this.maxNumPagesLabel);
            this.Controls.Add(this.yearPublishedLabel);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxValueLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalValueLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.bookListLabel);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.ISBNlabel);
            this.Controls.Add(this.bookNameLabel);
            this.Name = "bookShop";
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.bookShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearPublishedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumPagesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBookPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label yearPublishedLabel;
        private System.Windows.Forms.Label maxNumPagesLabel;
        private System.Windows.Forms.Label maxBookPagesLabel;
        private System.Windows.Forms.TextBox ISBNText;
        private System.Windows.Forms.TextBox bookTitleText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox publisherNameText;
        private System.Windows.Forms.NumericUpDown yearPublishedNumeric;
        private System.Windows.Forms.NumericUpDown maxNumPagesNumeric;
        private System.Windows.Forms.NumericUpDown maxBookPriceNumeric;
        private System.Windows.Forms.DataGridView bookListView;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label bookListLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckBox yearIncludedCheck;
        private System.Windows.Forms.CheckBox maxPagesCheck;
        private System.Windows.Forms.CheckBox maxBookPriceCheck;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalValueLabel;
        private System.Windows.Forms.Label taxValueLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.DataGridView cartView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}