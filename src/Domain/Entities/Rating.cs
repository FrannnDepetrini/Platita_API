using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int? RatedByUserId { get; set; } 
        public int RatedUserId { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }

        public int JobId { get; set; }

        public Job Job { get; set; }
    }
}
