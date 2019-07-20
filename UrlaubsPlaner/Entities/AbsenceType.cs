using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public class AbsenceType : IEntity
    {
        public Guid AbsenceTypeId { get; set; }
        public string Label { get; set; }

        public AbsenceType()
        {
        }
    }
}