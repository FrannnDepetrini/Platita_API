using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests;

public  class ResetForgottenPasswordRequest
{

    public required string Token { get; set; }

    public required string NewPassword { get; set; }
 
}
