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
        public int ClientId {get; set;}
        public Client Client { get; set; } = default!;
        public List<Postulation> Postulations { get; set; } = new();
        public int PostulationSelected {get; set;} 
        public string Title { get; set; }
        public float AveragePrice => Postulations.Count == 0 ? 0 : Postulations.Sum(x => x.Budget) / Postulations.Count;
        public int AmountPostulations => Postulations.Count;
        public DateTime? DayPublicationStart { get; set; } = DateTime.Now;
        public DateTime? DayPublicationEnd { get; set; } = DateTime.Now.AddDays(7);
        public JobStatusEnum Status { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public Payment Payment { get; set; }
        public int PaymentId {  get; set; } 
    }
}


