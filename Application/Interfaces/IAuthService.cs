namespace Domain.Interfaces
{
    public interface IAuthService
    {

        string GetCurrentLoggedInUser();
        bool IsLoggedIn();
    }
}
