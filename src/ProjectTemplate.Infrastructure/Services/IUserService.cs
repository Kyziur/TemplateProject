namespace ProjectTemplate.Infrastructure.Services
{
    public interface IUserService : IService
    {
        void RegisterUser(string username, string password, string email);
    }
}