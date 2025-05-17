using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Models.Responses
{
    public class PostulationDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        //public JobDTO Job {  get; set; }
    }
}
