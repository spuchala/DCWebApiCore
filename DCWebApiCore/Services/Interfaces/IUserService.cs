using DCWebApiCore.Models;

namespace DCWebApiCore.Services.Interfaces
{
    public interface IUserService
    {
        User LoginUser(string userName, string password);
    }
}
