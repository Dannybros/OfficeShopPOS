
CREATE TABLE [dbo].[counters](
	[Counter_ID] [nvarchar](20) NOT NULL,
	[Counter_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_counters] PRIMARY KEY CLUSTERED 
(
	[Counter_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[customer](
	[Customer_ID] [nvarchar](20) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Customer_Image] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[supplier](
	[Supplier_ID] [nvarchar](15) NOT NULL,
	[Supplier_Address] [nvarchar](100) NOT NULL,
	[Supplier_Email] [nvarchar](30) NOT NULL,
	[Supplier_Tel] [nvarchar](15) NOT NULL,
	[Supplier_Img] [varbinary](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[employee](
	[Employee_ID] [nvarchar](20) NOT NULL,
	[Employee_Name] [nvarchar](20) NOT NULL,
	[Employee_Phone] [nvarchar](20) NOT NULL,
	[Employee_Email] [nvarchar](20) NOT NULL,
	[Employee_Address] [nvarchar](20) NOT NULL,
	[Emp_Img] [varbinary](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[imports](
	[Order_ID] [nvarchar](20) NOT NULL,
	[Supplier_ID] [nvarchar](15) NOT NULL,
	[Import_Date] [date] NOT NULL,
	[Total] [float] NOT NULL,
	[Checked] [nvarchar](20) NOT NULL,
	FOREIGN KEY (Supplier_ID) REFERENCES supplier(Supplier_ID),
 CONSTRAINT [PK_imports] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[product_categories](
	[Product_Type_ID] [nvarchar](20) NOT NULL,
	[Product_Type_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_product_categories] PRIMARY KEY CLUSTERED 
(
	[Product_Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[products](
	[Product_ID] [nvarchar](20) NOT NULL,
	[Product_Type_ID] [nvarchar](20) NOT NULL,
	[Counter_ID] [nvarchar](20) NOT NULL,
	[Product_Brand] [nvarchar](20) NOT NULL,
	[Size] [nvarchar](20) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Original_Price] [float] NOT NULL,
	[Selling_Price] [float] NOT NULL,
	[Production_Date] [nvarchar](20) NOT NULL,
	[Expiration_Date] [nvarchar](20) NOT NULL,
	[Product_Img] [varbinary](max) NOT NULL,
	FOREIGN KEY (Product_Type_ID) REFERENCES product_categories(Product_Type_ID),
	FOREIGN KEY (Counter_ID) REFERENCES counters(Counter_ID),
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[import_details](
	[Import_No] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID] [nvarchar](20) NOT NULL,
	[Product_ID] [nvarchar](20) NOT NULL,
	[Original_Price] [float] NOT NULL,
	[Amount] [int] NOT NULL,
	[Total_Price] [float] NOT NULL,
	FOREIGN KEY (Order_ID) REFERENCES imports(Order_ID),
	FOREIGN KEY (Product_ID) REFERENCES products(Product_ID),
PRIMARY KEY CLUSTERED 
(
	[Import_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[sale](
	[Sale_ID] [nvarchar](20) NOT NULL,
	[Employee_ID] [nvarchar](20) NOT NULL,
	[Customer_ID] [nvarchar](20) NOT NULL,
	[Total] [float] NOT NULL,
	[Date] [date] NOT NULL,
	FOREIGN KEY (Customer_ID) REFERENCES customer(Customer_ID),
	FOREIGN KEY (Employee_ID) REFERENCES employee(Employee_ID),
PRIMARY KEY CLUSTERED 
(
	[Sale_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[sale_details](
	[Sale_No] [int] IDENTITY(1,1) NOT NULL,
	[Sale_ID] [nvarchar](20) NOT NULL,
	[Product_ID] [nvarchar](20) NOT NULL,
	[Price] [float] NOT NULL,
	[Amount] [int] NOT NULL,
	[Product_Total] [float] NOT NULL,
	FOREIGN KEY (Sale_ID) REFERENCES sale(Sale_ID),
	FOREIGN KEY (Product_ID) REFERENCES products(Product_ID),
PRIMARY KEY CLUSTERED 
(
	[Sale_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

