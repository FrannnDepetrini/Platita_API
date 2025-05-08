using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses;

public class ClientForJobDTO
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public float Reputation { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }

    public static ClientForJobDTO? Create(Client client)
    {
        if (client == null) { return null; }

        return new ClientForJobDTO
        {
            Id = client.Id,
            UserName = client.UserName,
            Reputation = client.Reputation,
            City = client.City,
            State = client.State
        };
    }
}

