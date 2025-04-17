using Domain.Constants;
using Domain.Entities;

namespace Application.Model
{
    public class JobsDTO
    {
        public string EmployerName {get; set;}
        public string Title {get; set;}
        //public float AveragePrice {get; set;}
        public bool Available {get; set;}
        public string Location {get; set;}
        public DateTime? DateTime { get; set; }
        public string Description{get; set;}
        public CategoryEnum CategoryEnum {get; set;}

        public static JobsDTO Create(Job Job)
        {
            return new JobsDTO
            {
                //EmployerName = Job.Employer.UserName,
                EmployerName = Job.EmployerName,
                Title = Job.Title,
                //AveragePrice = Job.AveragePrice,
                Available = Job.Available,
                Location = Job.Location,
                DateTime = Job.DateTime,
                Description = Job.Description
                
            };

        }

    }
}