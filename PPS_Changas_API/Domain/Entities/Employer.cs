using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employer : JobUser
    {
        public List<Job> Jobs { get; set; }
    }
}
