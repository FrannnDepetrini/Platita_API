using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class RegisterRequest
    {

        [EmailAddress]
        public required string Email { get; set; }

 
        [StringLength(100, MinimumLength = 3)]
        public required string Password { get; set; }


        [StringLength(100, MinimumLength = 3)]
        public required string State{ get; set; }

  
        [StringLength(100, MinimumLength = 3)]
        public required string City{ get; set; }

 
        [StringLength(100, MinimumLength = 3)]
        public required string UserName { get; set; }

   
        public required int PhoneNumber { get; set; }
    }
}
