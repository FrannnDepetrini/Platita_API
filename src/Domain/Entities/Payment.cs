using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentEnum Type {get; set;}
        public string Description { get; set; }
    }
}


