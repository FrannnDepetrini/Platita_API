using Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Postulation
    {
        public Job Job { get; set; }
        public Employee Employee { get; set; }
        public StatusEnum Status { get; set; }
    }
}
