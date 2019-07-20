﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

If EXISTS (Select * FROM [dbo].Country WHERE Name='Deutschland')
BEGIN
	INSERT INTO [dbo].Country (CountryID,Name,Code)
	VALUES (NEWID(),'Deutschland','DE')
END


If EXISTS (Select * FROM [dbo].AbscenceType WHERE Label='Urlaub')
BEGIN
	INSERT INTO [dbo].AbscenceType(AbsenceTypeID,Label)
	VALUES (NEWID(),'Urlaub')
END

If EXISTS (Select * FROM [dbo].AbscenceType WHERE Label='Krankmeldung')
BEGIN
	INSERT INTO [dbo].AbscenceType(AbsenceTypeID,Label)
	VALUES (NEWID(),'Krankmeldung')
END

If EXISTS (Select * FROM [dbo].AbscenceType WHERE Label='Hochschule/BS')
BEGIN
	INSERT INTO [dbo].AbscenceType(AbsenceTypeID,Label)
	VALUES (NEWID(),'Hochschule/BS')
END