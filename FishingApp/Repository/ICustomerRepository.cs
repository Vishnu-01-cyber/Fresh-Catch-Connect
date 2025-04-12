using System.Data;

namespace FishingApp.Repository
{
    public interface ICustomerRepository
    {
        DataTable GetTable(string Query);
    }
}
