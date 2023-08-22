using ApiClientesNet6.Models;

namespace ApiClientesNet6.Repository
{
    public interface IUserRepositorio
    {
        Task<int> Register(User user, string password);
        Task<string> Login(string userName, string Password);
        Task<bool> UserExiste(string username);
    }
}
