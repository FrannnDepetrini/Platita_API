using Domain.Constants;
using Domain.Entities;

namespace Application.Models.Responses
{
    public class JobDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; } 
        public string Title {get; set;}
        public float AveragePrice { get; set; }
        public int AmountPostulations { get; set; }
        public JobStatusEnum Status {get; set;}
        public string Province {get; set;}
        public string City {get; set;}
        public DateTime? DateTime { get; set; }
        public string Description{get; set;}
        public CategoryEnum Category { get; set; }
        public string Picture { get; set; }


        public static JobDTO Create(Job Job)
        {
            return new JobDTO
            {
                Id = Job.Id,
                UserName = Job.Client.UserName,
                Title = Job.Title,
                AveragePrice = Job.AveragePrice,
                AmountPostulations = Job.AmountPostulations,
                Status = Job.Status,
                Province = Job.Province,
                City = Job.City,
                DateTime = Job.DateTime,
                Description = Job.Description,
                Category = Job.Category,
                Picture = Job.Picture
            };

        }

    }
}