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
        public Employer Employer { get; set; }
        public List<Postulation> Postulations { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string DateTime { get; set; }
        public bool Available { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public CategoryEnum CategoryEnum { get; set; }
    }

    
}


