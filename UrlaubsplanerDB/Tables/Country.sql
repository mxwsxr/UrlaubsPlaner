﻿CREATE TABLE [dbo].[Country]
(
	[CountryID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Code] NVARCHAR(5) NOT NULL
)
