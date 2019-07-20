using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlaubsPlaner.DBInteraction;

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

        private T QueryData<T>(Querys query)
            where T : IEntity
        {

        }

        public void Dispose()
        {
            SqlConnection.Dispose();
        }
    }
}