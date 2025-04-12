using System.Data;

namespace FishingApp.Repository
{
    public interface ILocationRepository
    {
        DataTable GetDataTable(string Query);
    }
}
