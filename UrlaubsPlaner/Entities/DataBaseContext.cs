using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public class DataBaseContext : IDisposable
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=UrlaubsPlanerDB;Trusted_Connection=True;";

        private SqlConnection SqlConnection { get; set; }

        public DataBaseContext()
        {
            SqlConnection = new SqlConnection(ConnectionString);
        }

        public void Dispose()
        {
            SqlConnection.Dispose();
        }
    }
}