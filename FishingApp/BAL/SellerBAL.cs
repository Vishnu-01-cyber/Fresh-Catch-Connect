using FishingApp.Mapper;
using FishingApp.Model;
using FishingApp.Repository;
using System.Data;

namespace FishingApp.BAL
{
    public class SellerBAL : ISellerBAL
    {
        private readonly ISellerRepository sellerRepository;
        SellerMapper sellerMapper = new SellerMapper();
        public SellerBAL(ISellerRepository sellerRepository)
        {
            this.sellerRepository = sellerRepository;
        }
        public SellerIdData CreatSellerList(SellerData data)
        {
            string Query = sellerMapper.CreateSellerData(data);
            int r = sellerRepository.ExecuteScalar(Query);
            SellerIdData seller = GetSellerList(r);
            return GetSellerList(r);

        }

        public SellerIdData DeleteSellerList(int id)
        {
            string query = sellerMapper.DeleteSellerDetails(id);
            int s = sellerRepository.ExecuteNonQuery(query);
            SellerIdData seller= GetSellerList(s);
            return seller;
        }

        public List<SellerIdData> GetAllSellerList()
        {
            string Query = sellerMapper.GetAllSellerDetails;
            List<SellerIdData> sellerIds = new List<SellerIdData>();
           DataTable dataTable = sellerRepository.DataTable(Query);
            sellerIds = sellerMapper.GetAllSellerData(dataTable);
            return sellerIds;

        }

        public SellerIdData GetSellerList(int id)
        {
            string Query = sellerMapper.GetAllById(id);
            SellerIdData sellerIdData = new SellerIdData();
            DataTable dataTable = sellerRepository.DataTable(Query);
            sellerIdData = sellerMapper.GetSellerData(dataTable);
            return sellerIdData;

        }

        public SellerIdData updateSellerList(SellerData seller, int id)
        {
            string Query = sellerMapper.UpdateSellerDetails(seller, id);
            int d = sellerRepository.ExecuteNonQuery(Query);
            SellerIdData sellerIdData = GetSellerList(d);

            return sellerIdData;
        }
        public SellerIdData FileUpadete(string imagePath, int id)
        {
            string query =sellerMapper.UpdateFile(imagePath, id);
            int s = sellerRepository.ExecuteNonQuery(query);
            return GetSellerList(id);

        }
    }
}
