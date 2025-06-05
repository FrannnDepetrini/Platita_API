using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class AllJobsDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public float AveragePrice { get; set; }
        public int AmountPostulations { get; set; }
        public string Status { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public DateTime? DayPublicationStart { get; set; }
        public DateTime? DayPublicationEnd { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int ReportCount { get; set; }

        public static AllJobsDTO Create(Job job)
        {
            return new AllJobsDTO
            {
                Id = job.Id,
                UserName = job.Client.UserName,
                Title = job.Title,
                AveragePrice = job.AveragePrice,
                AmountPostulations = job.AmountPostulations,
                Status = job.Status.ToString(),
                Province = job.Province,
                City = job.City,
                DayPublicationStart = job.DayPublicationStart,
                DayPublicationEnd = job.DayPublicationEnd,
                Description = job.Description,
                Category = job.Category.ToString(),
                ReportCount = job.Reports?.Count ?? 0
            };

        }
    }
}
