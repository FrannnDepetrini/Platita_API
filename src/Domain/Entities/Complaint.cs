using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Domain.Entities
{
    public class Complaint
    {
        public int Id { get; set; }
        public Client Client {get; set;}
        public int ClientId {get; set;}
        public string Description { get; set; }
        public ComplaintStatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}


