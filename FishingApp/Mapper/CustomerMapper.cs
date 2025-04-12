using FishingApp.Model;
using System.Data;

namespace FishingApp.Mapper
{
    public class CustomerMapper
    {
       public string GetAllCustomer = "select*from Seller";

        public List<CustomerData> GetAllCustomersDetails(DataTable dataTable)
        {
            List<CustomerData> customers = new List<CustomerData>();

            foreach (DataRow item in dataTable.Rows)
            {
                customers.Add(new CustomerData {
                    FishId = (int)item["FishId"],
                    FishName = (string)item["FishName"],
                    Description = (string)item["Description"],
                    ImagePath = (string)item["ImagePath"],
                    FishPrice = (int)item["FishPrice"]
                });

            }
            return customers;
        }
    }
}
