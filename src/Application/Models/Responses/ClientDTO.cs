using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses;

public class ClientDTO
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; } = default!;

    public static ClientDTO Create(Client? Client)
    {
        if (Client == null) return null;
        return new ClientDTO
        {
            Id = Client.Id,
            Email = Client.Email,
            UserName = Client.UserName,
            City = Client.City,
            Province = Client.Province,
            PhoneNumber = Client.PhoneNumber,
            Role = Client.Role.ToString()
        };
    }

}
