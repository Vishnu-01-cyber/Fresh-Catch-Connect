using DAL;
using FishingApp.Mapper;
using FishingApp.Model;
using FishingApp.Repository;
using System.Data;

namespace FishingApp.BAL
{
    public class CustomerBAL : ICustomerBAL
    {
        
        private readonly ICustomerRepository customerRepository;
        CustomerMapper customerMapper = new CustomerMapper();


        public CustomerBAL(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

        }
        public List<CustomerData> Customer()
        {
            string query = customerMapper.GetAllCustomer;
            DataTable dataTable = customerRepository.GetTable(query);
            return customerMapper.GetAllCustomersDetails(dataTable);
        }
    }
}
