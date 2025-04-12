using FishingApp.Model;

namespace FishingApp.BAL
{
    public interface ILocationBAL
    {
       List< Country> GetCountryDetails();

     List<State> GetStateDetails();
       List< District> GetDistrictDetails();
    }
}
