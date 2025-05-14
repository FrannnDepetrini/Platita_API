using Domain.Entities;

namespace Application.Models.Responses;

public class ClientDto
{
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string City {get; set;}
        public string Province {get; set;}
        public string PhoneNumber { get; set; }
        public string Role { get; set; } = default!;

        public static ClientDto Create(Client Client)
        {
            return new ClientDto {
                Id = Client.Id,
                Email= Client.Email,
                UserName = Client.UserName,
                City = Client.City,
                Province = Client.Province,
                PhoneNumber = Client.PhoneNumber,
                Role = Client.Role
            };
        }

}