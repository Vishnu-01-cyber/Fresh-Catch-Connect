namespace FishingApp.Model
{
    public class SellerData
    {
        public string FishName { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public string? fileExtention { get; set; }
        public int  FishPrice{ get; set; }
    }
    public class SellerIdData: SellerData
    {
        public int FishId { get; set; }

    }
}
