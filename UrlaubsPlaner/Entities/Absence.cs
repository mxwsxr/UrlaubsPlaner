using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public class Absence : IEntity
    {
        public Guid AbsenceID { get; set; }
        public AbsenceType AbsenceType { get; set; }
        public Employee Employee { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Reason { get; set; }

        public string TableName => "Absence";

        public Absence()
        {
        }
    }
}