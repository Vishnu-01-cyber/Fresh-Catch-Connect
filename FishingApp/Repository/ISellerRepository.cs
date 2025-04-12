using System.Data;

namespace FishingApp.Repository
{
    public interface ISellerRepository
    {
        int ExecuteNonQuery(string Query);

        int ExecuteScalar(string Query);
        DataTable DataTable(string Query);
    }
}
