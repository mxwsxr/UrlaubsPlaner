using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.CalendarTypes
{
    public class AbsenceInput
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int EmployeeId { get; set; }
        public string AbsenceType { get; set; }
    }
}