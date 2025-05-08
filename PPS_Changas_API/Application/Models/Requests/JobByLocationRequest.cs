using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class JobByLocationRequest
    {
        public string State { get; set; }
        public string City { get; set; }
        
    }
}
