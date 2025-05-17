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
        public string Status {get; set;}
        public string Province {get; set;}
        public string City {get; set;}
        public DateTime? DayPublicationStart { get; set; }
        public DateTime? DayPublicationEnd { get; set; }
        public string Description{get; set;}
        public string Category { get; set; }


        public static JobDTO Create(Job Job)
        {
            return new JobDTO
            {
                Id = Job.Id,
                UserName = Job.Client.UserName,
                Title = Job.Title,
                AveragePrice = Job.AveragePrice,
                AmountPostulations = Job.AmountPostulations,
                Status = Job.Status.ToString(),
                Province = Job.Province,
                City = Job.City,
                DayPublicationStart = Job.DayPublicationStart,
                DayPublicationEnd = Job.DayPublicationEnd,
                Description = Job.Description,
                Category = Job.Category.ToString()
            };

        }

    }
}