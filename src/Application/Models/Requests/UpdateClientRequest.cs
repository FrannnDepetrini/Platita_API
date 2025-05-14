using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests;

public class UpdateClientRequest
{
    public string UserName { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string PhoneNumber { get; set; }
}
