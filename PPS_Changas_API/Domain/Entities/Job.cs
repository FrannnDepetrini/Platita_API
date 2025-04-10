using Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Job
    {
        public string Title { get; set; }
        public float AveragePrice { get; set; }
        public DateTime DateTime { get; set; }
        public bool Available { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }

        public Employer Employer { get; set; }
        public int IdEmployer { get; set; }
        public List<Postulation> Postulations { get; set; } = new();
        public int AmountPostulations => Postulations.Count;

    }
}
