using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public static class EntityTransformations
    {
        public static async Task<Absence> TransformAbsence(SqlDataReader dataReader)
        {
            return new Absence()
            {
                AbsenceID = dataReader.GetGuid(0),
                Employee = new Employee()
                {
                    EmployeeId = dataReader.GetGuid(4),
                    EmployeeNumber = dataReader.GetInt32(5),
                    Country = new Country()
                    {
                        CountryId = dataReader.GetGuid(6),
                        Name = dataReader.GetString(7),
                        Code = dataReader.GetString(8)
                    },
                    Firstname = dataReader.GetString(9),
                    Lastname = dataReader.GetString(10),
                    Birthday = await GetValue(11,dataReader, (x,y) => x.GetDateTime(y)),
                    Street = dataReader.GetString(12),
                    Housenumber = dataReader.GetString(13),
                    Postalcode = dataReader.GetString(14),
                    City = dataReader.GetString(15),
                    Phonenumber = dataReader.GetString(16),
                    Email = dataReader.GetString(17)                    
                },
                FromDate = dataReader.GetDateTime(1),
                ToDate = dataReader.GetDateTime(2),
                Reason = dataReader.GetString(3),
                AbsenceType = new AbsenceType() { AbsenceTypeId = dataReader.GetGuid(18), Label = dataReader.GetString(19) }
            };
        }

        private static async Task<T> GetValue<T>(int ordinal, SqlDataReader dataReader, Func<SqlDataReader, int, T> getValue)
            => await dataReader.IsDBNullAsync(ordinal) ? default : getValue(dataReader, ordinal);
    }
}
