//using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlHelper : ISqlHelper
    {
        private readonly string connectionString;

        public SqlHelper(string ConnectionString)
        {
            connectionString = ConnectionString;
        }

        public int ExecuteNonQuery(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(Query,sqlConnection);
            int s = sqlCommand.ExecuteNonQuery();
            return s;
        }

        public int ExecuteScalar(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            int q = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return q;
        }

        public DataTable GetDataTable(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}