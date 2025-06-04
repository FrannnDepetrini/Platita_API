using Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class UpdateUserRequest
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
