using FishingApp.Model;

namespace FishingApp.BAL
{
    public interface ISellerBAL
    {
        List<SellerIdData> GetAllSellerList();

        SellerIdData GetSellerList(int id);

        SellerIdData CreatSellerList(SellerData data);

        SellerIdData updateSellerList(SellerData seller, int id);

        SellerIdData DeleteSellerList(int id);

        SellerIdData FileUpadete(string imagePath, int id);


    }
}
