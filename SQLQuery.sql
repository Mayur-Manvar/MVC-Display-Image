Alter table tblEmployee Add Photo nvarchar(100), AlternateText nvarchar(100)

Update tblEmployee set Photo='~/Images/JohnSmith.png', 
AlternateText = 'John Smith Photo' where Id = 1