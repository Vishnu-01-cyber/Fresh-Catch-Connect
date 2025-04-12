namespace FishingApp.Model
{
    public class Country
    {
        public int SNo { get; set; }
        public string CountryName { get; set; }
    }

    public class State 
    {
        public int SNo { get; set; }
        public int ParentID { get; set; }
        public string StateName { get; set; }
    }

    public class District 
    {
        public int SNo { get; set; }
        public int ChildID { get; set; }
        public string DistrictName { get; set; }
    }

    public class Location
    {
        public List<Country> Countries { get; set; }
        public List<State> States { get; set; }
        public List<District> Districts { get; set; }
    }
}

