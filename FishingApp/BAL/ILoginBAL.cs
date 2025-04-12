using FishingApp.Model;

namespace FishingApp.BAL
{
    public interface ILoginBAL
    {
        LoginData CreateLogin(LoginRequestData loginRequest);
        LoginData GetLoginDetails(int id);
        LoginResponse GetLogin(string UserName, string Password);

       List <LoginData> GetAllLogDetails();
    }
}
