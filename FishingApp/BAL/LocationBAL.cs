using DAL;
using FishingApp.Mapper;
using FishingApp.Model;
using FishingApp.Repository;
using System.Data;

namespace FishingApp.BAL
{
    public class LocationBAL : ILocationBAL
    {
        private readonly ILocationRepository locationRepository;
        LocationMapper mapper = new LocationMapper();

        public LocationBAL(ILocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
        }
        public List<Country> GetCountryDetails()
        {
            string query = mapper.GetAllCountryDetails;
            List<Country> countries = new List<Country>();
            DataTable dataTable = locationRepository.GetDataTable(query);
            countries = mapper.GetCountryDetails(dataTable);
            return countries;
        }

        public List<District> GetDistrictDetails()
        {
            string Query = mapper.GetAllDistrictDetails;
            List<District> districts = new List<District>();
            DataTable dataTable = locationRepository.GetDataTable(Query);
            districts = mapper.GetDistrictDetails(dataTable);
            return districts;
        }

        public List<State> GetStateDetails()
        {
            string Query = mapper.GetAllStateDetails;
            List<State> states = new List<State>();
            DataTable dataTable = locationRepository.GetDataTable(Query);
            states = mapper.GetStateDetails(dataTable);
            return states;
        }
    }
}
