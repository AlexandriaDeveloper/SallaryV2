using Domain.Interfaces;

namespace Persistence.Services
{
    public class AuthService : IAuthService
    {
        public string GetCurrentLoggedInUser()
        {
            return "Admin";
        }

        public bool IsLoggedIn() { return true; }
    }
}
