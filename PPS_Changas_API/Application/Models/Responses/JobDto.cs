using Domain.Constants;
using Domain.Entities;

namespace Application.Models.Responses
{
    public class JobDTO
    {
        public string UserName { get; set; } 
        public string Title {get; set;}
        public float AveragePrice { get; set; }
        public int AmountPostulations { get; set; }
        public JobStatusEnum Status {get; set;}
        public string State {get; set;}
        public string City {get; set;}
        public DateTime? DateTime { get; set; }
        public string Description{get; set;}
        public CategoryEnum Category { get; set; }
        public string Picture { get; set; }


        public static JobDTO Create(Job Job)
        {
            return new JobDTO
            {
                UserName = Job.Client.UserName,
                Title = Job.Title,
                AveragePrice = Job.AveragePrice,
                AmountPostulations = Job.AmountPostulations,
                Status = Job.Status,
                State = Job.State,
                City = Job.City,
                DateTime = Job.DateTime,
                Description = Job.Description,
                Category = Job.Category,
                Picture = Job.Picture
            };

        }

    }
}