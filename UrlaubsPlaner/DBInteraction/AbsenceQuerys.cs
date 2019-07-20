using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class AbsenceQuerys
    {
        public static readonly string GETABSENCES = @"SELECT [AbscenceID]
      ,[AbsenceTypeID]
      ,[EmployeeID]
      ,[FromDate]
      ,[ToDate]
      ,[Reason]
  FROM [dbo].[Absence]";

        public static readonly string GETABSENCESWHEREEMPLOYEE = 
            GETABSENCES + @" WHERE [EmployeeID] = @EmployeeID";
    }
}
