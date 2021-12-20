namespace comp3005project
{
    partial class ownerForm
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
            this.publisherTab = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.publisherPhoneNumberLabel = new System.Windows.Forms.Label();
            this.publisherBankAccLabel = new System.Windows.Forms.Label();
            this.publisherEmailLabel = new System.Windows.Forms.Label();
            this.publisherAddressLabel = new System.Windows.Forms.Label();
            this.publisherNameLabel = new System.Windows.Forms.Label();
            this.publisherIdLabel = new System.Windows.Forms.Label();
            this.removeBooksLabel = new System.Windows.Forms.Label();
            this.publisherEmailText = new System.Windows.Forms.TextBox();
            this.publisherPhoneNumberText = new System.Windows.Forms.TextBox();
            this.publisherBankAccText = new System.Windows.Forms.TextBox();
            this.publisherAddressText = new System.Windows.Forms.TextBox();
            this.publisherNameText = new System.Windows.Forms.TextBox();
            this.publisherIdText = new System.Windows.Forms.TextBox();
            this.orderBookLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderBookText = new System.Windows.Forms.TextBox();
            this.maxBookPriceCheck = new System.Windows.Forms.CheckBox();
            this.maxPagesCheck = new System.Windows.Forms.CheckBox();
            this.yearIncludedCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.bookListView = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.bookTitleText = new System.Windows.Forms.TextBox();
            this.ISBNText = new System.Windows.Forms.TextBox();
            this.maxBookPagesLabel = new System.Windows.Forms.Label();
            this.maxNumPagesLabel = new System.Windows.Forms.Label();
            this.yearPublishedLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookListLabel = new System.Windows.Forms.Label();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearPublishedNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.maxNumPagesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maxBookPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.bookPriceText = new System.Windows.Forms.TextBox();
            this.numberPageText = new System.Windows.Forms.TextBox();
            this.publishedYearText = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.publisherTab.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearPublishedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumPagesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBookPriceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // publisherTab
            // 
            this.publisherTab.Controls.Add(this.booksTab);
            this.publisherTab.Controls.Add(this.tabPage2);
            this.publisherTab.Location = new System.Drawing.Point(12, 12);
            this.publisherTab.Name = "publisherTab";
            this.publisherTab.SelectedIndex = 0;
            this.publisherTab.Size = new System.Drawing.Size(1144, 622);
            this.publisherTab.TabIndex = 6;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.publishedYearText);
            this.booksTab.Controls.Add(this.numberPageText);
            this.booksTab.Controls.Add(this.quantityText);
            this.booksTab.Controls.Add(this.bookPriceText);
            this.booksTab.Controls.Add(this.maxBookPriceCheck);
            this.booksTab.Controls.Add(this.maxPagesCheck);
            this.booksTab.Controls.Add(this.yearIncludedCheck);
            this.booksTab.Controls.Add(this.button1);
            this.booksTab.Controls.Add(this.deleteButton);
            this.booksTab.Controls.Add(this.checkoutButton);
            this.booksTab.Controls.Add(this.insertButton);
            this.booksTab.Controls.Add(this.bookListView);
            this.booksTab.Controls.Add(this.maxBookPriceNumeric);
            this.booksTab.Controls.Add(this.maxNumPagesNumeric);
            this.booksTab.Controls.Add(this.yearPublishedNumeric);
            this.booksTab.Controls.Add(this.textBox2);
            this.booksTab.Controls.Add(this.genreText);
            this.booksTab.Controls.Add(this.authorText);
            this.booksTab.Controls.Add(this.bookTitleText);
            this.booksTab.Controls.Add(this.label3);
            this.booksTab.Controls.Add(this.ISBNText);
            this.booksTab.Controls.Add(this.quantityLabel);
            this.booksTab.Controls.Add(this.maxBookPagesLabel);
            this.booksTab.Controls.Add(this.label2);
            this.booksTab.Controls.Add(this.label1);
            this.booksTab.Controls.Add(this.maxNumPagesLabel);
            this.booksTab.Controls.Add(this.yearPublishedLabel);
            this.booksTab.Controls.Add(this.publisherLabel);
            this.booksTab.Controls.Add(this.genreLabel);
            this.booksTab.Controls.Add(this.authorLabel);
            this.booksTab.Controls.Add(this.bookListLabel);
            this.booksTab.Controls.Add(this.ISBNlabel);
            this.booksTab.Controls.Add(this.bookNameLabel);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(1136, 596);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            this.booksTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.publisherPhoneNumberLabel);
            this.tabPage2.Controls.Add(this.publisherBankAccLabel);
            this.tabPage2.Controls.Add(this.publisherEmailLabel);
            this.tabPage2.Controls.Add(this.publisherAddressLabel);
            this.tabPage2.Controls.Add(this.publisherNameLabel);
            this.tabPage2.Controls.Add(this.publisherIdLabel);
            this.tabPage2.Controls.Add(this.removeBooksLabel);
            this.tabPage2.Controls.Add(this.publisherEmailText);
            this.tabPage2.Controls.Add(this.publisherPhoneNumberText);
            this.tabPage2.Controls.Add(this.publisherBankAccText);
            this.tabPage2.Controls.Add(this.publisherAddressText);
            this.tabPage2.Controls.Add(this.publisherNameText);
            this.tabPage2.Controls.Add(this.publisherIdText);
            this.tabPage2.Controls.Add(this.orderBookLabel);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.orderBookText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Publishers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // publisherPhoneNumberLabel
            // 
            this.publisherPhoneNumberLabel.Location = new System.Drawing.Point(112, 318);
            this.publisherPhoneNumberLabel.Name = "publisherPhoneNumberLabel";
            this.publisherPhoneNumberLabel.Size = new System.Drawing.Size(136, 36);
            this.publisherPhoneNumberLabel.TabIndex = 14;
            this.publisherPhoneNumberLabel.Text = "publisher Phone Number";
            this.publisherPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherBankAccLabel
            // 
            this.publisherBankAccLabel.Location = new System.Drawing.Point(112, 282);
            this.publisherBankAccLabel.Name = "publisherBankAccLabel";
            this.publisherBankAccLabel.Size = new System.Drawing.Size(136, 36);
            this.publisherBankAccLabel.TabIndex = 15;
            this.publisherBankAccLabel.Text = "publisher Bank Acc no.";
            this.publisherBankAccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherEmailLabel
            // 
            this.publisherEmailLabel.Location = new System.Drawing.Point(132, 246);
            this.publisherEmailLabel.Name = "publisherEmailLabel";
            this.publisherEmailLabel.Size = new System.Drawing.Size(89, 36);
            this.publisherEmailLabel.TabIndex = 16;
            this.publisherEmailLabel.Text = "Publisher Email";
            this.publisherEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherAddressLabel
            // 
            this.publisherAddressLabel.Location = new System.Drawing.Point(129, 210);
            this.publisherAddressLabel.Name = "publisherAddressLabel";
            this.publisherAddressLabel.Size = new System.Drawing.Size(101, 36);
            this.publisherAddressLabel.TabIndex = 17;
            this.publisherAddressLabel.Text = "Publisher Address";
            this.publisherAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherNameLabel
            // 
            this.publisherNameLabel.Location = new System.Drawing.Point(138, 174);
            this.publisherNameLabel.Name = "publisherNameLabel";
            this.publisherNameLabel.Size = new System.Drawing.Size(83, 36);
            this.publisherNameLabel.TabIndex = 18;
            this.publisherNameLabel.Text = "Publisher Name";
            this.publisherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherIdLabel
            // 
            this.publisherIdLabel.Location = new System.Drawing.Point(138, 138);
            this.publisherIdLabel.Name = "publisherIdLabel";
            this.publisherIdLabel.Size = new System.Drawing.Size(83, 36);
            this.publisherIdLabel.TabIndex = 19;
            this.publisherIdLabel.Text = "Publisher Id";
            this.publisherIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBooksLabel
            // 
            this.removeBooksLabel.Location = new System.Drawing.Point(138, 65);
            this.removeBooksLabel.Name = "removeBooksLabel";
            this.removeBooksLabel.Size = new System.Drawing.Size(83, 36);
            this.removeBooksLabel.TabIndex = 20;
            this.removeBooksLabel.Text = "Remove Books";
            this.removeBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherEmailText
            // 
            this.publisherEmailText.Location = new System.Drawing.Point(263, 255);
            this.publisherEmailText.Name = "publisherEmailText";
            this.publisherEmailText.Size = new System.Drawing.Size(100, 20);
            this.publisherEmailText.TabIndex = 6;
            // 
            // publisherPhoneNumberText
            // 
            this.publisherPhoneNumberText.Location = new System.Drawing.Point(263, 327);
            this.publisherPhoneNumberText.Name = "publisherPhoneNumberText";
            this.publisherPhoneNumberText.Size = new System.Drawing.Size(100, 20);
            this.publisherPhoneNumberText.TabIndex = 7;
            // 
            // publisherBankAccText
            // 
            this.publisherBankAccText.Location = new System.Drawing.Point(263, 291);
            this.publisherBankAccText.Name = "publisherBankAccText";
            this.publisherBankAccText.Size = new System.Drawing.Size(100, 20);
            this.publisherBankAccText.TabIndex = 8;
            // 
            // publisherAddressText
            // 
            this.publisherAddressText.Location = new System.Drawing.Point(263, 219);
            this.publisherAddressText.Name = "publisherAddressText";
            this.publisherAddressText.Size = new System.Drawing.Size(100, 20);
            this.publisherAddressText.TabIndex = 9;
            // 
            // publisherNameText
            // 
            this.publisherNameText.Location = new System.Drawing.Point(263, 183);
            this.publisherNameText.Name = "publisherNameText";
            this.publisherNameText.Size = new System.Drawing.Size(100, 20);
            this.publisherNameText.TabIndex = 10;
            // 
            // publisherIdText
            // 
            this.publisherIdText.Location = new System.Drawing.Point(263, 147);
            this.publisherIdText.Name = "publisherIdText";
            this.publisherIdText.Size = new System.Drawing.Size(100, 20);
            this.publisherIdText.TabIndex = 11;
            // 
            // orderBookLabel
            // 
            this.orderBookLabel.Location = new System.Drawing.Point(138, 29);
            this.orderBookLabel.Name = "orderBookLabel";
            this.orderBookLabel.Size = new System.Drawing.Size(83, 36);
            this.orderBookLabel.TabIndex = 21;
            this.orderBookLabel.Text = "Order Books";
            this.orderBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // orderBookText
            // 
            this.orderBookText.Location = new System.Drawing.Point(263, 38);
            this.orderBookText.Name = "orderBookText";
            this.orderBookText.Size = new System.Drawing.Size(100, 20);
            this.orderBookText.TabIndex = 13;
            // 
            // maxBookPriceCheck
            // 
            this.maxBookPriceCheck.AutoSize = true;
            this.maxBookPriceCheck.Location = new System.Drawing.Point(593, 549);
            this.maxBookPriceCheck.Name = "maxBookPriceCheck";
            this.maxBookPriceCheck.Size = new System.Drawing.Size(235, 17);
            this.maxBookPriceCheck.TabIndex = 35;
            this.maxBookPriceCheck.Text = "Maximum Book Price Included in the Search";
            this.maxBookPriceCheck.UseVisualStyleBackColor = true;
            // 
            // maxPagesCheck
            // 
            this.maxPagesCheck.AutoSize = true;
            this.maxPagesCheck.Location = new System.Drawing.Point(593, 501);
            this.maxPagesCheck.Name = "maxPagesCheck";
            this.maxPagesCheck.Size = new System.Drawing.Size(264, 17);
            this.maxPagesCheck.TabIndex = 34;
            this.maxPagesCheck.Text = "Maximum Number of Pages included in the Search";
            this.maxPagesCheck.UseVisualStyleBackColor = true;
            // 
            // yearIncludedCheck
            // 
            this.yearIncludedCheck.AutoSize = true;
            this.yearIncludedCheck.Location = new System.Drawing.Point(593, 459);
            this.yearIncludedCheck.Name = "yearIncludedCheck";
            this.yearIncludedCheck.Size = new System.Drawing.Size(207, 17);
            this.yearIncludedCheck.TabIndex = 33;
            this.yearIncludedCheck.Text = "Year Published Included in the Search";
            this.yearIncludedCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(42, 519);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 33);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(165, 519);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(93, 33);
            this.checkoutButton.TabIndex = 30;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(165, 468);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(93, 33);
            this.insertButton.TabIndex = 29;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // bookListView
            // 
            this.bookListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListView.Location = new System.Drawing.Point(321, 39);
            this.bookListView.MultiSelect = false;
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(536, 394);
            this.bookListView.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(158, 156);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 20);
            this.genreText.TabIndex = 22;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(158, 120);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(100, 20);
            this.authorText.TabIndex = 21;
            // 
            // bookTitleText
            // 
            this.bookTitleText.Location = new System.Drawing.Point(158, 84);
            this.bookTitleText.Name = "bookTitleText";
            this.bookTitleText.Size = new System.Drawing.Size(100, 20);
            this.bookTitleText.TabIndex = 20;
            // 
            // ISBNText
            // 
            this.ISBNText.Location = new System.Drawing.Point(158, 48);
            this.ISBNText.Name = "ISBNText";
            this.ISBNText.Size = new System.Drawing.Size(100, 20);
            this.ISBNText.TabIndex = 19;
            // 
            // maxBookPagesLabel
            // 
            this.maxBookPagesLabel.Location = new System.Drawing.Point(54, 291);
            this.maxBookPagesLabel.Name = "maxBookPagesLabel";
            this.maxBookPagesLabel.Size = new System.Drawing.Size(83, 36);
            this.maxBookPagesLabel.TabIndex = 17;
            this.maxBookPagesLabel.Text = "Book Price";
            this.maxBookPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxNumPagesLabel
            // 
            this.maxNumPagesLabel.Location = new System.Drawing.Point(29, 255);
            this.maxNumPagesLabel.Name = "maxNumPagesLabel";
            this.maxNumPagesLabel.Size = new System.Drawing.Size(108, 36);
            this.maxNumPagesLabel.TabIndex = 16;
            this.maxNumPagesLabel.Text = "Number of Pages";
            this.maxNumPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearPublishedLabel
            // 
            this.yearPublishedLabel.Location = new System.Drawing.Point(29, 219);
            this.yearPublishedLabel.Name = "yearPublishedLabel";
            this.yearPublishedLabel.Size = new System.Drawing.Size(119, 36);
            this.yearPublishedLabel.TabIndex = 15;
            this.yearPublishedLabel.Text = "Published Year";
            this.yearPublishedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherLabel
            // 
            this.publisherLabel.Location = new System.Drawing.Point(54, 183);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(83, 36);
            this.publisherLabel.TabIndex = 13;
            this.publisherLabel.Text = "Publisher Name";
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(54, 147);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(83, 36);
            this.genreLabel.TabIndex = 12;
            this.genreLabel.Text = "Genre";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.Location = new System.Drawing.Point(54, 111);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(83, 36);
            this.authorLabel.TabIndex = 11;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookListLabel
            // 
            this.bookListLabel.Location = new System.Drawing.Point(318, 9);
            this.bookListLabel.Name = "bookListLabel";
            this.bookListLabel.Size = new System.Drawing.Size(83, 36);
            this.bookListLabel.TabIndex = 10;
            this.bookListLabel.Text = "Book List";
            this.bookListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.Location = new System.Drawing.Point(54, 39);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(83, 36);
            this.ISBNlabel.TabIndex = 18;
            this.ISBNlabel.Text = "ISBN";
            this.ISBNlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.Location = new System.Drawing.Point(54, 75);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(83, 36);
            this.bookNameLabel.TabIndex = 9;
            this.bookNameLabel.Text = "Book Title";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(319, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Published before Year";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearPublishedNumeric
            // 
            this.yearPublishedNumeric.Location = new System.Drawing.Point(448, 458);
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
            this.yearPublishedNumeric.TabIndex = 24;
            this.yearPublishedNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearPublishedNumeric.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(319, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Max Number Pages";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxNumPagesNumeric
            // 
            this.maxNumPagesNumeric.Location = new System.Drawing.Point(448, 498);
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
            this.maxNumPagesNumeric.TabIndex = 26;
            this.maxNumPagesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxNumPagesNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(344, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Max Book Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxBookPriceNumeric
            // 
            this.maxBookPriceNumeric.Location = new System.Drawing.Point(448, 549);
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
            this.maxBookPriceNumeric.TabIndex = 27;
            this.maxBookPriceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxBookPriceNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // bookPriceText
            // 
            this.bookPriceText.Location = new System.Drawing.Point(158, 300);
            this.bookPriceText.Name = "bookPriceText";
            this.bookPriceText.Size = new System.Drawing.Size(100, 20);
            this.bookPriceText.TabIndex = 36;
            // 
            // numberPageText
            // 
            this.numberPageText.Location = new System.Drawing.Point(158, 264);
            this.numberPageText.Name = "numberPageText";
            this.numberPageText.Size = new System.Drawing.Size(100, 20);
            this.numberPageText.TabIndex = 36;
            // 
            // publishedYearText
            // 
            this.publishedYearText.Location = new System.Drawing.Point(158, 228);
            this.publishedYearText.Name = "publishedYearText";
            this.publishedYearText.Size = new System.Drawing.Size(100, 20);
            this.publishedYearText.TabIndex = 36;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Location = new System.Drawing.Point(54, 347);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(83, 36);
            this.quantityLabel.TabIndex = 17;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(158, 356);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(100, 20);
            this.quantityText.TabIndex = 36;
            // 
            // ownerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 646);
            this.Controls.Add(this.publisherTab);
            this.Name = "ownerForm";
            this.Text = "Owner Page";
            this.publisherTab.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearPublishedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumPagesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBookPriceNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl publisherTab;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label publisherPhoneNumberLabel;
        private System.Windows.Forms.Label publisherBankAccLabel;
        private System.Windows.Forms.Label publisherEmailLabel;
        private System.Windows.Forms.Label publisherAddressLabel;
        private System.Windows.Forms.Label publisherNameLabel;
        private System.Windows.Forms.Label publisherIdLabel;
        private System.Windows.Forms.Label removeBooksLabel;
        private System.Windows.Forms.TextBox publisherEmailText;
        private System.Windows.Forms.TextBox publisherPhoneNumberText;
        private System.Windows.Forms.TextBox publisherBankAccText;
        private System.Windows.Forms.TextBox publisherAddressText;
        private System.Windows.Forms.TextBox publisherNameText;
        private System.Windows.Forms.TextBox publisherIdText;
        private System.Windows.Forms.Label orderBookLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox orderBookText;
        private System.Windows.Forms.CheckBox maxBookPriceCheck;
        private System.Windows.Forms.CheckBox maxPagesCheck;
        private System.Windows.Forms.CheckBox yearIncludedCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView bookListView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox bookTitleText;
        private System.Windows.Forms.TextBox ISBNText;
        private System.Windows.Forms.Label maxBookPagesLabel;
        private System.Windows.Forms.Label maxNumPagesLabel;
        private System.Windows.Forms.Label yearPublishedLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label bookListLabel;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.NumericUpDown maxNumPagesNumeric;
        private System.Windows.Forms.NumericUpDown yearPublishedNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxBookPriceNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publishedYearText;
        private System.Windows.Forms.TextBox numberPageText;
        private System.Windows.Forms.TextBox bookPriceText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label quantityLabel;
    }
}