namespace Application.Interfaces;

    public interface IUserService
    {
        Task ChangePasswordAsync(int userId,
                            string password,
                            string newPassword
                            
                            );
        Task UpdateUser(string? email,
                        string? username,
                        int? phoneNumber,
                        int userId
                        );

        Task ResetForgottenPassword (string token,
                            string newPassword);
        Task SendResetPasswordEmail(string email);
    }
