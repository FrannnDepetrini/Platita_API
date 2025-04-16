using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : JobUser
    {
        public List<Postulation> Postulations { get; set; }
    }
}
