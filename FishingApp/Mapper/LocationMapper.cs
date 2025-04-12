using FishingApp.Model;
using System.Data;
using System.Diagnostics.Metrics;

namespace FishingApp.Mapper
{
    public class LocationMapper
    {
        public string GetAllCountryDetails = "select*from Country";
        public string GetAllStateDetails = "select*from State";
        public string GetAllDistrictDetails = "select*from District";

        public List<Country> GetCountryDetails(DataTable dataTable)
        {
           List<Country> country = new List<Country>();

            foreach (DataRow item in dataTable.Rows)
            {
                country.Add(new Country
                {
                    SNo = (int)item["SNo"],
                    CountryName = (string)item["CountryName"]
                }); 
            }
           return country;
        }
        public List<State> GetStateDetails(DataTable dataTable)
        {
            List<State> state = new List<State>();

            foreach (DataRow item in dataTable.Rows)
            {
                state.Add(new State
                {
                    SNo = (int)item["SNo"],
                    ParentID = (int)item["ParentID"],
                    StateName = (string)item["StateName"]
                });
            }
              return state;
        }
        public List<District> GetDistrictDetails(DataTable dataTable)
        {
            List<District> district = new List<District>();

            foreach (DataRow item in dataTable.Rows)
            {
                district.Add(new District
                {
                    SNo = (int)item["SNo"],
                    ChildID = (int)item["ChildID"],
                    DistrictName = (string)item["DistrictName"]
                });
            }
              return district;
        }
    }
}
