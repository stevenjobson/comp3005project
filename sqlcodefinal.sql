--please note the path of my database tables follows:
--PostgresSQL13->Databases->bookstore->Schemas->Tables

--creating the books table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables->books
CREATE TABLE IF NOT EXISTS bookshop.books
(
    isbn bigint NOT NULL DEFAULT nextval('bookshop.books_isbn_seq'::regclass),
    bookname character varying(100) COLLATE pg_catalog."default" NOT NULL,
    authorname character varying(100) COLLATE pg_catalog."default",
    genre character varying(50) COLLATE pg_catalog."default",
    publisherid integer,
    yearpublished integer,
    numpages integer,
    bookprice real NOT NULL,
    quantity integer NOT NULL,
    CONSTRAINT books_pkey PRIMARY KEY (isbn)
)

--creating the makesOrder table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables->makesOrders
CREATE TABLE IF NOT EXISTS bookshop."makesOrder"
(
    isbn bigint NOT NULL,
    ownerid integer NOT NULL,
    quantity integer NOT NULL,
    CONSTRAINT "makesOrder_pkey" PRIMARY KEY (isbn, ownerid)
)

--creating the orders table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables->orders
CREATE TABLE IF NOT EXISTS bookshop.orders
(
    isbn bigint NOT NULL,
    userid integer NOT NULL,
    orderid integer NOT NULL,
    date date NOT NULL,
    quantity integer NOT NULL,
    itemprice real NOT NULL,
    shippinginfo character varying(100) COLLATE pg_catalog."default" NOT NULL,
    billinginfo character varying(100) COLLATE pg_catalog."default" NOT NULL,
    currentlocation character varying(100) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT orders_pkey PRIMARY KEY (isbn, userid, orderid)
)

--creating the owners table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables->owners
CREATE TABLE IF NOT EXISTS bookshop.owners
(
    ownerid integer NOT NULL,
    ownername character varying(50) COLLATE pg_catalog."default" NOT NULL,
    dateofbirth date NOT NULL,
    usertype integer,
    password character varying(50) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT owners_pkey PRIMARY KEY (ownerid)
)

--creating the publishers table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables->publishers
CREATE TABLE IF NOT EXISTS bookshop.publishers
(
    publisherid integer NOT NULL,
    publishername character varying(100) COLLATE pg_catalog."default" NOT NULL,
    address character varying(100) COLLATE pg_catalog."default",
    email character varying(30) COLLATE pg_catalog."default",
    bankingaccountnumber character varying(30) COLLATE pg_catalog."default",
    phonenumber bigint,
    CONSTRAINT publishers_pkey PRIMARY KEY (publisherid)
)

--creating the publishers table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables->publishers
CREATE TABLE IF NOT EXISTS bookshop.publishes
(
    isbn bigint NOT NULL,
    publisherid integer NOT NULL,
    publisherpercentage real NOT NULL,
    CONSTRAINT publishes_pkey PRIMARY KEY (isbn, publisherid)
)


--creating the users table--
--destination: PostgresSQL13->Databases->bookstore->Schemas->Tables-users
CREATE TABLE IF NOT EXISTS bookshop.users
(
    userid integer NOT NULL,
    shippinginfo character varying(100) COLLATE pg_catalog."default",
    billinginfo character varying(100) COLLATE pg_catalog."default",
    username character varying(20) COLLATE pg_catalog."default" NOT NULL,
    usertype integer,
    dateofbirth date NOT NULL,
    password character varying(50) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT users_pkey PRIMARY KEY (userid)
)

--after creating a connection to my database server, I send a sql query

"SELECT userName, password FROM bookshop.users WHERE userName = '" + userNameText.Text + "'"

--when the user enters their name filter by the name they entered and see if it matches the username we have on record
--if the table being returned is empty we know that they aren't a valid user. 
--otherwise they are a valid user. now we check if their password matches the password they gave us, if it doesn't
