using FishingApp.Model;
using System.Data;

namespace FishingApp.Mapper
{
    public class SellerMapper
    {
        public string GetAllSellerDetails = "select*from Seller";

        public string GetAllById(int id)
        {
            string query = $"select*from Seller where FishId={id}";
            return query;
        }

        public SellerIdData GetSellerData(DataTable dataTable)
        {
            SellerIdData seller = new SellerIdData();

            foreach (DataRow item in dataTable.Rows)
            {
                seller.FishId = (int)item["FishId"];
                seller.FishName = (string)item["FishName"];
                seller.Description = (string)item["Description"];
                seller.ImagePath = (string)item["ImagePath"];
                seller.FishPrice = (int)item["FishPrice"];
            }

            return seller;
        }
        public List<SellerIdData> GetAllSellerData(DataTable dataTable)
        {
            List<SellerIdData> sellerDatas = new List<SellerIdData>();
            foreach  (DataRow item in dataTable.Rows)
            {
                sellerDatas.Add(new SellerIdData
                {
                    FishId = (int)item["FishId"],
                    FishName = (string)item["FishName"],
                    Description = (string)item["Description"],
                    ImagePath = (string)item["ImagePath"],
                    FishPrice = (int)item["FishPrice"]
                
                 });

            }
            return sellerDatas;

        }

        public string CreateSellerData(SellerData seller)
        {
            string query = $"insert into Seller values('{seller.FishName}','{seller.Description}','',{seller.FishPrice})select scope_identity()";
            return query;
        }

        public string UpdateSellerDetails(SellerData sellerData,int id)
        {
            string query = $"update Seller set FishName='{sellerData.FishName}',Description='{sellerData.Description}',ImagePath='{sellerData.ImagePath}',FishPrice={sellerData.FishPrice} where FishId={id}";
            return query;
        }
        public string DeleteSellerDetails(int id)
        {
            string query = $"Delete from Seller where FishId={id}";
            return query;
        }

        public string UpdateFile(string imagePath , int id)
        {
            string query = $"update Seller set ImagePath='{imagePath}' where FishId={id}";
            return query;
        }
    }
}
