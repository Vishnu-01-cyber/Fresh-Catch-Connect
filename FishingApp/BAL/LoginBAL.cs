using FishingApp.Mapper;
using FishingApp.Model;
using FishingApp.Repository;
using System.Data;

namespace FishingApp.BAL
{
    public class LoginBAL : ILoginBAL
    {
        private readonly ILoginRepository LoginRepository;
        LoginMapper mapper = new LoginMapper();

        public LoginBAL(ILoginRepository LoginRepository)
        {
            this.LoginRepository = LoginRepository;
        }
        public LoginData CreateLogin(LoginRequestData loginRequest)
        {
            string query = mapper.CreateLoginDetails(loginRequest);
            int r = LoginRepository.ExecuteScalar(query);
            return GetLoginDetails(r);
        }

        public LoginData GetLoginDetails(int id)
        {
            string query = mapper.GetLoginById(id);
            DataTable dataTable = LoginRepository.GetDataTable(query);
            LoginData loginData = mapper.GetAllLoginDetails(dataTable);
            return loginData;

        }

        public LoginResponse GetLogin(string Email,string Password)
        {
            string query = mapper.GetLoginVerification(Email, Password);
            DataTable dataTable = LoginRepository.GetDataTable(query);
            LoginResponse response = mapper.GetUidPass(dataTable);
            return response;
            
            
            // var result=GetLoginDetails(1);
            // result.Password = "****";
            // return result;
           // return GetLoginDetails(1);
          //  return;
        }

        public List<LoginData> GetAllLogDetails()
        {
            string query = mapper.GetLoginDetails;
            List<LoginData> loginDatas = new List<LoginData>();
            DataTable dataTable = LoginRepository.GetDataTable(query);
            loginDatas = mapper.GetAllData(dataTable);
            return loginDatas;

        }

     
    }
}
