using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OneTimeToken
    {
        public int Id { get; set; }

        public string Token { get; set; } = null!;

        public int UserId { get; set; }

        public DateTime Expiration { get; set; }

        public bool IsUsed { get; set; }
    }
}
