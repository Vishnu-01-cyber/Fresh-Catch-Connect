using System.Data;

namespace FishingApp.Repository
{
    public interface ILoginRepository
    {
        int ExecuteNonQuery(string Query);
        int ExecuteScalar(string Query);

        DataTable GetDataTable(string Query);
    }
}
