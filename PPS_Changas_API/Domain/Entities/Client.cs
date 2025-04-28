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
        public string State {get; set;}

        public string City {get; set;}
        public List<Rating> Ratings { get; set; } = new();
        public List<Job> Jobs { get; set; } = new();
        public PaymentEnum Payment {get; set;}
        public float Reputation => Ratings.Count == 0 ? 0 : Ratings.Sum(v => v.Score) / Ratings.Count;
    }
}


