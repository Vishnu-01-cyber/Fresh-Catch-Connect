using FishingApp.Model;
using System.Data;

namespace FishingApp.Mapper
{
    public class LoginMapper
    {
        public string GetLoginDetails = "select*from Login";

        public string GetLoginById(int id)
        {
            string query = $"select * from Login where SNo='{id}'";
            return query;
        }

        public string GetLoginVerification(string Email ,string Password)
        {
            string query = $"select * from Login where Email='{Email}' and Password='{Password}'";
            //select* from Login where UserName = 'babin' and Password = 'bain';

            return query;
        }

        public LoginData GetAllLoginDetails(DataTable dataTable)
        {
            LoginData loginData = new LoginData();
            foreach (DataRow item in dataTable.Rows)
            {

                loginData.SNo = (int)item["SNo"];
                loginData.UserName = (string)item["UserName"];
                loginData.Email = (string)item["Email"];
                loginData.Password = (string)item["Password"];
                loginData.Gender = (string)item["Gender"];
                loginData.PhoneNumber = (string)item["PhoneNumber"];
                loginData.ActionRole = (int)item["ActionRole"];
               
            }
            return loginData;
        }
        public LoginResponse GetUidPass(DataTable dataTable)
        {
            LoginResponse response = new LoginResponse();
            foreach (DataRow item in dataTable.Rows)
            {
                response.SNo = (int)item["SNo"];
                response.UserName = (string)item["UserName"];
                response.Email = (string)item["Email"];
                response.Gender = (string)item["Gender"];
                response.PhoneNumber = (string)item["PhoneNumber"];
                response.ActionRole = (int)item["ActionRole"];
                
            }
            return response;
        }

        public string CreateLoginDetails(LoginRequestData loginRequest)
        {
            string Query = $"insert into Login values('{loginRequest.UserName}','{loginRequest.Email}','{loginRequest.Password}','{loginRequest.Gender}','{loginRequest.PhoneNumber}',{loginRequest.ActionRole})select scope_identity()";
            return Query;
        }

        public List<LoginData> GetAllData(DataTable dataTable)
        {
            List<LoginData> requestDatas = new List<LoginData>();
            foreach (DataRow item in dataTable.Rows)
            {
                requestDatas.Add(new LoginData
                { SNo = (int)item["SNo"],
                    UserName = (string)item["UserName"],
                    Email = (string)item["Email"],
                    Gender = (string)item["Gender"],
                    PhoneNumber = (string)item["PhoneNumber"],
                    ActionRole = (int)item["ActionRole"]
                }); ;
            }
            return requestDatas;

        }

       
    }
}
