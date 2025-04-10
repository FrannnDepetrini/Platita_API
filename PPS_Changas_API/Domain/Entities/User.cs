using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public List<Rating> Ratings { get; set; } = new();

        // Promedio de la reputación del usuario. EJ: Juan tiene 3,5 de reputación
        public float Reputation => Ratings.Count == 0 ? 0 : Ratings.Sum(v => v.Score) / Ratings.Count;

        public string Role { get; set; } = default!;

        
    }
}


