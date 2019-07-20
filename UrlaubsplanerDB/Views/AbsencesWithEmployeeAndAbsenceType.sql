CREATE VIEW [dbo].[AbsencesWithEmployeeAndAbsenceType]
	AS 
	SELECT a.[AbscenceID]
	  ,a.[FromDate]
      ,a.[ToDate]
      ,a.[Reason]
	  ,e.[EmployeeNumber]
	  ,e.[Firstname]
      ,e.[Lastname]
	  ,t.[Label]
	FROM [dbo].[Absence] as a 
	join [dbo].[Employee] as e on a.[EmployeeID] = e.[EmployeeID]
	join [dbo].[AbsenceType] as t on a.[AbsenceTypeID] = t.[AbsenceTypeID]
