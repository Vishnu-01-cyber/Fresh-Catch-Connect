using DAL;
using System.Data;

namespace FishingApp.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ISqlHelper SqlHelper;

        public LoginRepository(ISqlHelper sqlHelper)
        {
            SqlHelper = sqlHelper;
        }
        public int ExecuteNonQuery(string Query)
        {
            return SqlHelper.ExecuteNonQuery(Query);
        }

        public int ExecuteScalar(string Query)
        {
            return SqlHelper.ExecuteScalar(Query);
        }

        public DataTable GetDataTable(string Query)
        {
            return SqlHelper.GetDataTable(Query);
        }
    }
}
