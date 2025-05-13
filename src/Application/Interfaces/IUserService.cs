namespace Application.Interfaces;

    public interface IUserService
    {
      
        Task UpdateUser(string? email,
                        string? username,
                        int? phoneNumber,
                        int userId
                        );

    }
