using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class RatingDTO
    {
        public int Id { get; set; }
        public int RatedByUserId { get; set; } //hace la reseña. token
        public int RatedUserId { get; set; } //recibe reseña. empleador -> job.client.id
                                             //               empleado -> job.postulation.id
        public int Score { get; set; }
        public string Description { get; set; }

        public int JobId { get; set; }

        public Job Job { get; set; }
    }
}
