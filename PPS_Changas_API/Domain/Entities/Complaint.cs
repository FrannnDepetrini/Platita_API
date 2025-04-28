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
        public Client Client {get; set;}

        public int ClientId {get; set;}
        public int SupportId {get; set;}
        public Support Support { get; set; }
        public string Description { get; set; }
        // public StatusSupportEnum Status {get; set;}
        public DateTime CreatedAt { get; set; }

    }
}


