using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class EmployeeQuerys
    {
        public static readonly string GETEMPLOYEES = @"SELECT [EmployeeID]
      ,[EmployeeNumber]
      ,[CountryID]
      ,[Firstname]
      ,[Lastname]
      ,[Birthday]
      ,[Street]
      ,[Housenumber]
      ,[Postalcode]
      ,[City]
      ,[Phonenumber]
      ,[Email]
  FROM [dbo].[Employee]";
    }
}
