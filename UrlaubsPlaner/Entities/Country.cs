using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public class Country
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Country()
        {
        }
    }
}