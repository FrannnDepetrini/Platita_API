using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class RegisterForSysAdminRequest
    {

        [EmailAddress]
        public required string Email { get; set; }


        public required string Password { get; set; }


        public required string Role { get; set; }

      
        public required string UserName { get; set; }

     
        public required int PhoneNumber { get; set; }
    }
}
