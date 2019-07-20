CREATE TABLE [dbo].[Employee]
(
	[EmployeeID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [EmployeeNumber] INT NOT NULL, 
    [CountryID] UNIQUEIDENTIFIER NOT NULL, 
    [Firstname] NVARCHAR(255) NOT NULL, 
    [Lastname] NVARCHAR(255) NOT NULL, 
    [Birthday] DATE NULL, 
    [Street] NVARCHAR(255) NOT NULL, 
    [Housenumber] NVARCHAR(255) NOT NULL, 
    [Postalcode] NVARCHAR(255) NOT NULL, 
    [City] NVARCHAR(255) NOT NULL, 
    [Phonenumber] NVARCHAR(255) NOT NULL, 
    [Email] NVARCHAR(255) NOT NULL
)
