Create Database ACMEINC_Database

Create Table Tbl_Category (
Category_Id Int Identity Primary Key,
Category_Name Varchar(500) Unique,
IsActive Bit Null,
IsDelete Bit Null
)

Create Table Tbl_Product (
Product_Id Int Identity Primary Key,
Product_Name Varchar(500) Unique,
Category_Id Int,
IsActive Bit Null,
IsDelete Bit Null,
Created_Date DateTime Null,
Modified_Date DateTime Null,
Description DateTime Null,
Product_Image Varchar(max),
IsFeatured Bit Null,
Quantity Int,
Foreign Key (Category_Id) References Tbl_Category(Category_Id)
)

Create Table Tbl_CartStatus (
CartStatus_Id Int Identity Primary Key,
CartStatus Varchar(500)
)

Create Table Tbl_Members (
Member_Id Int Identity Primary Key,
First_Name Varchar(200),
Last_Name Varchar(200) Unique,
Email_Id Varchar(200) Unique,
Password Varchar(500),
IsActive Bit Null,
IsDeleted Bit Null,
CreatedOn DateTime,
ModifiedOn DateTime
)

Create Table Tbl_ShippingDetails (
ShippingDetails_Id Int Identity Primary Key,
Member_Id Int,
Address Varchar(500),
City Varchar(500),
State Varchar(500),
Country Varchar(50),
ZipCode Varchar(50),
Order_Id Int,
Amount_Paid Decimal,
Payment_Type Varchar(50),
Foreign Key (Member_Id) References Tbl_Members(Member_Id)
)

Create Table Tbl_Roles (
Role_Id Int Identity Primary Key,
Role_Name Varchar(200) Unique
)

Create Table Tbl_Cart (
Cart_Id Int Identity Primary Key,
Product_Id Int,
Member_Id Int,
CartStatus_Id Int,
Foreign Key (Product_Id) References Tbl_Product(Product_Id)
)

Create Table Tbl_MemberRole (
MemberRole_Id Int Identity Primary Key,
Member_Id Int,
Role_Id Int
)

Create Table Tbl_SlideImage (
Slide_Id Int Identity Primary Key,
Slide_Title Varchar(500),
Slide_Image Varchar(max)
)