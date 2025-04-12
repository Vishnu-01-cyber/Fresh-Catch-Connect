using DAL;
using System.Data;

namespace FishingApp.Repository
{
    public class SellerRepository : ISellerRepository
    {
        private readonly ISqlHelper sqlHelper;

        public SellerRepository(ISqlHelper sqlHelper)
        {
            this.sqlHelper = sqlHelper;
        }
        public DataTable DataTable(string Query)
        {
            return sqlHelper.GetDataTable(Query);
        }

        public int ExecuteNonQuery(string Query)
        {
            return sqlHelper.ExecuteNonQuery(Query);
        }

        public int ExecuteScalar(string Query)
        {
            return sqlHelper.ExecuteScalar(Query);
        }
    }
}
