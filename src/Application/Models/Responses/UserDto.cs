// using Domain.Entities;

// namespace Application.Models.Responses;

// public class UserDto
// {
//         public int Id { get; set; }
//         public string Email { get; set; }
//         public string UserName { get; set; }
//         public string PhoneNumber { get; set; }
//         public string Role { get; set; } = default!;

//         public static UserDto Create(User User)
//         {
//             return new UserDto {
//                 Id = User.Id,
//                 Email= User.Email,
//                 UserName = User.UserName,
//                 PhoneNumber = User.PhoneNumber,
//                 Role = User.Role
//             };
//         }

// }