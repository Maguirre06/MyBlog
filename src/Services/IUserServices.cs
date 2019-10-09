namespace Myblog.Core.Services
{
    public interface IUserServices
    {
        bool ValidateUser(string username, string password);
    }
}
