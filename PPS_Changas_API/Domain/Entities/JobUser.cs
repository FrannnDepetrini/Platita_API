using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobUser
    {
        public List<Rating> Ratings { get; set; } = new();

        // Promedio de la reputación del usuario. EJ: Juan tiene 3,5 de reputación
        public float Reputation => Ratings.Count == 0 ? 0 : Ratings.Sum(v => v.Score) / Ratings.Count;
    }
}
