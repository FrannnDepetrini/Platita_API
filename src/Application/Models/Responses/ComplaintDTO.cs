using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class ComplaintDTO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public ClientDTO Client { get; set; }

        public static ComplaintDTO Create(Complaint? complaint)
        {
            if (complaint == null)
                return null;

            return new ComplaintDTO
            {
                Id = complaint.Id,
                ClientId = complaint.ClientId,
                Description = complaint.Description,
                Status = complaint.Status.ToString(),
                CreatedAt = complaint.CreatedAt,
                Client = ClientDTO.Create(complaint.Client)
            };

        }
    }
}
