using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class CreateRatingRequest
    {
        public int JobId { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
    }
}
