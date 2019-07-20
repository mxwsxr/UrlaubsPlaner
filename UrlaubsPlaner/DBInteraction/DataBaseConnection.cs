using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner.DBInteraction
{
    public static class DataBaseConnection
    {
        private static readonly string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=UrlaubsPlanerDB;Trusted_Connection=True;";

        private static SqlConnection SqlConnection = new SqlConnection(ConnectionString);

        private static bool IsConnectionOpen { get
            {
                return SqlConnection.State == System.Data.ConnectionState.Open
                    || SqlConnection.State == System.Data.ConnectionState.Connecting;
            }
        }

        public static List<Absence> GetAbsences()
        {
            return GetValuesSynchronously(GetAbsenceAsync);
        }

        public static async Task<List<Absence>> GetAbsenceAsync()
        {
            return await QueryDataAsync(GetSqlCommand(Querys.GetAbsences), EntityTransformations.TransformAbsence);
        }

        public static List<AbsenceType> GetAbsenceTypes()
        {
            return GetValuesSynchronously(GetAbsenceTypesAsync);
        }

        public static async Task<List<AbsenceType>> GetAbsenceTypesAsync()
        {
            return await QueryData(GetSqlCommand(Querys.GetAbsenceTypes), EntityTransformations.TransformAbsenceType);
        }

        private static List<T> GetValuesSynchronously<T>(Func<Task<List<T>>> func)
            where T:IEntity
        {
            var task = Task.Run(async () => await func());
            task.Wait();
            return task.Result;
        }

        private static SqlCommand GetSqlCommand(Querys query)
        {
            switch (query)
            {
                case Querys.GetAbsences:
                    return new SqlCommand(AbsenceQuerys.GETABSENCES);

                case Querys.GetAbsencesWhereEmployee:
                    return new SqlCommand(AbsenceQuerys.GETABSENCESWHEREEMPLOYEE);

                case Querys.GetEmployees:
                    return new SqlCommand(EmployeeQuerys.GETEMPLOYEES);
                    
                case Querys.GetCountrys:
                    return new SqlCommand(CountryQuerys.GETCOUNTRYS);

                case Querys.GetAbsenceTypes:
                    return new SqlCommand(AbsenceTypeQuerys.GETABSENCETYPES);

                case Querys.GetAbsenceView:
                    return new SqlCommand(AbsenceQuerys.GETABSENCEVIEW);

                default:
                    throw new NotImplementedException($"This enum value is not implemented! {query}");
            }
        }

        private static async Task<List<T>> QueryData<T>(SqlCommand sqlCommand, Func<SqlDataReader, T> transformData)
            where T : IEntity
        {
            var resultList = new List<T>();
            sqlCommand.Connection = SqlConnection;
            if (!IsConnectionOpen)
            {
                SqlConnection.Open();
            }
            var dataReader = await sqlCommand.ExecuteReaderAsync();

            while (dataReader.HasRows)
            {
                while (await dataReader.ReadAsync())
                {
                    resultList.Add(transformData(dataReader));
                }
            }

            return resultList;
        }

        private static async Task<List<T>> QueryDataAsync<T>(SqlCommand sqlCommand, Func<SqlDataReader,Task<T>> transformData)
            where T : IEntity
        {
            var resultList = new List<T>();
            sqlCommand.Connection = SqlConnection;
            if (!IsConnectionOpen )
            {
                SqlConnection.Open();
            }
            var dataReader = await sqlCommand.ExecuteReaderAsync();

            while (dataReader.HasRows)
            {
                while (await dataReader.ReadAsync())
                {
                    resultList.Add(await transformData(dataReader));
                }
            }

            return resultList;
        }
    }
}