using Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        //public Employer Employer { get; set; }
        public string EmployerName {get; set;}
        public List<Postulation> Postulations { get; set; } = new();
        public string Title { get; set; }
        public float AveragePrice => Postulations.Count == 0 ? 0 : Postulations.Sum(x => x.Budget) / Postulations.Count;
        public int AmountPostulations => Postulations.Count;
        public DateTime? DateTime { get; set; }
        public bool Available { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public Job(){}

        public Job(string employerName, string title, string location, string description, CategoryEnum category)
        {
            EmployerName = employerName;
            Title = title;
            Location = location;
            Description = description;
            Category = category;
        }

    }



    
}


