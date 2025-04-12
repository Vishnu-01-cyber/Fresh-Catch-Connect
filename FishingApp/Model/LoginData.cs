using System.Numerics;

namespace FishingApp.Model
{
   public class LoginRequestData
    {
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set;}

        public int ActionRole { get; set; }
    }
    public class LoginData:LoginRequestData
    {
        public int SNo  { get; set; }
    }


    public class LoginResponse
    {
        public int SNo { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int ActionRole { get; set; }


    }

}
