/*
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

If NOT EXISTS (Select * FROM [dbo].Country WHERE Name='Deutschland')
BEGIN
	INSERT INTO [dbo].Country (CountryID,Name,Code)
	VALUES (NEWID(),'Deutschland','DE')
END


If NOT EXISTS (Select * FROM [dbo].AbsenceType WHERE Label='Urlaub')
BEGIN
	INSERT INTO [dbo].AbsenceType (AbsenceTypeID,Label)
	VALUES (NEWID(),'Urlaub')
END

If NOT EXISTS (Select * FROM [dbo].AbsenceType WHERE Label='Krankmeldung')
BEGIN
	INSERT INTO [dbo].AbsenceType (AbsenceTypeID,Label)
	VALUES (NEWID(),'Krankmeldung')
END

If NOT EXISTS (Select * FROM [dbo].AbsenceType WHERE Label='Hochschule/BS')
BEGIN
	INSERT INTO [dbo].AbsenceType (AbsenceTypeID,Label)
	VALUES (NEWID(),'Hochschule/BS')
END