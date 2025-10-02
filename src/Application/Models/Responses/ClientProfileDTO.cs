using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class ClientProfileDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }


        public static ClientProfileDTO Create(Client? Client)
        {
            if (Client == null) return null;
            return new ClientProfileDTO
            {
                Id = Client.Id,
                UserName = Client.UserName,
                City = Client.City,
                Province = Client.Province,
            };
        }
    }
}
