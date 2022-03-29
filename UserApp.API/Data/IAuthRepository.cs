using System.Threading.Tasks;
using UserApp.API.Models;

namespace UserApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<bool> UserExists(string username);
    }
}