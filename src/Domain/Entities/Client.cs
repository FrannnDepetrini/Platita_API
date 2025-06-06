using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Domain.Entities
{
    public class Client : User
    {
        public string? Province {get; set;}
        public string? City {get; set;}
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Job> Jobs { get; set; } = new List<Job>();
        public List<Postulation> Postulations { get; set; } = new List<Postulation>();
        public float Reputation => Ratings.Count == 0 ? 0 : Ratings.Sum(v => v.Score) / Ratings.Count;
    }
}


