using DAL;
using System.Data;

namespace FishingApp.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ISqlHelper sqlHelper;

        public CustomerRepository(ISqlHelper sqlHelper)
        {
            this.sqlHelper = sqlHelper;
        }
        public DataTable GetTable (string Query)
        {
            return sqlHelper.GetDataTable(Query);
        }
    }
}
