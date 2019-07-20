using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.DBInteraction
{
    public static class AbsenceTypeQuerys
    {
        public static readonly string GETABSENCETYPES = @"SELECT [AbsenceTypeID]
      ,[Label]
  FROM [dbo].[AbsenceType]";
    }
}
