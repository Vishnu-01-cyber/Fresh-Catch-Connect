namespace FishingApp.Model
{
   
    public class CustomerRequestData
    {
        public string FishName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int FishPrice { get; set; }

    }
    public class CustomerData: CustomerRequestData
    {
        public int FishId { get; set; }
    }
}
