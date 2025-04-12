using DAL;
using System.Data;

namespace FishingApp.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ISqlHelper SqlHelper;

        public LocationRepository(ISqlHelper sqlHelper)
        {
            SqlHelper = sqlHelper;
        }
        public DataTable GetDataTable(string Query)
        {
            return SqlHelper.GetDataTable(Query);
        }
    }
}
