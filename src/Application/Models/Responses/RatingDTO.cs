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
        public string? RatedByUserId { get; set; } //hace la reseña. token
        public string RatedUserId { get; set; } //recibe reseña. empleador -> job.client.id
                                             //               empleado -> job.postulation.id
        public int Score { get; set; }
        public string Description { get; set; }

        public JobDTO Job { get; set; }

        public static RatingDTO? Create(Rating rating)
        {
            if (rating == null)
            {
                return null;
            }

            return new RatingDTO
            {
                Id = rating.Id,
                RatedByUserId = rating.Job.ClientId == rating.RatedByUserId ? rating.Job.Client.UserName : rating.Job.PostulationSelected.Client.UserName,
                RatedUserId = rating.Job.ClientId == rating.RatedUserId ? rating.Job.Client.UserName : rating.Job.PostulationSelected.Client.UserName,
                Score = rating.Score,
                Description = rating.Description,
                Job = JobDTO.Create(rating.Job)
            };
        }
    }
}
