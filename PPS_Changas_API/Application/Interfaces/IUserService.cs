namespace Application.Interfaces;

    public interface IUser
    {
        Task ChangePassword(string email,
                            string password,
                            string newPassword
                            );
        Task UpdateUser(string ? email,
                        string ? username,
                        int ? phoneNumber
                        );

        Task ResetPassword (string token,
                            string newPassword);
        Task SendResetPasswordEmail(string email);
    }
