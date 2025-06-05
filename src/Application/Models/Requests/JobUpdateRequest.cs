using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Application.Models.Requests
{
    public class JobUpdateRequest
    {
        public string? Title { get; set; }
        //public float AveragePrice { get; set; }
        public DateTime? DayPublicationEnd { get; set; } = DateTime.Now.AddDays(7);

        public string? Category {get; set;}

        public string? Province { get; set; }
        public string? City { get; set; }
        public string? Description { get; set; }

    }
}
