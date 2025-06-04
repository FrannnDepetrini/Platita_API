namespace Application.Interfaces;

    public interface IUserService
    {

        Task<object> GetUser(int userId, string userRole);

    }
